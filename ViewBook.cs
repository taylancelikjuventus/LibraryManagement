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
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        /************Functions***********************/
        /**************Returns ALL Books From NewBook table of given Database**********************/
        private void ReturnALLBooks()
        {
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

            cmd.CommandText = "select * from NewBook";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            //Setting DataSource of table(DataGridView) to DS.Tables[0]
            dataGridView1.DataSource = DS.Tables[0];

            //setting Table Properties
            dataGridView1.RowHeadersVisible = false; //don't show headers on the left side of Rows
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
            cmd.CommandText = "select * from NewBook WHERE bname='" + txtEditBname.Text + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            avail_qty = int.Parse(DS.Tables[0].Rows[0][7].ToString());
            //check number
            Console.WriteLine("AVAIL_QTY inside function = " + avail_qty);

            conn.Close();

            return avail_qty;
        }

        /***********Function to check Available Quantity from NewBook Table*************************/
        private int ReturnTotalQuantity()
        {
            int total_qty = 0;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=DESKTOP-C8BKT6R\\SQLEXPRESS01" +
                   " ;database=librarymanagementsystem ;integrated security=True;";
            //Open Connection
            conn.Open();
            //sql statement
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from NewBook WHERE bname='" + txtEditBname.Text + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            total_qty = int.Parse(DS.Tables[0].Rows[0][6].ToString());
            //check number
            Console.WriteLine("AVAIL_QTY inside function = " + total_qty);

            conn.Close();

            return total_qty;
        }



        /**************IF This Form is Loaded Show Available Books On Table of This Form*********************/
        private void ViewBook_Load(object sender, EventArgs e)
        {
            //make Edit PAnel invisible
            panelEdit.Hide();

            //return ALL Books 
            ReturnALLBooks();
          
        }

        /***********************If any Cell of table is clicked*****************************/
        int bookid; //stores selected row's index from table
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
            //get the book id from of selected row
            //eger satır veya cell lerden herhangi biri tıklanırsa
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    bookid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    // Console.WriteLine(bookid +10);

                    panelEdit.Show(); //shows hidden edit panel  

                    /*
                     After User clicked any cell of table we show the selected book
                     on the Edit Panel
                     */
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
                    cmd.CommandText = "select * from NewBook WHERE bid ='"+bookid+"'";

                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);

                    //show selected book on edit panel
                    txtEditBname.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtEditBAutName.Text = DS.Tables[0].Rows[0][2].ToString();
                    txtEditBPublication.Text = DS.Tables[0].Rows[0][3].ToString();
                    dateTimePickerOfEditPAnel.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtEditPrice.Text = DS.Tables[0].Rows[0][5].ToString();
                    txtEditQuantity.Text = DS.Tables[0].Rows[0][6].ToString();

                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        /****************IF Cancel button of Edit panel is clicked HIDE Edit Panel***********/
        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
        }

        /**********IF txtSearchBookName's text changes************/
        private void txtSearchBookName_TextChanged(object sender, EventArgs e)
        {

            //We Use LIKE of MSSQL to list matched books
            if(txtSearchBookName.Text != "")
            {
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
                
                //Pay attention WE USED LIKE  , select * from NewBook where bname LIKE 'PHP%' ;
                cmd.CommandText = "select * from NewBook WHERE bName LIKE '"+txtSearchBookName.Text+"%'";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                //Setting DataSource of table(DataGridView) to DS.Tables[0]
                dataGridView1.DataSource = DS.Tables[0];
            }
            else //if nothing is in textfield show ALL books on table
            {
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

                cmd.CommandText = "select * from NewBook";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                //Setting DataSource of table(DataGridView) to DS.Tables[0]
                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        /************If refresh is clicked***************/
        private void btnSearchRefresh_Click(object sender, EventArgs e)
        {
            txtSearchBookName.Clear(); //clear text field of search 
            panelEdit.Visible = false; //hide Edit panel
            ReturnALLBooks();          //Refresh table/DataGridView of ViewBooks


        }

        /***************if update button of Edit panel is clicked *************/
        private void btnEditUpdate_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(this, "Do You want to update selected row?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //if update is clicked We update NewBook table of DB
                string bname = txtEditBname.Text;
                string baname = txtEditBAutName.Text;
                string bpubl = txtEditBPublication.Text;
                string bpubdate = dateTimePickerOfEditPAnel.Text;
                float bprice = float.Parse(txtEditPrice.Text);
                int bqty = int.Parse(txtEditQuantity.Text);

                //Update NewBook table of Database

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

                /*insert fields into NewBook table and update Available book quantity too*/
                cmd.CommandText = "update NewBook set bName='" + bname + "',bAuthor='" + baname + "',bPubl='" + bpubl + "',bPDate='" + bpubdate + "',bPrice='" + bprice + "',bQuan='" + (bqty+ReturnTotalQuantity() ) + "',Avail_Book_Qty='"+(bqty + ReturnAvailableQuantity())+"' where bid='" + bookid + "'";

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show(this, "Row updated...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /****************if delete button of Edit panel is cilcked*********************/
        private void btnEditDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(this, "Do You want to delete selected row?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                //delete selected row

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

                //DELETE SELECTED ROW FROM table NewBook
                cmd.CommandText = "delete from NewBook WHERE bid='"+bookid+"'";

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show(this, "Row deleted...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
