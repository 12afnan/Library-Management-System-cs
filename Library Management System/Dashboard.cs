using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Dashboard : Form
    {
        
        public Dashboard()
        {
            InitializeComponent();
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addBooksForm addBooksDel = new addBooksForm(); //create object for addBooks class
            addBooksDel.MdiParent = this; //set Dashboard as parent window (MDI parent)
            addBooksDel.Dock = DockStyle.Fill; //set MDI parent to auto-size the child window
            addBooksDel.Show(); // call show method to display the child window (addBooks form)
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;        
        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook viewBookDel = new ViewBook();
            viewBookDel.MdiParent = this;
            viewBookDel.Dock = DockStyle.Fill;
            viewBookDel.Show();
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentInformation viewStudentInfoDel = new ViewStudentInformation();
            viewStudentInfoDel.MdiParent = this;
            viewStudentInfoDel.Dock = DockStyle.Fill;
            viewStudentInfoDel.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addStudentDel = new AddStudent();
            addStudentDel.MdiParent = this;
            addStudentDel.Dock = DockStyle.Fill;
            addStudentDel.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBooks issueBooksDel = new IssueBooks();
            issueBooksDel.MdiParent = this;
            issueBooksDel.Dock = DockStyle.Fill;
            issueBooksDel.Show();
        }

        private void completeBookDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompleteBookDetails completeBookDetailsDel = new CompleteBookDetails();
            completeBookDetailsDel.MdiParent = this;
            completeBookDetailsDel.Dock = DockStyle.Fill;
            completeBookDetailsDel.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook returnBookDel = new ReturnBook();
            returnBookDel.MdiParent = this;
            returnBookDel.Dock = DockStyle.Fill;
            returnBookDel.Show();
        }
    }
}
