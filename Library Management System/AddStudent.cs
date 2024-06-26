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

namespace Library_Management_System
{
    public partial class AddStudent : Form
    {

        public AddStudent()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection();

        private void AddStudent_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\afnan\\source\\repos\\Library Management System\\Library.mdf\";Integrated Security=True";
            conn.Open();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm?","Alert",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxSName.Clear();
            textBoxEnroll.Clear();
            textBoxDepartment.Clear();
            textBoxSSemester.Clear();
            textBoxSContact.Clear();
            textBoxSEmail.Clear();
        }

        SqlCommand cmd = new SqlCommand();

        private void buttonSaveInfo_Click(object sender, EventArgs e)
        {
            if(textBoxSName.Text != "" && textBoxEnroll.Text != "" && textBoxDepartment.Text != "" && textBoxSSemester.Text != "" && textBoxSContact.Text != "" && textBoxSEmail.Text != "")
            {
                String name = textBoxSName.Text;
                String enroll = textBoxEnroll.Text;
                String department = textBoxDepartment.Text;
                String semester = textBoxSSemester.Text;
                Int64 contact = Int64.Parse(textBoxSContact.Text);
                String email = textBoxSEmail.Text;

                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Student (sname,enrollno,dep,sem,contact,email) VALUES ('" + name + "','" + enroll + "','" + department + "','" + semester + "'," + contact + ",'" + email + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Added!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Please Fill in Empty Box", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
