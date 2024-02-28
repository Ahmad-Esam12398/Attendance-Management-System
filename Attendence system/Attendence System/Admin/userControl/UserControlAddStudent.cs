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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using attendence_system;
using System.Data.SqlTypes;

namespace attendence_system.Admin.userControl
{
    public partial class UserControlAddStudent : UserControl
    {
        string SIDString = "";

        public UserControlAddStudent()
        {
            InitializeComponent();

        }

        private void ClearText()
        {
            textBoxNameStudent.Clear();
            textBoxEmailstudent.Clear();
            textBoxPassStudent.Clear();
            // comboBoxClassStudent.SelectedIndex = -1;
            tabControlAddStudent.SelectedTab = tabPageAddStudent;
        }

        private void ClearText1()
        {
            textBoxName1.Clear();
            textBoxEmail1.Clear();
            textBoxpass1.Clear();
            textBoxphoneNumber1.Clear();
            comboBoxClasses1.SelectedIndex = -1;
            comboBoxGender1.SelectedIndex = -1;
            SIDString = "";
        }


        private void tabControlAddStudent_Enter(object sender, EventArgs e)
        {
            ClearText1();
            comboBoxClassStudent.Items.Clear();
            // Call the method to get the unique class values
            HashSet<string> classes = InstructorDataManipulator.GetClassesSet();

            // Add the class values to the ComboBox
            foreach (string className in classes)
            {
                comboBoxClassStudent.Items.Add(className);
            }
        }

        private void tabPageAddStudent_Leave(object sender, EventArgs e)
        {
            ClearText();
        }

        private void UdateAndDelete_Enter(object sender, EventArgs e)
        {
            ClearText();
            comboBoxClassStudent.Items.Clear();
            // Call the method to get the unique class values
            HashSet<string> classes = InstructorDataManipulator.GetClassesSet();

            // Add the class values to the ComboBox
            foreach (string className in classes)
            {
                comboBoxClassStudent.Items.Add(className);
            }

        }


        //============= Create a DataTable to hold the student information===========
        static public DataTable GetStudentsDataTable()
        {
            XmlDocument usersData = InstructorDataManipulator.usersData;

            DataTable dtStudents = new DataTable();
            dtStudents.Columns.Add("id", typeof(int));
            dtStudents.Columns.Add("name", typeof(string));
            dtStudents.Columns.Add("email", typeof(string));
            dtStudents.Columns.Add("class", typeof(string));
            dtStudents.Columns.Add("phone", typeof(string));
            dtStudents.Columns.Add("gender", typeof(string));


            // Select all user nodes with role 'student'
            XmlNodeList studentNodes = usersData.SelectNodes("/users/user[role='student']");

            foreach (XmlNode studentNode in studentNodes)
            {
                DataRow dr = dtStudents.NewRow();
                dr["id"] = int.Parse(studentNode.SelectSingleNode("id").InnerText);
                dr["name"] = studentNode.SelectSingleNode("name").InnerText;
                dr["email"] = studentNode.SelectSingleNode("email").InnerText;
                dr["class"] = studentNode.SelectSingleNode("class").InnerText;
                dr["phone"] = studentNode.SelectSingleNode("phone").InnerText;
                dr["gender"] = studentNode.SelectSingleNode("gender").InnerText;
                dtStudents.Rows.Add(dr);
            }

            return dtStudents;
        }


        // ==============Method to retrieve a user by ID from the XML data source==========
        private XmlNode GetStudentById(int studentId)
        {
            XmlDocument usersData = InstructorDataManipulator.usersData;

            // Find the student node with the matching ID
            XmlNode studentNode = usersData.SelectSingleNode($"/users/user[id={studentId} and role='student']");

            return studentNode;
        }

        private void tabPageSearchStudent_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            comboBoxSearchBy.SelectedIndex = -1;
            // Call the function to get the student data
            DataTable studentData = GetStudentsDataTable();
            // Assuming dataGridViewStudent is your DataGridView control
            dataGridViewStudent.DataSource = studentData;
            labelTotalStudents.Text = dataGridViewStudent.Rows.Count.ToString();

        }


