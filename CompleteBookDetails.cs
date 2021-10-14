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
    public partial class CompleteBookDetails : Form
    {
        public CompleteBookDetails()
        {
            InitializeComponent();
        }

        /**************IF FORM is Loaded*******************/
        private void CompleteBookDetails_Load(object sender, EventArgs e)
        {
            //MSSQL
            SqlConnection conn1 = new SqlConnection();
            conn1.ConnectionString = "data source=DESKTOP-C8BKT6R\\SQLEXPRESS01" +
                   " ;database=librarymanagementsystem ;integrated security=True;";
            //Open Connection
            conn1.Open();
            //sql statement
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn1;

            cmd1.CommandText = "select * FROM IssueBook WHERE book_return_date='null'";
            SqlDataAdapter DA1 = new SqlDataAdapter(cmd1);
            DataSet DS1 = new DataSet();
            DA1.Fill(DS1);

            dataGridViewIssuedBooks.DataSource = DS1.Tables[0];

            conn1.Close();


            //fill other table
            //MSSQL
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=DESKTOP-C8BKT6R\\SQLEXPRESS01" +
                   " ;database=librarymanagementsystem ;integrated security=True;";
            //Open Connection
            conn.Open();
            //sql statement
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * FROM IssueBook WHERE book_return_date<>'null'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridViewReturnedBooks.DataSource = DS.Tables[0];

            conn.Close();




        }
    }
}
