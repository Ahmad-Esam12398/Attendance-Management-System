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
using attendence_system;
using System.Xml;

namespace attendence_system.Admin.userControl
{
    public partial class UserControlDashboard : UserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();
            labelTotalStudents.Text = "3";
            labelTotalClasses.Text = "4";
            adminRole.Text = "Admin";
        }



        private void UserControlDashboard1_Load(object sender, EventArgs e)
        {
            List<XmlNode> allClasses = InstructorDataManipulator.GetClassessList();
            labelTotalClasses.Text = allClasses.Count.ToString();
            labelTotalStudents.Text = InstructorDataManipulator.GetCountStudents().ToString();
            CustomizeShape();

        }
        public void CustomizeShape()
        {
            XmlNode userData = InstructorDataManipulator.GetUserNode();
            adminRole.Text = userData.SelectSingleNode("role").InnerText;
            switch (userData.SelectSingleNode("role").InnerText)
            {
                case "instructor":
                    XmlNodeList ownClasses = userData.SelectNodes("class");
                    labelTotalClasses.Text = ownClasses.Count.ToString();
                    panel2.Hide();
                    panel3.Location = new Point(panel1.Location.X + panel3.Size.Width + 150, panel1.Location.Y);

                    //panel3.Anchor = AnchorStyles.Top;
                break;
                case "student":
                    panel2.Hide();
                    panel1.Hide();
                    panel3.Location = new Point(400, 100);
                    break;

            }
        }
    }
}
