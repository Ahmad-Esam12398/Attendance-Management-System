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
    public partial class UserControlAddClass : UserControl
    {
        public UserControlAddClass()
        {
            InitializeComponent();
        }
        private void ClearText()
        {
            textBoxName.Clear();
            textBoxHMstudent.Clear();
            tabControlAddClass.SelectedTab = tabPageAddClass;
        }

        private void ClearText1()
        {
            textBoxName1.Clear();
            textBoxHMstudent1.Clear();
        }
        private void btnAddClass_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {

        }

        private void tabPageUpdateAndDelete_Leave(object sender, EventArgs e)
        {
            ClearText1();
        }

        private void tabControlAddClass_Leave(object sender, EventArgs e)
        {
            textBoxSearchBox.Clear();   

        }
    }
}