        //===============Method to add a user in the XML data source===============
        private void btnAddStudent_Click_1(object sender, EventArgs e)
        { 

            XmlDocument usersData = InstructorDataManipulator.usersData;
            if (!(Validation.IsValidName(textBoxNameStudent.Text) && Validation.IsValidEmail(textBoxEmailstudent.Text) && Validation.IsValidPassword(textBoxPassStudent.Text)&&Validation.IsValidPhone(textBoxphoneNumber.Text) && comboBoxClassStudent.SelectedIndex != -1&&comboBoxGender.SelectedIndex!=-1))
            {
                MessageBox.Show("First fill out all fields.", "Required all fields", MessageBoxButtons.OK);
                return;
            }
            else
            {
                // Create a new user node
                XmlDocument doc = new XmlDocument();
                XmlNode newUser = doc.CreateElement("user");

                XmlNode idNode = doc.CreateElement("id");

                idNode.InnerText = (InstructorDataManipulator.GetLastUserId() + 1).ToString();
                newUser.AppendChild(idNode);

                XmlNode nameNode = doc.CreateElement("name");
                nameNode.InnerText = textBoxNameStudent.Text;
                newUser.AppendChild(nameNode);

                XmlNode emailNode = doc.CreateElement("email");
                emailNode.InnerText = textBoxEmailstudent.Text;
                newUser.AppendChild(emailNode);

                XmlNode phoneNode = doc.CreateElement("phone");
                phoneNode.InnerText = textBoxphoneNumber.Text;
                newUser.AppendChild(phoneNode);

                XmlNode passwordNode = doc.CreateElement("password");
                passwordNode.InnerText = textBoxPassStudent.Text;
                newUser.AppendChild(passwordNode);

                XmlNode genderNode = doc.CreateElement("gender");
                if (comboBoxGender.SelectedItem.ToString() == "female")
                {
                    genderNode.InnerText = "f";

                }
                else
                {
                    genderNode.InnerText = "m";

                }
                //   genderNode.InnerText = comboBoxGender.SelectedItem.ToString();
                newUser.AppendChild(genderNode);

                XmlNode roleNode = doc.CreateElement("role");
                roleNode.InnerText = "student";
                newUser.AppendChild(roleNode);

                string selectedClass = comboBoxClassStudent.SelectedItem.ToString();
                var resault = InstructorDataManipulator.GetClassIdByName(selectedClass);
                if (resault != null)
                {
                    XmlNode classNode = doc.CreateElement("class");

                    // Set the ID attribute for the class node
                    XmlAttribute idAttribute = doc.CreateAttribute("id");
                    idAttribute.Value = resault;
                    classNode.Attributes.Append(idAttribute);

                    // Set the text content (class name) for the class node
                    classNode.InnerText = selectedClass;

                    // Append the class node to the newUser node
                    newUser.AppendChild(classNode);

                }
                else
                {
                    return;
                }
                attendence_system.InstructorDataManipulator.AddNewUser(newUser);

                MessageBox.Show("Added succesfully", "", MessageBoxButtons.OK);


            }
        }


