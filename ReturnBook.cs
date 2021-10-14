using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
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
            cmd.CommandText = "select * from NewBook WHERE bname='" + txtBname.Text + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            avail_qty = int.Parse(DS.Tables[0].Rows[0][7].ToString());
            //check number
            Console.WriteLine("AVAIL_QTY ReturnBook FROM = " + avail_qty);

            conn.Close();

            return avail_qty;
        }


        /***********IF Search Student is clicked******/
        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            //MSSQL
            SqlConnection conn3 = new SqlConnection();
            conn3.ConnectionString = "data source=DESKTOP-C8BKT6R\\SQLEXPRESS01" +
                   " ;database=librarymanagementsystem ;integrated security=True;";
            //Open Connection
            conn3.Open();
            //sql statement
            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = conn3;
            
            /******Return Only Books that are not returned*****/
            cmd3.CommandText = "select * from IssueBook WHERE std_enroll ='"+txtEnrollNo.Text+"' AND book_return_date='null'";
            
            /*AND Show returned Data On Table of GUI*/
            SqlDataAdapter DA3 = new SqlDataAdapter(cmd3);
            DataSet DS3 = new DataSet();
            DA3.Fill(DS3);

            if (DS3.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = DS3.Tables[0];
            }
            else
            {
                MessageBox.Show(this, "Wrong enrollment Number OR No Record Found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn3.Close();

        }
        /****************IF This Form is loaded hide Panel At the bottom*****************/
        private void ReturnBook_Load(object sender, EventArgs e)
        {
            //hide Panel Below
            panel3.Visible = false;
            txtEnrollNo.Clear();

        }

        int selectedRowID;
        /*********If Any cell of table clicked****************/
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                //store selected book's id
                selectedRowID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                //Return BookName and IssueDate From IssueBook Table of Database
                //MSSQL
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source=DESKTOP-C8BKT6R\\SQLEXPRESS01" +
                       " ;database=librarymanagementsystem ;integrated security=True;";
                //Open Connection
                conn.Open();
                //sql statement
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                /******Return Only Books that are not returned*****/
                cmd.CommandText = "select * from IssueBook WHERE id='"+selectedRowID+"'";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                //show data of selected row on panel
                panel3.Visible = true;
                txtBname.Text = DS.Tables[0].Rows[0][7].ToString();
                txtBookIssueDate.Text = DS.Tables[0].Rows[0][8].ToString();

                conn.Close();


            }
         



        }

       
        /*************IF Return clicked*******************/
        
        private void button4_Click(object sender, EventArgs e)
        {
            //MSSQL
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=DESKTOP-C8BKT6R\\SQLEXPRESS01" +
                   " ;database=librarymanagementsystem ;integrated security=True;";
            //Open Connection
            conn.Open();
            //sql statement
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            //Return Only Books that are not returned
            cmd.CommandText = "update IssueBook set book_return_date='" + dateTimePickerBookReturnDate.Text + "' WHERE std_enroll='"+txtEnrollNo.Text+"' AND  id='"+selectedRowID+"'";
            cmd.ExecuteNonQuery();
            conn.Close();


            //INCREASE Available Book column in NewBook TAble
            //MSSQL
            SqlConnection conn1 = new SqlConnection();
            conn1.ConnectionString = "data source=DESKTOP-C8BKT6R\\SQLEXPRESS01" +
                   " ;database=librarymanagementsystem ;integrated security=True;";
            //Open Connection
            conn1.Open();
            //sql statement
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn1;

            //Return Only Books that are not returned
            cmd1.CommandText = "update NewBook set Avail_Book_Qty = '"+(ReturnAvailableQuantity()+1)+"' WHERE bName='"+txtBname.Text+"'";
           
            cmd1.ExecuteNonQuery();
            conn1.Close();

            //Inform user
            MessageBox.Show(this, "Book returned successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //clear fields
            txtBname.Clear();
            txtBookIssueDate.Clear();
            dateTimePickerBookReturnDate.ResetText();
            txtEnrollNo.Clear();
            dataGridView1.DataSource = null;
        }

        /**********If cancel of Bottom panel is clicked**/
        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Hide();
        }

        /*********IF Text Of txtEnrollNo changes**********/
        private void txtEnrollNo_TextChanged(object sender, EventArgs e)
        {
            if(txtEnrollNo.Text == "")
            {
                panel3.Hide();
                dataGridView1.DataSource = null;
            }
        }

        /*********If Cancel is clicked **************/
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /********if Refresh Clicked***************/
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //refresh Table 
            btnSearchStudent_Click(this, null);
        }
    }
}
