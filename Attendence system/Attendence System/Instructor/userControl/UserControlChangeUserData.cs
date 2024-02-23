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
    public partial class UserControlChangeUserData : UserControl
    {
        public UserControlChangeUserData()
        {
            InitializeComponent();
        }

        private void UserControlAddStudent_Load(object sender, EventArgs e)
        {

        }

        private void tabPageChangeData_Click(object sender, EventArgs e)
        {

        }

        private void buttonChangeData_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxEmail.Text == "" || textBoxPhone.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                XmlNode userNode = InstructorDataManipulator.GetUserNode();
                userNode.SelectSingleNode("name").InnerText = textBoxName.Text.Trim();
                userNode.SelectSingleNode("email").InnerText = textBoxEmail.Text.Trim();
                userNode.SelectSingleNode("phone").InnerText = textBoxPhone.Text.Trim();
                if (InstructorDataManipulator.validateUserData(userNode))
                {
                    InstructorDataManipulator.UpdateUserData(userNode);
                    MessageBox.Show("Data updated successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AssignUserValuesToBoxes(userNode);
                }
                else
                {
                    AssignUserValuesToBoxes(InstructorDataManipulator.GetUserNode());
                }
            }
        }
        public void AssignUserValuesToBoxes(XmlNode data)
        {
            string name, email, phone;
            name = data.SelectSingleNode("name").InnerText;
            email = data.SelectSingleNode("email").InnerText;
            phone = data.SelectSingleNode("phone").InnerText;
            textBoxName.Text = name;
            textBoxEmail.Text = email;
            textBoxPhone.Text = phone;
        }

        private void pictureBoxShowPassword_Click(object sender, EventArgs e)
        {
            if (textBoxOldPassword.PasswordChar == '*')
            {
                textBoxOldPassword.PasswordChar = '\0';
                textBoxPasswordNew.PasswordChar = '\0';
                textBoxPasswordConfirm.PasswordChar = '\0';
            }
            else
            {
                textBoxOldPassword.PasswordChar = '*';
                textBoxPasswordNew.PasswordChar = '*';
                textBoxPasswordConfirm.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlNode userNode = InstructorDataManipulator.GetUserNode();
            if(textBoxOldPassword.Text == "" || textBoxPasswordNew.Text == "" || textBoxPasswordConfirm.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxOldPassword.Text == userNode.SelectSingleNode("password").InnerText)
            {
                if (textBoxPasswordNew.Text == textBoxPasswordConfirm.Text)
                {
                    userNode.SelectSingleNode("password").InnerText = textBoxPasswordNew.Text;
                    if (InstructorDataManipulator.validateUserData(userNode))
                    {
                        InstructorDataManipulator.UpdateUserData(userNode);
                        MessageBox.Show("Password updated successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("New password and confirm password do not match", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Old password is incorrect", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
