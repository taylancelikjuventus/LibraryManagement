using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
        }
        /*******************If Exit clicked close application********************/
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(this, "Dou you want to close Application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /*****************IF Add Student menuitem Clicked****************/
        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudents astu = new AddStudents();
            astu.Show();
        }

        /**************IF Add New Book menuitem clicked****************/
        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooks ab = new AddBooks();
            ab.Show();
        }
        /**************IF View Books menuitem clicked****************/
        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook vb = new ViewBook();
            vb.Show();
        }
        /************IF ViewStudentInfo tab  clicked*******************/
        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentInformation vsi = new ViewStudentInformation();
            vsi.Show();
        }

        /************IF Issue Book tab  clicked*******************/
        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBooks ibooks = new IssueBooks();
            ibooks.Show();
        }
        /************IF Return Book tab  clicked*******************/
        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook rb = new ReturnBook();
            rb.Show();
        }
        /************IF Complete Book Details  clicked*******************/
        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompleteBookDetails cbd = new CompleteBookDetails();
            cbd.Show();
        }
    }
}
