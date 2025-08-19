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
    public partial class Form7 : Form
    {
        private readonly Manager _manager;
        public Form7(Manager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void LoadLookups()
        {
            // Facilities
            var fdt = _manager.GetFacilities();       // must return FacilityID, Name
            lstRoles.DisplayMember = "Name";
            lstRoles.ValueMember = "FacilityID";
            lstRoles.DataSource = fdt;

            // Staff
            var sdt = _manager.GetMaintenanceStaff(); // must return MaintenanceID, FullName
            listBox1.DisplayMember = "FullName";
            listBox1.ValueMember = "MaintenanceID";
            listBox1.DataSource = sdt;

            dateTimePicker1.Value = DateTime.Today;
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
        private void Form7_Load(object sender, EventArgs e)
        {
            LoadSchedules();
            LoadLookups();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Try SelectedValue first; if null, use Text
                string facilityId = (lstRoles.SelectedValue as string) ?? lstRoles.Text?.Trim();
                string staffId = (listBox1.SelectedValue as string) ?? listBox1.Text?.Trim();

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

                DateTime startDate = dateTimePicker1.Value.Date;
                DateTime? endDate = (numericUpDown2.Value > 0)
                    ? startDate.AddDays((int)numericUpDown2.Value)
                    : (DateTime?)null;

                string task = textBox1.Text.Trim();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
