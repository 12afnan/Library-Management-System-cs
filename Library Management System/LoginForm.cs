using Library_Management_System.LibraryDataSetTableAdapters;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();

        private void LoginForm_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\afnan\\source\\repos\\Library Management System\\Library.mdf\";Integrated Security=True;Connect Timeout=30";
            conn.Open();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Clear();
            }
        }

        private void textPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Clear();
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
           string logQuery = "SELECT * FROM dbo.[User] WHERE userName = @userName AND userPass = @userPass";

            try
            {
                if (string.IsNullOrEmpty(textBoxUsername.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
                {
                    MessageBox.Show("Please enter username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (textBoxUsername.Text == "admin" || textBoxPassword.Text == "admin")
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                            MessageBox.Show("Admin Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Dashboard dashboard = new Dashboard();
                            dashboard.Show();
                            this.Hide();
                    }
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand(logQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@userName", textBoxUsername.Text);
                        cmd.Parameters.AddWithValue("@userPass", textBoxPassword.Text);

                        var check = cmd.ExecuteReader();

                        if (check.Read())
                        {
                            MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DashboardUser dashboardUser = new DashboardUser();
                            dashboardUser.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        check.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string checkQuery = "SELECT * FROM dbo.[User] WHERE userName = @userName";

            string regQuery = "INSERT INTO dbo.[User] (userName, userPass)" + "VALUES (@userName, @userPass);";

            try
            {
                bool userExists = false;

                using (SqlCommand checkCmd = new SqlCommand(checkQuery,conn))
                {
                    checkCmd.Parameters.AddWithValue("@userName", textBoxUsername.Text);

                    using (var check = checkCmd.ExecuteReader()) 
                    {
                        if (userExists = check.HasRows) MessageBox.Show("Username Already Exist");
                    }
                }
                
                if (!userExists)
                {
                    using (SqlCommand cmd = new SqlCommand(regQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@userName", textBoxUsername.Text);
                        cmd.Parameters.AddWithValue("@userPass", textBoxPassword.Text);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}