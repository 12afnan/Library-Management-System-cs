using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection();

        SqlCommand cmd = new SqlCommand();

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\afnan\\source\\repos\\Library Management System\\Library.mdf\";Integrated Security=True;Connect Timeout=30";
            cmd.Connection = conn;
            conn.Open();

            cmd = new SqlCommand("SELECT bookName FROM Books", conn);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for(int i = 0; i < sdr.FieldCount; i++)
                {
                    comboBoxbooks.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        int count;
        private void btnSeacrh_Click(object sender, EventArgs e)
        {
            if(txtEnrollment.Text != "")
            {
                String eid = txtEnrollment.Text;

                cmd.CommandText = "SELECT * FROM Student WHERE matricno = '" + eid+"'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                //-----------------------------------------------------------------------------------------
                //code to count how many book has been issued on this enrollment number
                cmd.CommandText = "SELECT count(std_enrollno) FROM IRbook WHERE std_enrollno = '" + eid + "' and book_return_date is null";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da.Fill(ds1);

                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                //------------------------------------------------------------------------------------------

                if (ds.Tables[0].Rows.Count !=0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtDepartment.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtSemester.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    txtName.Clear();
                    txtDepartment.Clear();
                    txtSemester.Clear();
                    txtContact.Clear();
                    txtEmail.Clear();
                    MessageBox.Show("Invalid Matric Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if(txtName.Text !="")
            {
                if(comboBoxbooks.SelectedIndex != -1 && count <= 2)
                {
                    String enroll = txtEnrollment.Text;
                    String sname = txtName.Text;
                    String sdep = txtDepartment.Text;
                    String sem = txtSemester.Text;
                    Int64 contact = Int64.Parse(txtContact.Text);
                    String email = txtEmail.Text;
                    String bookname = comboBoxbooks.Text;
                    String bookIssueDate = dateTimePicker.Text;


                    String eid = txtEnrollment.Text;

                    cmd.CommandText = "INSERT INTO IRbook (std_enrollno,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date) VALUES ('" + enroll + "' ,'" + sname +" ' , ' " + sdep + "' ,' " + sem + "',  " + contact + ", ' " + email + "', ' " + bookname + "', ' " + bookIssueDate + "')";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Book Issued.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Select book or maximum number of books has been ISSUED", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Please enter valid enrollment number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEnrollment_TextChanged(object sender, EventArgs e)
        {
            if(txtEnrollment.Text == "")
            {
                txtName.Clear();
                txtEmail.Clear();
                txtSemester.Clear();
                txtContact.Clear();
                txtEmail.Clear(); 
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnrollment.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure?","Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
            
        }
    }
}
