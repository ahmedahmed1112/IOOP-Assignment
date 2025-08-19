using System;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Configuration;


namespace assignment_test
{
    public partial class formLogIn : Form
    {
   


        public formLogIn()
        {
             

            InitializeComponent();
        }


        private void lblSelectRole_Click(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnklblForgot_pass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();

        }

        private void formLogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both Email and Password.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cs = @"Data Source=LAPTOP-7LLUAD3U;Initial Catalog=BBBBADR;Integrated Security=True";

            using (var conn = new SqlConnection(cs))
            {
                try
                {
                    conn.Open();

                    string sql = @"SELECT TOP 1 [ManagerID]
                           FROM [Manager]
                           WHERE [Email] = @Email AND [Password] = @Password";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        object result = cmd.ExecuteScalar();

                        if (result == null || result == DBNull.Value)
                        {
                            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        
                        string managerId = result.ToString();

                        
                        var manager = new Manager { ManagerId = managerId };

                        
                        var hub = new formManageUserAccs(manager);
                        hub.FormClosed += (s, args) => this.Show();  
                        this.Hide();
                        hub.Show();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while connecting to the database: " + ex.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txtEmail_TextChanged(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
        private void Form1_load(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}