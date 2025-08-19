using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_test
{
    public partial class formrFacilitiesManager : Form
    {
        private readonly Manager _mgr = new Manager();
        public formrFacilitiesManager()
        {
            InitializeComponent();
        }

        private void formrFacilitiesManager_Load(object sender, EventArgs e)
        {
            LoadFacilities();
        }
        private void LoadFacilities(string q = null)
        {
            try
            {
                DGV_Facility.DataSource = _mgr.Facility_List(q);
                DGV_Facility.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DGV_Facility.ReadOnly = true;
                DGV_Facility.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DGV_Facility.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load facilities:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DGV_Facility.CurrentRow == null)
            {
                MessageBox.Show("Please select a facility to delete.");
                return;
            }

            var id = DGV_Facility.CurrentRow.Cells["FacilityID"]?.Value?.ToString();
            if (string.IsNullOrWhiteSpace(id)) return;

            var confirm = MessageBox.Show($"Delete facility '{id}'?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                _mgr.Facility_Delete(id);
                LoadFacilities();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var add = new formAddFacility())   // opens the Add Facility form
            {
                if (add.ShowDialog(this) == DialogResult.OK)
                {
                    // child tells us it saved successfully
                    LoadFacilities();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void DGV_Facility_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
