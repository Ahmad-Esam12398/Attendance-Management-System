using AttendanceManagmentProject.Admin;
using attendence_system.Instructor;
using System;
using System.Windows.Forms;
using System.Xml;

namespace attendence_system
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

            // Example: Set background color
            this.BackColor = System.Drawing.Color.LightGray; // Set your desired color



        }

        private void login_Load(object sender, EventArgs e)
        {
            // Initialization actions when the form loads, if needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;
            string userRole = AuthenticateUser(email, password);

            if (userRole != null)
            {
                switch (userRole.ToLower())
                {
                    case "admin":
                        MessageBox.Show("Login Successful as Admin!");
                        // Hide the current login form
                        this.Hide();
                        // Create and show the admin form
                        admin adminForm = new admin();
                        adminForm.FormClosed += (s, args) => this.Close(); // Close the login form when the admin form is closed
                        adminForm.Show();
                        break;
                    case "instructor":
                        MessageBox.Show("Login Successful as Instructor!");
                        this.Hide();
                        // Create and show the admin form
                        instructor instructorform = new instructor();
                        instructorform.FormClosed += (s, args) => this.Close(); // Close the login form when the admin form is closed
                        instructorform.Show();

                        break;
                    case "student":
                        MessageBox.Show("Login Successful as Student!");
                        break;
                    default:
                        MessageBox.Show("Login Successful. Role: " + userRole);
                        break;
                }
                // Proceed with login success actions based on role
            }
            else
            {
                MessageBox.Show("Login Failed. Please check your email and password.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string AuthenticateUser(string email, string password)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\newprocjectattendance\\new-attendance-project-repo\\Xml\\usersAuthentication.xml"); // Adjust the path as necessary

            XmlNodeList users = doc.SelectNodes("//user");
            foreach (XmlNode user in users)
            {
                string userEmail = user.SelectSingleNode("email")?.InnerText;
                string userPassword = user.SelectSingleNode("password")?.InnerText;
                if (userEmail == email && userPassword == password)
                {
                    // Return the role of the user if authentication is successful
                    return user.SelectSingleNode("role")?.InnerText;
                }
            }
            return null; // User not found or authentication failed
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
