using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_test
{
    public partial class formAssignMaintenance : Form
    {
        private readonly Manager _manager;
        public formAssignMaintenance(Manager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void LoadLookups()
        {
            // Facilities
            var fdt = _manager.GetFacilities();       // must return FacilityID, Name
            lstFacility.DisplayMember = "Name";
            lstFacility.ValueMember = "FacilityID";
            lstFacility.DataSource = fdt;

            // Staff
            var sdt = _manager.GetMaintenanceStaff(); // must return MaintenanceID, FullName
            lstMaintenanceStaff.DisplayMember = "FullName";
            lstMaintenanceStaff.ValueMember = "MaintenanceID";
            lstMaintenanceStaff.DataSource = sdt;

            DTPStartDate.Value = DateTime.Today;
        }
        private void LoadSchedules()
        {
            var dt = _manager.GetMaintenanceSchedules();

            dataGridView1.AutoGenerateColumns = false;

            clnScehduleID.DataPropertyName = "ScheduleID";
            clnAssignedFacility.DataPropertyName = "FacilityID";
            clnAssignedStaff.DataPropertyName = "MaintenanceID";
            clnStartDate.DataPropertyName = "StartDate";
            clnEndDate.DataPropertyName = "EndDate";
            clnTask.DataPropertyName = "Task";
            clnCreatedBy.DataPropertyName = "CreatedBy";

            dataGridView1.DataSource = dt;
        }

        // 🔥 Add this method — Designer is expecting it
        private void formAssignMaintenance_Load(object sender, EventArgs e)
        {
            LoadSchedules();
            LoadLookups();
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                // Try SelectedValue first; if null, use Text
                string facilityId = (lstFacility.SelectedValue as string) ?? lstFacility.Text?.Trim();
                string staffId = (lstMaintenanceStaff.SelectedValue as string) ?? lstMaintenanceStaff.Text?.Trim();

                if (string.IsNullOrWhiteSpace(facilityId))
                {
                    MessageBox.Show("Please choose a Facility.", "Missing data",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(staffId))
                {
                    MessageBox.Show("Please choose a Maintenance Staff.", "Missing data",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime startDate = DTPStartDate.Value.Date;
                DateTime? endDate = (numericUpDown2.Value > 0)
                    ? startDate.AddDays((int)numericUpDown2.Value)
                    : (DateTime?)null;

                string task = txtTask.Text.Trim();
                if (string.IsNullOrWhiteSpace(task)) task = "(no task)";

                // Use the real logged-in manager id if you have it
                string createdBy = _manager?.ManagerId ?? "MA01";

                int rows = _manager.AddSchedule(facilityId, staffId, startDate, endDate, task, createdBy);

                if (rows > 0)
                {
                    MessageBox.Show("Schedule added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSchedules(); // refresh grid
                }
                else
                {
                    MessageBox.Show("Nothing was inserted.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblFacility_Click(object sender, EventArgs e)
        {

        }

        private void lstFacility_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstMaintenanceStaff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTask_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
