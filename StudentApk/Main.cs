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
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm !=null){
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panChild.Controls.Add(childForm);
            panChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDoctors);
        }

        private void btnActiveDoctors_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnDoctors2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnDoctors4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPatients);
        }

        private void btnPatients1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnPatients2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnPatients3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnPatients4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSettings);
        }

        private void btnSettings1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSettings2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSettings2_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }
    }
}
