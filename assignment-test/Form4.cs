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
using System.Configuration;

namespace assignment_test
{
    public partial class formAddUser : Form
    {
        private readonly Manager _manager;
        private readonly string _role;
        public formAddUser(Manager manager, string role)
        {
            InitializeComponent();
            _manager = manager;
            _role = string.IsNullOrWhiteSpace(role) ? "reception" : role.ToLower();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                var first = (txtFirstName.Text ?? "").Trim();
                var last = (txtLastName.Text ?? "").Trim();
                var phone = string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ? null : txtPhoneNumber.Text.Trim();
                var pass = (txtPassword.Text ?? "").Trim();
                var pass2 = (txtConfirmPassword.Text ?? "").Trim();

                if (first.Length == 0 || last.Length == 0)
                {
                    MessageBox.Show("First and last name are required.", "Missing info",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (pass.Length == 0)
                {
                    MessageBox.Show("Password is required.", "Missing info",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!string.Equals(pass, pass2, StringComparison.Ordinal))
                {
                    MessageBox.Show("Password confirmation does not match.", "Check password",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Build full name
                var fullName = $"{first} {last}".Trim();

                // Explicitly specify null for the optional userId parameter to resolve ambiguity
                var newId = _manager.ManageStaffAccount(
                    operation: "add",
                    userId: (int?)null, // Explicitly cast to nullable int
                    fullName: fullName,
                    email: null,             // you don't collect email on this form
                    password: pass,
                    phoneNumber: phone,      // may be null
                    role: _role              // "reception" or "maintenance"
                );

                MessageBox.Show("User added successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tell the parent to refresh
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add user: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputs()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtFirstName.Focus();
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formAddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
