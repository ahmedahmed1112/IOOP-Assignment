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

        private void button1_Click(object sender, EventArgs e)
        {
            {
                var next = new formLogIn();
                next.FormClosed += (s, args) => this.Show();
                next.Show();
                this.Hide();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                var next = new formLogIn();
                next.FormClosed += (s, args) => this.Show();
                next.Show();
                this.Hide();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                var next = new formLogIn();
                next.FormClosed += (s, args) => this.Show();
                next.Show();
                this.Hide();

            }
        }

        private void button4_Click(object sender, EventArgs e)
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
    }
}

