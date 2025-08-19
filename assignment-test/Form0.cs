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
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            {
                var next = new formLogIn();
                next.FormClosed += (s, args) => this.Show();
                next.Show();
                this.Hide();

            }
        }

        private void btnReception_Click(object sender, EventArgs e)
        {
            {
                var next = new formLogIn();
                next.FormClosed += (s, args) => this.Show();
                next.Show();
                this.Hide();

            }

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            {
                var next = new formLogIn();
                next.FormClosed += (s, args) => this.Show();
                next.Show();
                this.Hide();

            }
        }

        private void btnMaintenanceStaff_Click(object sender, EventArgs e)
        {
            {
                var next = new formLogIn();
                next.FormClosed += (s, args) => this.Show();
                next.Show();
                this.Hide();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form0_Load(object sender, EventArgs e)
        {

        }
    }
}

