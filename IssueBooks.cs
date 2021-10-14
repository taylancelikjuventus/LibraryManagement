using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }

        /***********Function to check Available Quantity from NewBook Table*************************/
        private int ReturnAvailableQuantity()
        {
            int avail_qty = 0;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=DESKTOP-C8BKT6R\\SQLEXPRESS01" +
                   " ;database=librarymanagementsystem ;integrated security=True;";
            //Open Connection
            conn.Open();
            //sql statement
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from NewBook WHERE bname='"+comboBookName.SelectedItem+"'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            avail_qty = int.Parse(DS.Tables[0].Rows[0][7].ToString() ) ;
            //check number
            Console.WriteLine("AVAIL_QTY = "+avail_qty);

            conn.Close();

            return avail_qty;
        }

        /******************After issued Book Decrease Available quantity number from NewBook table*******/
        public void updateAvailableQuantity()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=DESKTOP-C8BKT6R\\SQLEXPRESS01" +
                   " ;database=librarymanagementsystem ;integrated security=True;";
            //Open Connection
            conn.Open();
            //sql statement
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update NewBook set Avail_Book_Qty ='"+(ReturnAvailableQuantity() - 1)+"' WHERE bname ='"+comboBookName.SelectedItem+"'";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /**************IF this form is loaded************************/
        private void IssueBooks_Load(object sender, EventArgs e)
        {
            //Here we need to return Available Books from NewBook DB table and list them
            // in combobox

            //MSSQL
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=DESKTOP-C8BKT6R\\SQLEXPRESS01" +
                   " ;database=librarymanagementsystem ;integrated security=True;";
            //Open Connection
            conn.Open();
            //sql statement
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select bName from NewBook"; //return All Book Names From Table

            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                    comboBookName.Items.Add(sdr.GetValue(i).ToString());
            }

            //close SDR
            sdr.Close();
            conn.Close();

        }

        /**************IF Search Student button clicked******************/
        private void btnSearchStudent_Click(object sender, EventArgs e)
        {

            if (txtEnrollNo.Text != null) {
                //MSSQL
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source=DESKTOP-C8BKT6R\\SQLEXPRESS01" +
                       " ;database=librarymanagementsystem ;integrated security=True;";
                //Open Connection
                conn.Open();
                //sql statement
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from NewStudent WHERE enroll = '"+txtEnrollNo.Text+"'";

                //store results in DataSet
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                try
                {
                    txtsname.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtDepart.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtSemester.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtContact.Text = DS.Tables[0].Rows[0][5].ToString();
                    txtEmail.Text = DS.Tables[0].Rows[0][6].ToString();
                }catch(Exception ex) /*automatically handels error if enrollno is not in DB*/
                {
                    MessageBox.Show(this,"There is no Student with this enrollment number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //clear form fields
                    txtsname.Text = "";
                    txtDepart.Text = "";
                    txtSemester.Text = "";
                    txtContact.Text = "";
                    txtEmail.Text = "";
                    txtEnrollNo.Text = "";
                    dateTimePickerIssueDate.ResetText();
                    comboBookName.ResetText();
                }


            }
            else
            {
                MessageBox.Show(this, "Please enter Enrollment Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //clear form fields
                txtsname.Text = "";
                txtDepart.Text ="";
                txtSemester.Text = "";
                txtContact.Text = "";
                txtEmail.Text = "";
                txtEnrollNo.Text = "";
                dateTimePickerIssueDate.ResetText();
                comboBookName.ResetText();

            }
        }

        int book_avail_qty;
        /***************if issue book is clicked******************/
        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            //First we need To check Avail_Book_Qty from NewBook table
            book_avail_qty =  ReturnAvailableQuantity();
            Console.WriteLine("book_avail_qty = " + book_avail_qty);


            //Secondly, We need to check how many book student issued
            //MSSQL
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=DESKTOP-C8BKT6R\\SQLEXPRESS01" +
                   " ;database=librarymanagementsystem ;integrated security=True;";
            //Open Connection
            conn.Open();
            //sql statement
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            //we return records from IssueBook Table where books are not returned   // not in MSSQL always use give values inside single quotes     
            cmd.CommandText = "select count(std_enroll) FROM IssueBook WHERE std_enroll='"+txtEnrollNo.Text+"' and book_return_date='null'";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            //WE Store count of not returned books
            int CheckCount = int.Parse(DS.Tables[0].Rows[0][0].ToString());

            Console.WriteLine("issued books number =" + CheckCount);

            conn.Close();


            //if student name appears on textbox that means enrollno is correct
            //and all the other fields are given
            if (txtsname.Text != null && comboBookName.Text !="--select--" ) 
            {
                //CHECK IF STUDENT MORE THAN 3 Books ISSUED and not returned
                if (CheckCount < 3)
                {
                    if (book_avail_qty > 0) {//Control Stock
                        //insert fields on GUI into IssueBook table of DB
                        //MSSQL
                        SqlConnection conn1 = new SqlConnection();
                        conn1.ConnectionString = "data source=DESKTOP-C8BKT6R\\SQLEXPRESS01" +
                               " ;database=librarymanagementsystem ;integrated security=True;";
                        //Open Connection
                        conn1.Open();
                        //sql statement
                        SqlCommand cmd1 = new SqlCommand();
                        cmd1.Connection = conn1;
                        cmd1.CommandText = "insert into IssueBook(std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date,book_return_date) VALUES('"
                            + txtEnrollNo.Text + "','" + txtsname.Text + "','" + txtDepart.Text + "','" + txtSemester.Text + "','" + Int64.Parse(txtContact.Text)
                            + "','" + txtEmail.Text + "','" + comboBookName.SelectedItem.ToString() + "','" + dateTimePickerIssueDate.Text + "','NULL')";

                        cmd1.ExecuteNonQuery();
                        conn1.Close();

                        MessageBox.Show(this, "Book issued ...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //HERE IS MOST IMPORTANT PART To update Available Number Of Books
                        //Decrease Number of Avail_Book_Qty from NewBook table
                        updateAvailableQuantity();
                    }
                    else
                    {
                        MessageBox.Show(this, "No Books Available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Student has issued MAX number of books!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(this, "Please select Book and enter Issue Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           




        }

        /**************IF text of searchbox is changed***************/
        private void txtEnrollNo_TextChanged(object sender, EventArgs e)
        {
            if (txtEnrollNo.Text == "")
                //clear form fields
            txtsname.Text = "";
            txtDepart.Text = "";
            txtSemester.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            dateTimePickerIssueDate.ResetText();
            comboBookName.ResetText();
        }
        /*************if Refresh button is clicked*******************/
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnrollNo.Clear();
        }

        /*********IF cancel button clicked close this Window*********/
        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(this,"Do you close this Window ?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            { 
               this.Close();
            }

        }
    }
}
