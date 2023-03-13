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
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelDoctors.Visible = false;
            panelPatients.Visible = false;
            panelSettings.Visible = false;
        }
        private void hideSubMenu()
        {
            if(panelDoctors.Visible == true)
            {
                panelDoctors.Visible = false;
            }
            if (panelPatients.Visible == true)
            {
                panelPatients.Visible = false;
            }
            if (panelSettings.Visible == true)
            {
                panelSettings.Visible = false;
            }
        }
        private void showSubMenu(Panel panel)
        {
            if(panel.Visible == false)
            {
                hideSubMenu();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
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
