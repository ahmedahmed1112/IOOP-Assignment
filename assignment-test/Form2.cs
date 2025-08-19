using System;
using System.Windows.Forms;

namespace assignment_test
{
    public partial class formManageUserAccs : Form
    {
        private readonly Manager _manager;

        // runtime ctor (called after login)
        public formManageUserAccs(Manager manager) : this()
        {
            _manager = manager;
            this.Text = _manager != null ? $"Manager Tasks — {_manager.ManagerId}" : "Manager Tasks";
        }

        // designer-friendly ctor (required by the Designer)
        public formManageUserAccs()
        {
            InitializeComponent();
            this.Text = "Manager Tasks";
        }

        // ============= NAVIGATION =============

        // Manage User Accounts
        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            // requires formManageUsers to have: public formManageUsers(Manager m) : this() { ... }
            var f = new formManageUsers(_manager);
            f.FormClosed += (s, args) => this.Show();
            this.Hide();
            f.Show();
        }

        // Manage Facilities
        private void btnManageFacilities_Click(object sender, EventArgs e)
        {
            // If your facilities form class is named Form6 (as in your solution), use Form6.
            // If it's named formFacilitiesManager, change the next line to: new formFacilitiesManager();
            var f = new formrFacilitiesManager();
            f.FormClosed += (s, args) => this.Show();
            this.Hide();
            f.Show();
        }

        // Assign Maintenance
        private void btnAssignMaintance_Click(object sender, EventArgs e)
        {
            var f = new Form7(_manager);  
            f.FormClosed += (s, args) => this.Show();
            this.Hide();
            f.Show();
        }

        // Review & approve maintenance requests
        private void btnReviewRequest_Click(object sender, EventArgs e)
        {
            var f = new Form8();
            f.FormClosed += (s, args) => this.Show();
            this.Hide();
            f.Show();
        }

        // Go Back (return to login)
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ============= BRIDGE METHODS (keep if Designer is wired to them) =============

        private void formManageUserAccs_Load(object sender, EventArgs e)
        {
            // optional init
        }

        // Designer may still point a button to this old name; forward it.
        private void btnReviewRequest_click(object sender, EventArgs e)
        {
            btnAssignMaintance_Click(sender, e);
            // or: btnReviewRequest_Click(sender, e);
        }
    }
}
