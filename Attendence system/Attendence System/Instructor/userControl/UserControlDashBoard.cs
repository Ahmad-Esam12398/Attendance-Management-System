using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace attendence_system.Instructor
{
    public partial class UserControlDashBoard : UserControl
    {
        public UserControlDashBoard()
        {
            InitializeComponent();
        }

        private void UserControlDashBoard_Load(object sender, EventArgs e)
        {
            XmlNode userData = InstructorDataManipulator.GetUserNode();
            labelRole.Text = userData.SelectSingleNode("role").InnerText;
            //InstructorDataManipulator
        }
    }
}
