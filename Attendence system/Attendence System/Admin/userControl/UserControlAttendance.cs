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

namespace attendence_system.Admin.userControl
{
    public partial class UserControlAttendance : UserControl
    {
        protected DataTable combinedTable;

        public UserControlAttendance()
        {
            InitializeComponent();
            populateDataGridView();
        }

        private void populateDataGridView()
        {
            // Assuming the XML file path is correct
            string usersData = @"./../../../../../Xml/usersAuthenticationC#.xml";

            // Load the XML data into a DataSet
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(usersData);

            // Create a new DataTable to hold combined data
            combinedTable = new DataTable();
            combinedTable.Columns.Add("ID", typeof(string));
            combinedTable.Columns.Add("Name", typeof(string));
            combinedTable.Columns.Add("Phone", typeof(string));
            combinedTable.Columns.Add("Gender", typeof(string));
            combinedTable.Columns.Add("Class", typeof(string));
            combinedTable.Columns.Add("Date", typeof(DateTime));
            combinedTable.Columns.Add("Status", typeof(string));

            // Get all students from the XML
            List<XmlNode> students = InstructorDataManipulator.GetStudentsList();

            // Iterate through each student
            foreach (XmlNode student in students)
            {
                string id = student.SelectSingleNode("id").InnerText;
                string name = student.SelectSingleNode("name").InnerText;
                string phone = student.SelectSingleNode("phone").InnerText;
                string gender = student.SelectSingleNode("gender").InnerText;
                string studentClass = student.SelectSingleNode("class").InnerText;

                // Get attendance dates for the student
                XmlNodeList attendanceDates = student.SelectNodes("attendanceDates");

                // Iterate through each attendance date
                foreach (XmlNode attendanceDate in attendanceDates)
                {
                    DateTime date = DateTime.Parse(attendanceDate.SelectSingleNode("date").InnerText);
                    string status = attendanceDate.SelectSingleNode("status").InnerText;

                    // Add a row to the DataTable
                    combinedTable.Rows.Add(id, name, phone, gender, studentClass, date, status);
                }
            }

            // Bind the DataTable to the DataGridView
            dataGridViewAttendance.DataSource = combinedTable;

            // Check if the "Date" column exists before setting its format
            if (dataGridViewAttendance.Columns["Date"] != null)
            {
                dataGridViewAttendance.Columns["Date"].DefaultCellStyle.Format = "dd-MM-yyyy";
            }

            // Make all columns except the last one (Status) read-only
            for (int i = 0; i < dataGridViewAttendance.Columns.Count - 1; i++)
            {
                dataGridViewAttendance.Columns[i].ReadOnly = true;
            }
        }

        private void textBoxSearchAttend_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
