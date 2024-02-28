using attendence_system.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace attendence_system.Admin.userControl
{
    public partial class UserControlDashboard : UserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();
            labelTotalStudents.Text = "3";
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
         /*   List<SystemUser> students = UserControlAddStudent.GetUsers();
            labelTotalStudents.Text =students.Count().ToString() ;
         */
        }
    }
}
