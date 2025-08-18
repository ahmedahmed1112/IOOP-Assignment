using System;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace assignment_test
{
    public partial class Form1 : Form
    {
   


        public Form1()
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

        private void FormRoleSelect_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both Email and Password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Asia\\source\\repos\\ahmedahmed1112\\IOOP-Assignment\\assignment-test\\Assignment.mdf;Integrated Security=True";
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();
                    string query = "SELECT COUNT(*) FROM Manager WHERE email  = @email  AND Password = @Password";
                    SqlCommand conn = new SqlCommand(query, connect);

                    conn.Parameters.AddWithValue("@email", email);
                    conn.Parameters.AddWithValue("@Password", password);

                    int count = (int)conn.ExecuteScalar();

                    if (count > 0)
                    {
                       // MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Proceed to the next form or functionality
                        var next = new formManageUsers();
                        next.FormClosed += (s, args) => this.Show();
                        next.FormClosed += (s, args) => this.Show();
                        next.Show();
                        this.Hide();
                    }
                    else
                    {
                        // User does not exist, show error message
                        MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
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