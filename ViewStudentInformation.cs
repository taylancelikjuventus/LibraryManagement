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
    public partial class ViewStudentInformation : Form
    {
        public ViewStudentInformation()
        {
            InitializeComponent();
        }

        /************Functions*********************/
        //Return All Students registered.
        private void ReturnALLStudents()
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
            //return all cloumns from NewStudent table
            cmd.CommandText = "select * from NewStudent";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            //Setting DataSource of table(DataGridView) to DS.Tables[0]
            dataGridView1.DataSource = DS.Tables[0];

            //setting Table Properties
            dataGridView1.RowHeadersVisible = false; //don't show headers on the left side of Rows
        }


        /************If text changes in textfields************/
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEnrollNo.Text != "")
            {
                //change image of picture box 
                pictureBox1.Image = Image.FromFile(@"D:\CurrentProjects\C#Projects\LibraryManagementSystem\LibraryManagementSystemICONS\search1.gif");


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
                //return all cloumns from NewStudent table
                cmd.CommandText = "select * from NewStudent WHERE enroll LIKE '" + txtSearchEnrollNo.Text + "%'";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                //Setting DataSource of table(DataGridView) to DS.Tables[0]
                dataGridView1.DataSource = DS.Tables[0];

                //setting Table Properties
                dataGridView1.RowHeadersVisible = false; //don't show headers on the left side of Rows

            }
            else
            {
                //IF textfield of search is empty change image of pictureBox
                pictureBox1.Image = Image.FromFile(@"D:\CurrentProjects\C#Projects\LibraryManagementSystem\LibraryManagementSystemICONS\searchStudent.png");
                //Return all students and show on table of Gui           
                ReturnALLStudents();
            }
        }

        /************If this form is loaded**********************/
        private void ViewStudentInformation_Load(object sender, EventArgs e)
        {
            //hide student edit panel 
            EditStudentPanel.Visible = false;

            //Connect to table NewStudent in database and return all records and show on table of GUI
            ReturnALLStudents();

        }


        int studentid;
        /**********If Any cell of Table of GUI is clicked,Show that row on Edit Panel****************/
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if any cell is clicked on the dataGridView1 
            if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                //STORE studentID of clicked row
                //Cells[0] selects Column index 0 that is standing for stuid on dataGridView1
                studentid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() );
                // Console.WriteLine(studentid);
                EditStudentPanel.Visible = true;

                //Return Row from NewStudent table
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
                //return all cloumns from NewStudent table
                cmd.CommandText = "select * from NewStudent WHERE stuid = '" + studentid + "'";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                //Setting DataSource of table(DataGridView) to DS.Tables[0]
                dataGridView1.DataSource = DS.Tables[0];

                //setting Table Properties
                dataGridView1.RowHeadersVisible = false; //don't show headers on the left side of Rows

                /*Show Returned row on Edit Panel*/
                txtEditSname.Text = DS.Tables[0].Rows[0][1].ToString();
                txtEditEnrollNo.Text = DS.Tables[0].Rows[0][2].ToString();
                txtEditDepart.Text = DS.Tables[0].Rows[0][3].ToString();
                txtEditSemester.Text = DS.Tables[0].Rows[0][4].ToString();
                txtEditContact.Text = DS.Tables[0].Rows[0][5].ToString();
                txtEditEmail.Text = DS.Tables[0].Rows[0][6].ToString();


            }
            


        }

        /************If Cancel button of Edit panel clicked*******************/
        private void button4_Click(object sender, EventArgs e)
        {
            //hide edit panel
            EditStudentPanel.Visible = false;
            //show all students on GUI table
            ReturnALLStudents();
        }

        /**************If Update is clicked************************/
        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(this, "Do you want to Update Selected Row = ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //Update selected student in  NewStudent table
                string sname = txtEditSname.Text;
                string enrollno = txtEditEnrollNo.Text;
                string depart = txtEditDepart.Text;
                string semester = txtEditSemester.Text;
                Int64 contact = Int64.Parse(txtEditContact.Text);
                string email = txtEditEmail.Text;


                //UPDATE NEwStudent Table in DataBase
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
                //return all cloumns from NewStudent table
                cmd.CommandText = "update NewStudent set sname='" + sname + "',enroll='" + enrollno + "',dep='" + depart + "',sem='" + semester + "',contact='" + contact + "',email='" + email + "' WHERE stuid ='" + studentid + "'";
                cmd.ExecuteNonQuery();

                conn.Close();

                //inform user
                MessageBox.Show(this, "Selected Student is updated...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //clear Fields
               txtEditSname.Text="";
               txtEditEnrollNo.Text="";
               txtEditDepart.Text="";
               txtEditSemester.Text="";
               txtEditContact.Text="";
               txtEditEmail.Text="";


            }


           //UPDATE DataGridView1(Table of GUI) as well
            ReturnALLStudents();

           

        }

        /********************IF Refresh is Clicked**********************/
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //reload form
            ViewStudentInformation_Load(this, null);
            //clear textfield for search
            txtSearchEnrollNo.Text = "";
        }


        /************If delete is clicked********************/
        private void button3_Click(object sender, EventArgs e)
        {

          if (MessageBox.Show(this, "Do you want to delete selected Student?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
             {
                //UPDATE NEwStudent Table in DataBase
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
                //delete selected row from NewStudent table
                cmd.CommandText = "delete from NewStudent where stuid='" + studentid + "'";
                cmd.ExecuteNonQuery();

                conn.Close();

                //inform user
                MessageBox.Show(this, "Selected Student is deleted...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            //refresh table of GUI
            ViewStudentInformation_Load(this, null);

        }
    }
}
