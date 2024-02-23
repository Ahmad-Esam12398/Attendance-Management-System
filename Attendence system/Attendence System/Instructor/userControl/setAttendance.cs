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

namespace attendence_system.Instructor.userControl
{
    public partial class setAttendance : UserControl
    {
        protected DataTable combinedTable;
        public setAttendance()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6 && e.RowIndex != -1)
            {
                string id = dataGridViewAttendance.Rows[e.RowIndex].Cells[0].Value.ToString();
                string date = dataGridViewAttendance.Rows[e.RowIndex].Cells[5].Value.ToString();
                bool status = (bool)dataGridViewAttendance.Rows[e.RowIndex].Cells[6].Value;
                XmlNode studentNode = InstructorDataManipulator.GetUserNode(id);
                XmlNodeList attendanceDates = studentNode.SelectNodes("attendanceDates");
                for (int i = 0; i < attendanceDates.Count; i++)
                {
                    if (attendanceDates[i].SelectSingleNode("date").InnerText == date)
                    {
                        attendanceDates[i].SelectSingleNode("status").InnerText = status ? "absent" : "present";
                        break;
                    }
                }
                //InstructorDataManipulator.UpdateUserData(studentNode);
                InstructorDataManipulator.SaveChangesInFile();
            }
        }

        private void setAttendance_Load(object sender, EventArgs e)
        {
            //DataSet AttendanceData = new DataSet();
            //AttendanceData.ReadXml("D:\\ITI\\Projects\\XML&C#\\new repo\\mine\\Attendance-Management-System\\XmldummyData.xml");
            string dummyDataPath = Path.Combine(Application.StartupPath, @"../../../../../Xml/dummyData.xml");
            //DataSet dataSet = new DataSet();
            //dataSet.ReadXml(path);
            //dataGridViewAttendance.DataSource = dataSet.Tables[1];
            populateDataGirdView();
            assignClassesToComboBox();

        }
        private void populateDataGirdView()
        {
            string usersData = @"./../../../../../Xml/usersAuthenticationC#.xml";
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(usersData);
            combinedTable = new DataTable();
            combinedTable.Columns.Add("id", typeof(string));
            combinedTable.Columns.Add("name", typeof(string));
            combinedTable.Columns.Add("phone", typeof(string));
            combinedTable.Columns.Add("gender", typeof(string));
            combinedTable.Columns.Add("Class", typeof(string));
            combinedTable.Columns.Add("Date", typeof(string));
            DataColumn checkBoxColumn = new DataColumn("Status", typeof(bool));
            combinedTable.Columns.Add(checkBoxColumn);
            //combinedTable.Columns.Add("Status", typeof(string));
            List<XmlNode> students = InstructorDataManipulator.GetStudentsList();
            for (int i = 0; i < students.Count; i++)
            {
                string[,] studentData = getStudentData(students[i]);
                for (int j = 0; j < studentData.GetLength(0); j++)
                {
                    bool status = studentData[j, 6] == "present" ? true : false;
                    combinedTable.Rows.Add(studentData[j, 0], studentData[j, 1], studentData[j, 2], studentData[j, 3], studentData[j, 4], studentData[j, 5], status);
                }
            }
            //combinedTable.Rows.Add("1", "Ahmed", "01010101010", 'M', "2021-05-01", "Present");
            dataGridViewAttendance.DataSource = combinedTable;
            for(int i = 0; i < dataGridViewAttendance.Columns.Count - 1; i++)
            {
                dataGridViewAttendance.Columns[i].ReadOnly = true;
            }
            //dataGridViewAttendance.DataSource = dataSet.Tables[0];
            //dataGridViewAttendance. += dataSet.Tables[2];

            // Hide the column
            //dataGridViewAttendance.Columns["email"].Visible = false;
            //dataGridViewAttendance.Columns["password"].Visible = false;
            //dataGridViewAttendance.Columns["role"].Visible = false;
        }
        private string[,] getStudentData(XmlNode node)
        {
            int dateCounts = node.SelectNodes("attendanceDates").Count;
            string[,] target = new string[dateCounts, 7];
            string id = node.SelectSingleNode("id").InnerText;
            string name = node.SelectSingleNode("name").InnerText;
            string phone = node.SelectSingleNode("phone").InnerText;
            string StudentClass = node.SelectSingleNode("class").InnerText;
            string gender = node.SelectSingleNode("gender").InnerText;
            XmlNodeList attendanceDates = node.SelectNodes("attendanceDates");
            for (int i = 0; i < dateCounts; i++)
            {
                target[i, 0] = id;
                target[i, 1] = name;
                target[i, 2] = phone;
                target[i, 3] = gender;
                target[i, 4] = StudentClass;
                target[i, 5] = attendanceDates[i].SelectSingleNode("date").InnerText;
                target[i, 6] = attendanceDates[i].SelectSingleNode("status").InnerText;
            }
            return target;
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterRows(comboBoxClass.SelectedItem.ToString());
        }
        private void assignClassesToComboBox()
        {
            HashSet<string> classes = InstructorDataManipulator.GetClassesSet();
            foreach (string item in classes)
            {
                comboBoxClass.Items.Add(item);
            }
        }
        private void filterRows(string criteria, string column = "class")
        {
            if(criteria == "All")
            {
                combinedTable.DefaultView.RowFilter = string.Empty;
                return;
            }
            // To clear the filter
            combinedTable.DefaultView.RowFilter = string.Empty;
            // Assuming 'dataTable' is the DataTable bound to your DataGridView
            combinedTable.DefaultView.RowFilter = string.Format($"{column} = '{criteria}'");
        }
    }
}
