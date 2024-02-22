using attendence_system.Instructor.userControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace attendence_system.Instructor
{
    public partial class instructor : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AllocConsole();
        public static string UserName, Role;
        public instructor()
        {
            InitializeComponent();
            timerDateAndTime.Start();
        }
        private void Instructor_Load(object sender, EventArgs e)
        {
            labelName.Text = "Ahmad";
            labelRole.Text = "Instructor";
            panelExpand.Hide();
            userControlDashboard.Dock = DockStyle.Fill;
        }

        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            //panelExpand.Visible? panelExpand.Hide(): panelExpand.Show();
            if (panelExpand.Visible)
                panelExpand.Hide();
            else
                panelExpand.Show();

        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            panelExpand.Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelDateTime.Text = now.ToString("F");
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                Close();
            }
            else
                panelExpand.Hide();
        }
        private void MoveSidePanel(Control panel)
        {
            panelSide.Location = new Point(panelSide.Location.X, panel.Location.Y + 5);
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MoveSidePanel(panelDashBoard);
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            MoveSidePanel(panelAttendance);
            //userControlDashboard.Dock = DockStyle.None;
            userControlDashboard.SendToBack();
            setAttendance.Dock = DockStyle.Fill;
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            MoveSidePanel(panelAddStudent);
        }

        private void buttonDashboard_MouseHover(object sender, EventArgs e)
        {
            Control button = sender as Control;
            button.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Control button = sender as Control;
            button.ForeColor = Color.White;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            MoveSidePanel(panelSettings);
        }

        private void userControlDashboard_Load(object sender, EventArgs e)
        {

        }

        private void setAttendance_Load(object sender, EventArgs e)
        {

            

            //AllocConsole();
            //Console.WriteLine($"Debug Message\n {dataSet.Tables[0]}");
            //foreach (DataTable table in dataSet.Tables)
            //{
            //    foreach (DataRow row in table.Rows)
            //    {
            //        foreach (DataColumn column in table.Columns)
            //        {
            //            Console.WriteLine($"{column.ColumnName}: {row[column]}");
            //        }
            //    }
            //}
        }
    }
}
