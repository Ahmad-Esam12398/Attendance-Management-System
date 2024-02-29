using System;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.RegularExpressions; // For email validation
using attendence_system;
using System.Xml;
using System.Collections.Generic;
using attendence_system.classes;
using System.Data;
using attendence_system.Instructor;
using System.Net;
using System.Data.SqlTypes;
namespace attendence_system.Admin.userControl
{
    public partial class UserControlAddTeacher : UserControl
    {
        string SID = "";
        BindingSource teacherBindingSource = new BindingSource();

        public UserControlAddTeacher()
        {
            InitializeComponent();

        }
        XmlDocument data = InstructorDataManipulator.usersData;
        List<XmlNode> instructors = InstructorDataManipulator.GetinstructorList();
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            if (!(Validation.IsValidName(textBoxTeacherName.Text)
                && Validation.IsValidEmail(textBoxEmailTeacher.Text)
                && Validation.IsValidPassword(textBoxPassTeacher.Text)
                && Validation.IsValidPhone(phonenumbertextBox.Text)
                && comboBoxClassTeacher.SelectedIndex != -1
                && gendercomboBox1.SelectedIndex != -1))
            {
                MessageBox.Show("First fill out all fields.", "Required all fields", MessageBoxButtons.OK);
                return;
            }
            else
            {
                XmlNode newUser = InstructorDataManipulator.usersData.CreateElement("user");

                XmlNode idNode = InstructorDataManipulator.usersData.CreateElement("id");
                idNode.InnerText = (InstructorDataManipulator.GetLastUserId() + 1).ToString();
                newUser.AppendChild(idNode);

                XmlNode nameNode = InstructorDataManipulator.usersData.CreateElement("name");
                nameNode.InnerText = textBoxTeacherName.Text;
                newUser.AppendChild(nameNode);

                XmlNode emailNode = InstructorDataManipulator.usersData.CreateElement("email");
                emailNode.InnerText = textBoxEmailTeacher.Text;
                newUser.AppendChild(emailNode);

                XmlNode phoneNode = InstructorDataManipulator.usersData.CreateElement("phone");
                phoneNode.InnerText = phonenumbertextBox.Text;
                newUser.AppendChild(phoneNode);

                XmlNode passwordNode = InstructorDataManipulator.usersData.CreateElement("password");
                passwordNode.InnerText = textBoxPassTeacher.Text;
                newUser.AppendChild(passwordNode);

                XmlNode genderNode = InstructorDataManipulator.usersData.CreateElement("gender");
                genderNode.InnerText = gendercomboBox1.SelectedItem.ToString() == "female" ? "f" : "m";
                newUser.AppendChild(genderNode);

                XmlNode roleNode = InstructorDataManipulator.usersData.CreateElement("role");
                roleNode.InnerText = "instructor"; // Set role as instructor
                newUser.AppendChild(roleNode);

                string selectedClass = comboBoxClassTeacher.SelectedItem.ToString();
                Console.WriteLine(selectedClass);
                var result = InstructorDataManipulator.GetClassIdByName(selectedClass);
                Console.WriteLine(result);
                if (result != null)
                {
                    XmlNode classNode = InstructorDataManipulator.usersData.CreateElement("class");
                    XmlAttribute idAttribute = InstructorDataManipulator.usersData.CreateAttribute("id");
                    idAttribute.Value = result;
                    classNode.Attributes.Append(idAttribute);
                    classNode.InnerText = selectedClass;
                    newUser.AppendChild(classNode);
                }
                else
                {
                    MessageBox.Show("Class not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                InstructorDataManipulator.AddNewUser(newUser);
                MessageBox.Show("Teacher added successfully", "Success", MessageBoxButtons.OK);
            }
        }

        static public DataTable GetStudentsDataTable()
        {
            XmlDocument usersData = InstructorDataManipulator.usersData;

            DataTable dtStudents = new DataTable();
            dtStudents.Columns.Add("id", typeof(int));
            dtStudents.Columns.Add("name", typeof(string));
            dtStudents.Columns.Add("email", typeof(string));
            // dtStudents.Columns.Add("class", typeof(string));
            dtStudents.Columns.Add("phone", typeof(string));
            dtStudents.Columns.Add("gender", typeof(string));


            // Select all user nodes with role 'student'
            XmlNodeList instructors = usersData.SelectNodes("/users/user[role='instructor']");

            foreach (XmlNode ins in instructors)
            {
                DataRow dr = dtStudents.NewRow();
                dr["id"] = int.Parse(ins.SelectSingleNode("id").InnerText);
                dr["name"] = ins.SelectSingleNode("name").InnerText;
                dr["email"] = ins.SelectSingleNode("email").InnerText;
                // dr["class"] = ins.SelectSingleNode("class").InnerText;
                dr["phone"] = ins.SelectSingleNode("phone").InnerText;
                dr["gender"] = ins.SelectSingleNode("gender").InnerText;
                dtStudents.Rows.Add(dr);
            }

            return dtStudents;
        }
        private XmlNode GetStudentById(int studentId)
        {
            XmlDocument usersData = InstructorDataManipulator.usersData;

            // Find the student node with the matching ID
            XmlNode studentNode = usersData.SelectSingleNode($"/users/user[id={studentId} and role='student']");

            return studentNode;
        }
        private void dataGridViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow row = dataGridViewStudent.Rows[e.RowIndex];
          string  SIDString = row.Cells["idcol"].Value.ToString(); // Assuming SID is a string
            int SID;
            if (int.TryParse(SIDString, out SID))
            {
                textBoxName1.Text = row.Cells["namecol"].Value.ToString();
                textBoxEmail1.Text = row.Cells["emailcol"].Value.ToString();
                //  comboBoxClasses1.SelectedItem = comboBoxClassStudent.SelectedItem;

                // comboBoxGender1.SelectedItem = row.Cells["Column4"].Value.ToString();
                // comboBoxUpDelete1.SelectedItem = row.Cells["Column5"].Value.ToString();
                //phonetextBox2.Text = row.Cells["Column5"].Value.ToString();

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
        private void tabPageSearchTeacher_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            comboBoxSearchBy.SelectedIndex = -1;
            // Call the function to get the student data
            DataTable studentData = GetStudentsDataTable();
            // Assuming dataGridViewStudent is your DataGridView control
            dataGridViewStudent.DataSource = studentData;
            labelTotalStudents.Text = dataGridViewStudent.Rows.Count.ToString();
        }

    } 

}








