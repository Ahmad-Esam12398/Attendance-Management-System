using System;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.RegularExpressions; // For email validation

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

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            // Reading input values from text boxes and combo box
            string name = textBoxTeacherName.Text.Trim(); // Teacher's name
            string email = textBoxEmailTeacher.Text.Trim(); // Teacher's email
            string password = textBoxPassTeacher.Text; // Teacher's password
            string classAssigned = comboBoxClassTeacher.SelectedIndex >= 0 ? comboBoxClassTeacher.SelectedItem.ToString() : ""; // Ensuring a class is selected

            // Basic validation checks
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(classAssigned))
            {
                MessageBox.Show("Please fill out all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidName(name))
            {
                MessageBox.Show("Name must contain only letters and spaces.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidPassword(password))
            {
                MessageBox.Show("Password must be at least 8 characters long and include a mix of uppercase and lowercase letters, digits, and special characters.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Email format validation
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Assuming you have a method to validate password strength
            // if (!IsValidPassword(password)) { ... }

            // Assuming the path to your XML file is correct
            string xmlFilePath = @"D:\badya gdeda\Xml\usersAuthenticationC#.xml";

            try
            {
                XDocument xmlDoc = XDocument.Load(xmlFilePath);

                int maxId = 0;
                foreach (var elem in xmlDoc.Descendants("user"))
                {
                    int currentId = int.Parse(elem.Element("id").Value);
                    if (currentId > maxId)
                        maxId = currentId;
                }
                int newId = maxId + 1;

                XElement newUser = new XElement("user",
                    new XElement("id", newId.ToString()),
                    new XElement("name", name),
                    new XElement("email", email),
                    new XElement("password", password),
                    new XElement("role", "teacher"),
                    new XElement("class", classAssigned));

                xmlDoc.Root.Add(newUser);
                xmlDoc.Save(xmlFilePath);

                MessageBox.Show("Teacher added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add teacher: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Email validation method
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private bool IsValidPassword(string password)
        {
            // Minimum eight characters, at least one uppercase letter, one lowercase letter, one number and one special character
            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
        }

        private bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Z\s]+$");
        }

        private void dataGridViewTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        
    }



}
