using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace StudentApk
{
    public partial class Loading : Form
    {
        
        public Loading()
        {
            InitializeComponent();
            timer.Start();
            progressBar.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(1);
            if (progressBar.Value == 60)
            {
                this.Hide();
                new Login().Show();
                timer.Enabled = false;
            }
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void picLoading_Click(object sender, EventArgs e)
        {

        }
    }
}
