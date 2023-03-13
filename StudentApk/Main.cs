using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApk
{
    public partial class Main : Form
    {
        public string user_active;
        public Main(string user_active)
        {
            InitializeComponent();
            this.user_active = user_active;
            this.Text = "Doctor Appointement - @" +user_active;
            textAciveUserName.Text = "@" + user_active;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
