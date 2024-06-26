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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void buttonExitt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\afnan\\source\\repos\\Library Management System\\Library.mdf\";Integrated Security=True;Connect Timeout=30";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM IRbook where std_enrollno = '" +txtBoxEnterEnroll.Text+"' and book_return_date IS NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(ds.Tables[0].Rows.Count != 0 )
            {
                dataGridViewReturnBook.DataSource=ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID or No Book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            panelBawahReturn.Visible = false;   
            txtBoxEnterEnroll.Clear();
        }
        String bname;
        String bdate;
        Int64 rowid;
        private void dataGridViewReturnBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelBawahReturn.Visible=true;

            if(dataGridViewReturnBook.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null )
            {
                rowid = Int64.Parse(dataGridViewReturnBook.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridViewReturnBook.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = dataGridViewReturnBook.Rows[e.RowIndex].Cells[8].Value.ToString();

            }

            txtBookName.Text = bname;
            txtBookIssueDate.Text = bdate;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\afnan\\source\\repos\\Library Management System\\Library.mdf\";Integrated Security=True;Connect Timeout=30";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "update IRbook set book_return_date = '" + dateTimePickerReturn.Text + "' where std_enrollno = '" + txtBoxEnterEnroll.Text + "' and id = " + rowid + "";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Return Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReturnBook_Load(this, null);
        }

        private void txtBoxEnterEnroll_TextChanged(object sender, EventArgs e)
        {
            if(txtBoxEnterEnroll.Text=="")
            {
                panelBawahReturn.Visible = false;
                dataGridViewReturnBook.DataSource = null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBoxEnterEnroll.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelBawahReturn.Visible = false;
        }

        private void labelEnterEnroll_Click(object sender, EventArgs e)
        {

        }
    }
}
