using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace attendence_system.Admin.userControl
{
    public partial class UserControlAddTeacher : UserControl
    {
        public UserControlAddTeacher()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // Reading input values from text boxes and combo box
            string name = textBoxTeacherName.Text; // Teacher's name
            string email = textBoxEmailTeacher.Text; // Teacher's email
            //string phone = textBoxPhoneTeacher.Text; // Teacher's phone (assuming you have this text box)
            string password = textBoxPassTeacher.Text; // Teacher's password
            string classAssigned = comboBoxClassTeacher.SelectedItem.ToString(); // Class assigned to the teacher

            // Path to your XML file
            string xmlFilePath = @"D:\badya gdeda\Xml\usersAuthenticationC#.xml";

            try
            {
                // Load the existing XML document
                XDocument xmlDoc = XDocument.Load(xmlFilePath);

                // Find the highest current ID to assign a new unique ID
                int maxId = 0;
                foreach (var elem in xmlDoc.Descendants("user"))
                {
                    int currentId = int.Parse(elem.Element("id").Value);
                    if (currentId > maxId)
                        maxId = currentId;
                }
                int newId = maxId + 1;

                // Create a new user element with the role of "teacher"
                XElement newUser = new XElement("user",
                                    new XElement("id", newId.ToString()),
                                    new XElement("name", name),
                                    new XElement("email", email),
                                    new XElement("password", password),
                                    new XElement("role", "teacher"),
                                    new XElement("class", classAssigned)); // Including class information

                // Add the new user element to the root
                xmlDoc.Root.Add(newUser);

                // Save the document
                xmlDoc.Save(xmlFilePath);

                MessageBox.Show("Teacher added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add teacher: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        

    }
}
}
