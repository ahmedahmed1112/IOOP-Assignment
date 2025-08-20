using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace assignment_test
{
    public partial class Form8 : Form
    {
        private readonly Manager _mgr = new Manager();
        public Form8()
        {
            InitializeComponent();
            

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            LoadRequests();
        }
        private void LoadRequests()
        {
            try
            {
                string statusFilter = txtSearchReqID.Text.Trim(); // Status:
                string idLike = lstStatus.Text.Trim(); // Search RequestID:

                DGV_ReviewRequests.DataSource = _mgr.Requests_List(statusFilter, idLike);

                DGV_ReviewRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DGV_ReviewRequests.ReadOnly = true;
                DGV_ReviewRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DGV_ReviewRequests.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load requests:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchRequestID_Click(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DGV_ReviewRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchReqID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
