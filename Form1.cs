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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        /******if Close icon is clicked Close This Form*************/
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /******if username clicked clear text field*************/
        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if(textBox1.Text == "Username")
            textBox1.Text = "";
        }
        /******if password clicked clear text field*************/
        private void textBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if(textBox2.Text == "Password")
            textBox2.Text = "";
        }

        /*****************If Youtube icon clicked connect that WEB SITE****************/
        private void pboxYoutube_Click(object sender, EventArgs e)
        {
            //connects to given url
            System.Diagnostics.Process.Start("https://www.youtube.com/");
        }
        /*****************If Login clicked****************/
        private void button1_Click(object sender, EventArgs e)
        {
            //connect to logintable and check username and password
            SqlConnection conn = new SqlConnection();
            //datasource,database,integrated security
            conn.ConnectionString = "data source=DESKTOP-C8BKT6R\\SQLEXPRESS01" +
                " ;database=librarymanagementsystem ;integrated security=True;";
            //Open Connection
            conn.Open();
            //sql statement
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            string sql =
         "select * from logintable WHERE username='"+textBox1.Text+"' and pass='"+textBox2.Text+"'";
            cmd.CommandText = sql;

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            if(DS.Tables[0].Rows.Count != 0)
            {
                //hide login form  
                this.Hide();

                //open Dashbord form
                Dashboard db = new Dashboard();
                db.Show();

            }
            else
            {
                MessageBox.Show(this, "Username or password is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }
    }
}