        // ======================= Delete Specific User =======================
        private void DeleteUser(string id)
        {
            // Get the user node by ID
            XmlNode userNodeToDelete = InstructorDataManipulator.GetUserNode(id);

            // Check if the user node exists
            if (userNodeToDelete != null)
            {

                // Get the parent node of the user node (which should be the "users" node)
                XmlNode parentNode = userNodeToDelete.ParentNode;

                // Remove the user node from its parent
                parentNode.RemoveChild(userNodeToDelete);

                InstructorDataManipulator.SaveChangesInFile();

                MessageBox.Show("Student deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText1();

            }

        }

        // ============Method to Delete a user in the XML data source
        private void btnDeleteStudent_Click(object sender, EventArgs e)

        {

            if (!string.IsNullOrEmpty(SIDString))
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to delete this student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)

                {
                    DeleteUser(SIDString);
                }
            }
            else
            {
                MessageBox.Show("Please select a row from the table.", "Select Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void textBoxSearch_TextChanged_1(object sender, EventArgs e)
        {
            if (comboBoxSearchBy.SelectedIndex == 0)  // Search by name
            {
                string searchText = textBoxSearch.Text.Trim().ToLower(); // Convert search text to lowercase for case-insensitive search
                List<XmlNode> allStudents = InstructorDataManipulator.GetStudentsList();

                // Filter students whose names contain the search text
                List<XmlNode> filteredStudents = allStudents.Where(student => student.SelectSingleNode("name")?.InnerText.ToLower().Contains(searchText) ?? false).ToList();

                dataGridViewStudent.DataSource = ConvertXmlNodeListToDataTable(filteredStudents);
                labelTotalStudents.Text = filteredStudents.Count.ToString();
            }
            else if (comboBoxSearchBy.SelectedIndex == 1)  // Search by email
            {
                string searchText = textBoxSearch.Text.Trim().ToLower(); // Convert search text to lowercase for case-insensitive search
                List<XmlNode> allStudents = InstructorDataManipulator.GetStudentsList();

                // Filter students whose email addresses contain the search text
                List<XmlNode> filteredStudents = allStudents.Where(student => student.SelectSingleNode("email")?.InnerText.ToLower().Contains(searchText) ?? false).ToList();

                dataGridViewStudent.DataSource = ConvertXmlNodeListToDataTable(filteredStudents);
                labelTotalStudents.Text = filteredStudents.Count.ToString();
            }
            else if (comboBoxSearchBy.SelectedIndex == 2)// Search by class
            {
                string searchText = textBoxSearch.Text.Trim().ToLower(); // Convert search text to lowercase for case-insensitive search
                List<XmlNode> allStudents = InstructorDataManipulator.GetStudentsList();

                // Filter students whose email addresses contain the search text
                List<XmlNode> filteredStudents = allStudents.Where(student => student.SelectSingleNode("class")?.InnerText.ToLower().Contains(searchText) ?? false).ToList();

                dataGridViewStudent.DataSource = ConvertXmlNodeListToDataTable(filteredStudents);
                labelTotalStudents.Text = filteredStudents.Count.ToString();
            }
        }

        // Method to convert XmlNodeList to DataTable
        private DataTable ConvertXmlNodeListToDataTable(List<XmlNode> nodeList)
        {
            DataTable dataTable = new DataTable();
            // Add columns
            dataTable.Columns.Add("id", typeof(int));
            dataTable.Columns.Add("name", typeof(string));
            dataTable.Columns.Add("email", typeof(string));
            dataTable.Columns.Add("class", typeof(string));
            dataTable.Columns.Add("phone", typeof(string));
            dataTable.Columns.Add("gender", typeof(string));

            // Add rows
            foreach (XmlNode node in nodeList)
            {
                DataRow row = dataTable.NewRow();
                row["id"] = int.Parse(node.SelectSingleNode("id").InnerText);
                row["name"] = node.SelectSingleNode("name").InnerText;
                row["email"] = node.SelectSingleNode("email").InnerText;
                row["class"] = node.SelectSingleNode("class").InnerText;
                row["phone"] = node.SelectSingleNode("phone").InnerText;
                row["gender"] = node.SelectSingleNode("gender").InnerText;
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        private void dataGridViewStudent_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxClasses1.Items.Clear();
            comboBoxGender1.Items.Clear();

            DataGridViewRow row = dataGridViewStudent.Rows[e.RowIndex];
            SIDString = row.Cells["Column1"].Value.ToString(); // Assuming SID is a string
            int SID;
            if (int.TryParse(SIDString, out SID))
            {
                textBoxName1.Text = row.Cells["Column2"].Value.ToString();
                textBoxEmail1.Text = row.Cells["Column3"].Value.ToString();
                //  comboBoxClasses1.SelectedItem = comboBoxClassStudent.SelectedItem;

                // comboBoxGender1.SelectedItem = row.Cells["Column4"].Value.ToString();
                // comboBoxUpDelete1.SelectedItem = row.Cells["Column5"].Value.ToString();
                textBoxphoneNumber1.Text = row.Cells["Column6"].Value.ToString();

                // Retrieve and display password
                XmlNode currentNode = GetStudentById(SID);
                if (currentNode != null)
                {
                    XmlNode passwordNode = currentNode.SelectSingleNode("password");
                    if (passwordNode != null)
                    {
                        textBoxpass1.Text = passwordNode.InnerText;
                    }

                }

            }
        }

        private void tabPageUpdateAndDelete_Enter(object sender, EventArgs e)
        {
            comboBoxClasses1.Items.Clear();
            // Call the method to get the unique class values
            HashSet<string> classes = InstructorDataManipulator.GetClassesSet();

            // Add the class values to the ComboBox
            foreach (string className in classes)
            {
                comboBoxClasses1.Items.Add(className);
            }
            comboBoxGender1.Items.AddRange(["female", "male"]);
            if (comboBoxClassStudent.SelectedItem != null)
            {
                comboBoxGender1.SelectedItem = comboBoxClassStudent.SelectedItem;
            }
        }

        // ============Method to update a user in the XML data source
        private void btnUpdateStudent_Click_1(object sender, EventArgs e)
        {
            // Check if SID is not empty and is a valid integer
            if (!string.IsNullOrEmpty(SIDString) && int.TryParse(SIDString, out int userId))
            {
                // Retrieve the existing user node from the data source
                XmlNode existingUserNode = InstructorDataManipulator.GetUserNode(userId.ToString());

                if (existingUserNode != null)
                {
                    // Create a new XML node to hold the updated user information
                    XmlDocument doc = existingUserNode.OwnerDocument;
                    XmlNode newUserNode = doc.CreateElement("user");

                    // Populate the new XML node with updated information
                    XmlNode idNode = doc.CreateElement("id");
                    idNode.InnerText = userId.ToString();
                    newUserNode.AppendChild(idNode);

                    XmlNode nameNode = doc.CreateElement("name");
                    nameNode.InnerText = textBoxName1.Text;
                    newUserNode.AppendChild(nameNode);

                    XmlNode emailNode = doc.CreateElement("email");
                    emailNode.InnerText = textBoxEmail1.Text;
                    newUserNode.AppendChild(emailNode);


                    XmlNode phoneNode = doc.CreateElement("phone");
                    phoneNode.InnerText = textBoxphoneNumber1.Text;
                    newUserNode.AppendChild(phoneNode);



                    XmlNode passwordNode = doc.CreateElement("password");
                    passwordNode.InnerText = textBoxpass1.Text;
                    newUserNode.AppendChild(passwordNode);

                    // Handle class selection
                    string selectedClass = comboBoxClasses1.SelectedItem?.ToString();
                    if (!string.IsNullOrEmpty(selectedClass))
                    {
                        var result = InstructorDataManipulator.GetClassIdByName(selectedClass);
                        if (result != null)
                        {
                            XmlNode classNode = doc.CreateElement("class");

                            // Set the ID attribute for the class node
                            XmlAttribute idAttribute = doc.CreateAttribute("id");
                            idAttribute.Value = result;
                            classNode.Attributes.Append(idAttribute);

                            // Set the text content (class name) for the class node
                            classNode.InnerText = selectedClass;

                            // Append the class node to the newUser node
                            newUserNode.AppendChild(classNode);
                        }
                    }

                    // Handle gender selection
                    XmlNode genderNode = doc.CreateElement("gender");
                    if (comboBoxGender1.SelectedItem?.ToString() == "female")
                    {
                        genderNode.InnerText = "f";

                    }
                    else
                    {
                        genderNode.InnerText = "m";

                    }

                    newUserNode.AppendChild(genderNode);

                    // Call the UpdateUserData function with the new user node
                    InstructorDataManipulator.UpdateUserData(newUserNode);

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

        private void tabPageUpdateAndDelete_Leave(object sender, EventArgs e)
        {
            ClearText1();

        }
    }

}
