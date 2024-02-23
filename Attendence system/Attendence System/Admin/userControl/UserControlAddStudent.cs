using Microsoft.VisualBasic.ApplicationServices;
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
using System.Xml.Linq;
using attendence_system.classes;
using Microsoft.VisualBasic;
using System.Security.Cryptography;

namespace attendence_system.Admin.userControl
{
    public partial class UserControlAddStudent : UserControl
    {

        // get xml path file Users
        static string path = @"./../../../../../Xml//usersAuthentication.xml";
        string SID = "";



        // retrieve date from Xml file
        public static List<SystemUser> GetUsers()
        {
            List<SystemUser> users = new List<SystemUser>();
            XDocument dataFile = XDocument.Load(path);
            users = (from user in dataFile.Root.Elements("user")

                     select new SystemUser
                     {
                         id = (int)user.Element("id"),
                         Name = (string)user.Element("name"),
                         Email = (string)user.Element("email"),
                         PhoneNumber = "010200222",
                         Password = (string)user.Element("password"),
                         role = (string)user.Element("role")
                     }
                     ).ToList();
            return users;
        }
       
        // save data in Xml file
        public static void addNewUser(SystemUser Newuser)
        {
            XDocument datafile = XDocument.Load(path);
            XElement userEle = new XElement("user",

                new XElement("id", Newuser.id),
                new XElement("name", Newuser.Name),
                new XElement("email", Newuser.Email),
                new XElement("password", Newuser.Password),
                new XElement("role", Newuser.role)

                );
            datafile.Root.Add(userEle);
            datafile.Save(path);

        }

        public static int gitCountStudent()
        {
            List <SystemUser> users=GetUsers();
           return  users.Count();
        }

        // Method to retrieve a user by ID from the XML data source
        private SystemUser GetUserById(int userId)
        {
            XDocument dataFile = XDocument.Load(path);

            // Find the user element with the matching ID
            XElement userElement = dataFile.Root.Elements("user")
                .FirstOrDefault(user => (int)user.Element("id") == userId);

            if (userElement != null)
            {
                return new SystemUser
                {
                    id = (int)userElement.Element("id"),
                    Name = (string)userElement.Element("name"),
                    Email = (string)userElement.Element("email"),
                    Password = (string)userElement.Element("password"),
                    role = (string)userElement.Element("role")
                };
            }
            else
            {
                return null;
            }
        }


        public UserControlAddStudent()
        {
            InitializeComponent();

        }

        private void ClearText()
        {
            textBoxNameStudent.Clear();
            textBoxEmailstudent.Clear();
            textBoxPassStudent.Clear();
            comboBoxClassStudent.SelectedIndex = -1;
            tabControlAddStudent.SelectedTab = tabPageAddStudent;
        }

        private void ClearText1()
        {
            textBoxName1.Clear();
            textBoxEmail1.Clear();
            textBoxpass1.Clear();
            comboBoxUpDelete.SelectedIndex = -1;
            SID = "";
        }
     

        private void tabControlAddStudent_Enter(object sender, EventArgs e)
        {
            ClearText1();
        }

        private void tabPageAddStudent_Leave(object sender, EventArgs e)
        {
            ClearText();
        }

        private void UdateAndDelete_Enter(object sender, EventArgs e)
        {
            ClearText();

        }

        private void UdateAndDelete_Leave(object sender, EventArgs e)
        {
            ClearText1();


        }

        private void tabPageSearchStudent_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            comboBoxSearchBy.SelectedIndex = -1;
            List<SystemUser> students = GetUsers();
            dataGridViewStudent.DataSource = students;
            labelTotalStudents.Text = dataGridViewStudent.Rows.Count.ToString();

        }

        // Method to add a user in the XML data source

        private void btnAddStudent_Click_1(object sender, EventArgs e)
        {
            if (!(Validation.IsValidName(textBoxNameStudent.Text) && Validation.IsValidEmail(textBoxEmailstudent.Text) && Validation.IsValidPassword(textBoxPassStudent.Text) && comboBoxClassStudent.SelectedIndex != -1))
            {
                MessageBox.Show("First fill out all fields.", "Required all fields", MessageBoxButtons.OK);
                return;
            }
            else
            {
                SystemUser user = new SystemUser()
                {
                    id = Validation.GetLastUserId() + 1,// call fun getlastid to incr id  +1
                    Name = textBoxNameStudent.Text,
                    Email = textBoxEmailstudent.Text,
                    Password = textBoxPassStudent.Text,
                    role = "student"
                };
                UserControlAddStudent.addNewUser(user);
                MessageBox.Show("Added succesfully", "", MessageBoxButtons.OK);

            }
        }
    
