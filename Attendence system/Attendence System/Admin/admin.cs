using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using attendence_system;
using attendence_system.Admin.userControl;


namespace AttendanceManagmentProject.Admin
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            timerDateAndTime.Start();
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


        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            panelExpand.Hide();
            WindowState = FormWindowState.Minimized;

        }


        //
        private void MoveSidePanel(Control panel)
        {
            panelSide.Location = new Point(panelSide.Location.X, panel.Location.Y + 5);
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            //UserControlDashboard.labelTotalStudents.Text= UserControlAddStudent.gitCountStudent().ToString();

            userControlDashboard1.Visible = true;
            userControlAddClass1.Visible = false;
            userControlAddTeacher1.Visible = false;
            userControlAddStudent1.Visible = false;

            MoveSidePanel(PanelDashboard);


        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            userControlDashboard1.Visible = false;
            userControlAddClass1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlAddTeacher1.Visible = false;

            MoveSidePanel(panelAttendance);



        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            userControlAddClass1.Visible = true;
            userControlAddStudent1.Visible = false;
            userControlAddTeacher1.Visible = false;
            userControlDashboard1.Visible = false;
            MoveSidePanel(panelAddClass);

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


        private void butnAddTeacher_Click(object sender, EventArgs e)
        {
            userControlAddTeacher1.Visible = true;
            userControlAddStudent1.Visible = false;
            userControlAddClass1.Visible = false;
            userControlDashboard1.Visible = false;
            MoveSidePanel(panelAddTeacher);


        }


        private void buttonAddStudent_Click(object sender, EventArgs e)
        {

            userControlAddClass1.Visible = false;
            userControlDashboard1.Visible = false;
            userControlAddTeacher1.Visible = false;
            userControlAddStudent1.Visible = true;
            MoveSidePanel(panelAddstudent);

        }

        private void userControlAddTeacher1_Load(object sender, EventArgs e)
        {

        }

        private void parentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
