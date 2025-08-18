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
    public partial class formManageUsers : Form
    {
        public formManageUsers()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadUsers();
        }

        private void btnTestLoad_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }


        private void LoadUsers(string Keyword ="")
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Asia\\source\\repos\\ahmedahmed1112\\IOOP-Assignment\\assignment-test\\Assignment.mdf;Integrated Security=True";
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();
                    //MessageBox.Show("Connection succeeded");

                    string query = "SELECT * FROM Manager";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dataTable;

                    foreach (DataColumn col in dataTable.Columns)
                    {
                    }

                    if (!string.IsNullOrWhiteSpace(Keyword))
                    {
                        query += " WHERE ManagerId LIKE @Keyword OR Name LIKE @Keyword OR Email LIKE @Keyword";
                    }

                    if(string.IsNullOrWhiteSpace(Keyword))
                    {
                        Keyword = "%";
                    }
                    else
                    {
                        Keyword = "%" + Keyword + "%";
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void formManageUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var next = new formAddUser();
            next.ShowDialog();

            LoadUsers();    

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int userId = Convert.ToInt32(selectedRow.Cells["UserId"].Value);
                var next = new formEditUser(userId);
                next.ShowDialog();
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Please select a user to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
                {
                var selectedRow = dataGridView1.SelectedRows[0];
                int userId = Convert.ToInt32(selectedRow.Cells["UserId"].Value);
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Ahmad\\source\\repos\\IOOP-Assignment\\assignment-test\\Assignment.mdf;Integrated Security=True";
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    try
                    {
                        connect.Open();
                        string query = "DELETE FROM Manager WHERE UserId = @UserId";
                        SqlCommand command = new SqlCommand(query, connect);
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.ExecuteNonQuery();
                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text.Trim().ToLower();

            dataGridView1.ClearSelection();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string name =row.Cells["Name"].Value.ToString().ToLower();
                    string email = row.Cells["Email"].Value.ToString().ToLower();

                    if ((string.IsNullOrEmpty(name) && string.IsNullOrEmpty(email)) || 
                        name.Contains(searchKeyword) || 
                        email.Contains(searchKeyword))
                    {
                        row.Selected = true;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            LoadUsers(keyword); 
        }
    }
}
