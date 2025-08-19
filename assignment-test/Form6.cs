using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace assignment_test
{
    public partial class formAddFacility : Form
    {
        private readonly Manager _mgr = new Manager();
        public formAddFacility()
        {
            InitializeComponent();
        }

        private void formAddFacility_Load(object sender, EventArgs e)
        {

        }

        private void btnAddFacility_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string uni = txtUniversity.Text.Trim();
            string type = txtType.Text.Trim();
            string loc = txtLocation.Text.Trim();
            string rateText = txtRate.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(uni) ||
                string.IsNullOrWhiteSpace(type) ||
                string.IsNullOrWhiteSpace(loc) ||
                string.IsNullOrWhiteSpace(rateText))
            {
                MessageBox.Show("Please fill all fields.", "Missing Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(rateText, NumberStyles.Number, CultureInfo.InvariantCulture, out var rate))
            {
                MessageBox.Show("Rate Per Hour must be a valid number.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Generate FA001/FA002… or use your own ID field if you have one on the form
                string newId = _mgr.Facility_GenerateNextId();

                _mgr.Facility_Add(newId, name, uni, rate, type, loc);

                MessageBox.Show($"Facility '{newId}' added.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // tell parent to refresh and close
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
