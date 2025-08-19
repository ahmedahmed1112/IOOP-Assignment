using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_test
{
    public partial class formManageUsers : Form
    {
        private readonly Manager _manager;
        private readonly string _connStr =
    System.Configuration.ConfigurationManager.ConnectionStrings["AssignmentDB"].ConnectionString;


        public formManageUsers(Manager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadUsers();
        }

        private void btnTestLoad_Click(object sender, EventArgs e)
        {
            LoadUsers();
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
            using (var next = new formAddUser(_manager, "reception"))  // or "maintenance"
            {
                next.ShowDialog();
            }
           

               

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (DGV_Users.SelectedRows.Count > 0)
            {
                var selectedRow = DGV_Users.SelectedRows[0];
                int userId = Convert.ToInt32(selectedRow.Cells["user_id"].Value); // <-- fix here
                var next = new formEditUser(userId);
                next.ShowDialog();
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Please select a user to edit.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (DGV_Users.CurrentRow == null)
            {
                MessageBox.Show("Select a user row first.");
                return;
            }

            var cell = DGV_Users.CurrentRow.Cells["user_id"].Value;
            if (cell == null || cell == DBNull.Value)
            {
                MessageBox.Show("Could not read user_id from selection.");
                return;
            }

            int id = Convert.ToInt32(cell);

            // confirm
            if (MessageBox.Show($"Delete user #{id}?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                _manager.ManageStaffAccount(operation: "delete", userId: id);
                MessageBox.Show("User deleted.");
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string term = (txtSearch.Text ?? "").Trim().ToLower();

            foreach (DataGridViewRow row in DGV_Users.Rows)
            {
                if (row.IsNewRow) continue;

                string name = row.Cells["full_name"].Value?.ToString().ToLower() ?? "";
                string email = row.Cells["email"].Value?.ToString().ToLower() ?? "";

                // show only matching rows
                row.Visible = term == "" || name.Contains(term) || email.Contains(term);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void LoadUsers(string roleFilter = null, string search = null)
        {
            using (var conn = new SqlConnection(_connStr))
            using (var da = new SqlDataAdapter(@"
SELECT u.user_id,
       u.full_name,
       u.email,
       u.phone_number,
       u.user_role
FROM (
    SELECT
        ReceptionID                          AS user_id,
        (FirstName + ' ' + LastName)         AS full_name,
        ISNULL(Email,'')                     AS email,
        ISNULL(Phone,'')                     AS phone_number,
        'reception'                          AS user_role
    FROM Reception

    UNION ALL

    SELECT
        MaintenanceID                        AS user_id,
        (FirstName + ' ' + LastName)         AS full_name,
        ISNULL(Email,'')                     AS email,
        ISNULL(Phone,'')                     AS phone_number,
        'maintenance'                        AS user_role
    FROM MaintenanceStaff
) u
WHERE (@role IS NULL OR u.user_role = @role)
  AND (@q IS NULL OR @q = '' OR
       u.user_id     LIKE '%'+@q+'%' OR
       u.full_name   LIKE '%'+@q+'%' OR
       u.email       LIKE '%'+@q+'%' OR
       u.phone_number LIKE '%'+@q+'%')
ORDER BY u.user_id DESC;", conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@role", (object)roleFilter ?? DBNull.Value);
                da.SelectCommand.Parameters.AddWithValue("@q", (object)search ?? DBNull.Value);

                var dt = new DataTable();
                da.Fill(dt);
                DGV_Users.DataSource = dt;
            }

            // optional: set headers once
            if (DGV_Users.Columns.Contains("full_name"))
                DGV_Users.Columns["full_name"].HeaderText = "Name";
            if (DGV_Users.Columns.Contains("phone_number"))
                DGV_Users.Columns["phone_number"].HeaderText = "Phone";
        }

        private void pnlSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblFilterRole_Click(object sender, EventArgs e)
        {

        }
    }
}
