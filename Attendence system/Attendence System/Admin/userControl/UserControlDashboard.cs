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

namespace attendence_system.Admin.userControl
{
    public partial class UserControlDashboard : UserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();
            labelTotalStudents.Text = "3";
            adminRole.Text = "Admin";
        }



        private void UserControlDashboard1_Load(object sender, EventArgs e)
        {
            labelTotalStudents.Text = InstructorDataManipulator.GetCountStudents().ToString();

        }
    }
}