        // 
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

            if (comboBoxSearchBy.SelectedIndex == 0)  // Search by name
            {
                string searchText = textBoxSearch.Text.Trim().ToLower(); // Convert search text to lowercase for case-insensitive search
                List<SystemUser> allStudents = GetUsers();

                // Filter students whose names contain the search text
                List<SystemUser> filteredStudents = allStudents.Where(student => student.Name?.ToLower().Contains(searchText) ?? false).ToList();

                dataGridViewStudent.DataSource = filteredStudents;
                labelTotalStudents.Text = filteredStudents.Count.ToString();
            }
            else if (comboBoxSearchBy.SelectedIndex == 1)  // Search by email
            {
                string searchText = textBoxSearch.Text.Trim().ToLower(); // Convert search text to lowercase for case-insensitive search
                List<SystemUser> allStudents = GetUsers();

                // Filter students whose email addresses contain the search text
                List<SystemUser> filteredStudents = allStudents.Where(student => student.Email.ToLower().Contains(searchText)).ToList();

                dataGridViewStudent.DataSource = filteredStudents;
                labelTotalStudents.Text = filteredStudents.Count.ToString();
            }
        }

        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewStudent.Rows[e.RowIndex];
                SID = row.Cells["Column1"].Value.ToString();
                textBoxName1.Text = row.Cells["Column2"].Value.ToString();
                // comboBoxUpDelete.Items.Clear();
                //  comboBoxUpDelete.SelectedItem = row.Cells["Column5"].Value.ToString();
                textBoxEmail1.Text = row.Cells["Column3"].Value.ToString();
                textBoxpass1.Text = row.Cells["Column4"].Value.ToString();


            }
        }

        // Method to update a user in the XML data source
        private void UpdateUser(SystemUser user)
        {
            XDocument dataFile = XDocument.Load(path);

            XElement userElement = dataFile.Root.Elements("user")
                .FirstOrDefault(u => (int)u.Element("id") == user.id);

            // If user element is found, update its attributes
            if (userElement != null)
            {
                userElement.Element("name").Value = user.Name;
                userElement.Element("email").Value = user.Email;
                userElement.Element("password").Value = user.Password;
                userElement.Element("role").Value = user.role;
            }
            else
            {
                // Handle the case where user with specified ID is not found
                MessageBox.Show("User with ID " + user.id + " not found.", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataFile.Save(path);
        }
        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            // Check if SID is not empty and is a valid integer
            if (!string.IsNullOrEmpty(SID) && int.TryParse(SID, out int userId))
            {
                // Retrieve the existing user from the data source
                SystemUser existingUser = GetUserById(userId);

                if (existingUser != null)
                {
                    // Update the existing user's properties
                    existingUser.Name = textBoxName1.Text;
                    existingUser.Email = textBoxEmail1.Text;
                    existingUser.Password = textBoxpass1.Text;

                    // Save the changes back to the data source
                    UpdateUser(existingUser);

                    MessageBox.Show("Updated successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearText1();
                }
                else
                {
                    MessageBox.Show("User with ID " + userId + " not found.", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a row from the table.", "Select Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    
        // Method to Delete a user in the XML data source
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        
        {
                if (!string.IsNullOrEmpty(SID))
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to delete this student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)

                    {
                        XDocument dataFile = XDocument.Load(path);

                        // Find the user element with the matching ID and remove it
                        XElement userToRemove = dataFile.Root.Elements("user")
                            .FirstOrDefault(user => (string)user.Element("id") == SID);

                        if (userToRemove != null)
                        {
                            userToRemove.Remove(); // Remove the user element

                            // Save the updated XML data back to the file
                            dataFile.Save(path);
                             ClearText1();
                            MessageBox.Show("Student deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("User with ID " + SID + " not found.", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row from the table.", "Select Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            

        }


    }
}
