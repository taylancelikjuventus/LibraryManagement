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
    public partial class AddStudents : Form
    {
        public AddStudents()
        {
            InitializeComponent();
        }

        /*********If close clicked***************/
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to close this window?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
            {
                this.Close();
            }


        }
        /*************IF clear clicked**************************/
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentname.Clear();
            txtSemester.Clear();
            txtEnrollNo.Clear();
            txtEmail.Clear();
            txtDepartment.Clear();
            txtContact.Clear();
        }

        /**************If Save clicked***********/
        private void btnSave_Click(object sender, EventArgs e)
        {

            //simple validation
            if (
                txtStudentname.Text !="" &&
                txtSemester.Text !="" &&
                txtEnrollNo.Text !="" &&
                txtEmail.Text !="" &&       /*we didn't validate email*/
                txtDepartment.Text !="" &&
                txtContact.Text !=""   
                )
            {


                string sname = txtStudentname.Text;
                string semes = txtSemester.Text;
                string enrollNo = txtEnrollNo.Text;
                string email = txtEmail.Text;
                string department = txtDepartment.Text;
                Int64 contatcNo = Int64.Parse(txtContact.Text);


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

                cmd.CommandText = "insert into NewStudent(sname,enroll,dep,sem,contact,email) values('" + sname + "','" + enrollNo + "','" + department + "','" + semes + "','" + contatcNo + "','" + email+ "')";
                cmd.ExecuteNonQuery();

                //close connection
                conn.Close();

                //inform user
                MessageBox.Show(this, "Student inserted...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(this, "Please fill all fields in form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
