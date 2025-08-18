using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace assignment_test
{
    public partial class formAddUser : Form
    {
        public formAddUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string UniqID = Guid.NewGuid().ToString();

            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Ahmad\\source\\repos\\IOOP-Assignment\\assignment-test\\Assignment.mdf;Integrated Security=True";

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();

                    // Check if the user already exists
                    string checkQuery = "SELECT COUNT(*) FROM Manager WHERE FirstName = @FirstName AND LastName = @LastName";
                    string query = "INSERT INTO Manager (ManagerID, FirstName, LastName, PhoneNumber, Password, Role) " +
                                   "VALUES (@Manager, @FirstName, @LastName, @PhoneNumber, @Password, 'Manager')";
                    SqlCommand command = new SqlCommand(query, connect);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Manager", UniqID);


                    int count = (int)command.ExecuteNonQuery();
                    if (count > 0)
                    {
                        // User added successfully
                    }
                    else
                    {
                        MessageBox.Show("User already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string insertQuery = "INSERT INTO Manager (FirstName, LastName, PhoneNumber, Password) VALUES (@FirstName, @LastName, @PhoneNumber, @Password)";

                    SqlCommand insertCommand = new SqlCommand(insertQuery, connect);
                    insertCommand.Parameters.AddWithValue("@FirstName", firstName);
                    insertCommand.Parameters.AddWithValue("@LastName", lastName);
                    insertCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    insertCommand.Parameters.AddWithValue("@Password", password);
                    insertCommand.Parameters.AddWithValue("@ConfirmPassword", confirmPassword);
                    insertCommand.ExecuteNonQuery();

                    int rows = insertCommand.ExecuteNonQuery();

                    if (rows > 0)
                    {


                        MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Close the form after successful addition
                    }
                    else
                    {
                        MessageBox.Show("Failed to add user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Error adding user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }   





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
