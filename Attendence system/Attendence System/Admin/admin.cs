using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceManagmentProject.Admin
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            timerDateAndTime.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {
            panelExpand.Hide();
            LabelUserName.Text = "Habiba";
            labelRole.Text = "Admin";
            //if role user hide btns 


        }

        private void buttonLogOut_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are U want to log Out ?", "Log Out ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                Close();
            }
            else
            {
                panelExpand.Hide();

            }

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            panelExpand.Hide();
            WindowState = FormWindowState.Minimized;

        }


        //
        private void MoveSidePanel(Control button)
        {
            panelSide.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 180);
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {

        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            if (panelExpand.Visible)
            {
                panelExpand.Visible = false;
            }
            else
            {
                panelExpand.Visible = true;

            }
        }

        private void timerDateAndTime_Tick_1(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("F");
        }

        private void userControlDashboard1_Load(object sender, EventArgs e)
        {

        }

        private void panelBack_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
