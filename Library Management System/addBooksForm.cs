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
    public partial class addBooksForm : Form
    {
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();

        public addBooksForm()
        {
            InitializeComponent();
        }

        private void addBooksForm_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\afnan\\source\\repos\\Library Management System\\Library.mdf\";Integrated Security=True;Connect Timeout=30";
            conn.Open();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            string addBQuery = "INSERT INTO dbo.[Books] (bookName, bookAuthor, bookPublication, bookPublicationDate, bookPrice, bookQuantity)" + "VALUES (@bName, @bAuthor, @bPub, @bPDate, @bPrice, @bQuan);";

            try
            {
                if(textBoxName.Text != "" && textBoxAuthor.Text != "" && textBoxPublic.Text !="" && textBoxPrice.Text !="" && textBoxQuantity.Text != "")
                {
                    using (SqlCommand cmd = new SqlCommand(addBQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@bName", textBoxName.Text);
                        cmd.Parameters.AddWithValue("@bAuthor", textBoxAuthor.Text);
                        cmd.Parameters.AddWithValue("@bPub", textBoxPublic.Text);
                        cmd.Parameters.AddWithValue("@bPDate", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@bPrice", textBoxPrice.Text);
                        cmd.Parameters.AddWithValue("@bQuan", textBoxQuantity.Text);


                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Fail to add book. Please try again.");
                        }
                        textBoxName.Clear();
                        textBoxAuthor.Clear();
                        textBoxPublic.Clear();
                        textBoxPrice.Clear();
                        textBoxQuantity.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Fill the empty box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxAuthor.Clear();
            textBoxPublic.Clear();
            textBoxPrice.Clear();
            textBoxQuantity.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
