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
    public partial class AddBooks : Form
    {
        public AddBooks()
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
            cmd.CommandText = "select * from NewBook WHERE bname='" + txtBookName.Text + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            avail_qty = int.Parse(DS.Tables[0].Rows[0][7].ToString());
            //check number
            Console.WriteLine("AVAIL_QTY inside function = " + avail_qty);

            conn.Close();

            return avail_qty;
        }



        /***********IF save clicked insert data into NewBook table*********/
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!double.Parse(txtPrice.Text).GetType().IsValueType )
            {
                MessageBox.Show(this, "Please enter a value for price...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!int.Parse(txtQty.Text).GetType().IsValueType)
            {
                MessageBox.Show(this, "Please enter an integer value for quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (txtBookName.Text != "" && 
                txtBookAuthorName.Text!="" &&
                txtPrice.Text!="" && 
                txtPublication.Text !="" &&
                txtQty.Text != ""  
                
                ) {

                

                string bname = txtBookName.Text;
                string bauthor = txtBookAuthorName.Text;
                string publication = txtPublication.Text;
                string pDate = dateTimePickerPurchaseDate.Text;
                float price = float.Parse(txtPrice.Text);
                int qty = int.Parse(txtQty.Text);

                //MSSQL
                SqlConnection conn = new SqlConnection();
                //datasource,database,integrated security
                conn.ConnectionString = "data source=DESKTOP-C8BKT6R\\SQLEXPRESS01" +
                    " ;database=librarymanagementsystem ;integrated security=True;";
                //Open Connection
                conn.Open();
                //sql statement
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "insert into NewBook(bName,bAuthor,bPubl,bPDate,bPrice,bQuan,Avail_Book_Qty) values('" + bname + "','" + bauthor + "','" + publication + "','" + pDate + "','" + price + "','" + qty + "','"+(ReturnAvailableQuantity() + qty)+"')";
                cmd.ExecuteNonQuery();

                //close connection
                conn.Close();

                //inform user
                MessageBox.Show(this, "Book inserted...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //clear form fields
                txtBookAuthorName.Clear();
                txtBookName.Clear();
                txtPrice.Clear();
                txtQty.Clear();
                txtPublication.Clear();
                dateTimePickerPurchaseDate.ResetText();

            }
            else
            {
                MessageBox.Show(this, "Please fill ALL Form Fields ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /***********IF Cancel Button clicked*****************************/
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(this,"Do you want to close this Window?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
               this.Dispose();
        }
    }
}
