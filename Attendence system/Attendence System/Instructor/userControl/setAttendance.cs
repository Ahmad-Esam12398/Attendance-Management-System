using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System.Data;
using System.IO;

namespace attendence_system.Instructor.userControl
{
    public partial class setAttendance : UserControl
    {
        protected DataTable combinedTable;
        public setAttendance()
        {
            InitializeComponent();
        }
        private void dataGridViewAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex != -1)
            {
                string id = dataGridViewAttendance.Rows[e.RowIndex].Cells[0].Value.ToString();
                string dateTime = dataGridViewAttendance.Rows[e.RowIndex].Cells[5].Value.ToString();
                string date = DateTime.Parse(dateTime).ToString("yyyy-MM-dd");
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
            //string dummyDataPath = Path.Combine(Application.StartupPath, @"../../../../../Xml/dummyData.xml");
            //DataSet dataSet = new DataSet();
            //dataSet.ReadXml(path);
            //dataGridViewAttendance.DataSource = dataSet.Tables[1];
            populateDataGirdView();
            assignClassesToComboBox();
            CustomizeToUser();

        }
        private void CustomizeToUser()
        {
            XmlNode userNode = InstructorDataManipulator.GetUserNode();
            if (userNode.SelectSingleNode("role").InnerText == "student")
            {
                filterRows(userNode.SelectSingleNode("id").InnerText, "id");
            }

        }
        private void populateDataGirdView()
        {
            string usersData = @"./../../../Xml/usersAuthentication.xml";
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(usersData);
            combinedTable = new DataTable();
            combinedTable.Columns.Add("id", typeof(string));
            combinedTable.Columns.Add("name", typeof(string));
            combinedTable.Columns.Add("phone", typeof(string));
            combinedTable.Columns.Add("gender", typeof(string));
            combinedTable.Columns.Add("Class", typeof(string));
            combinedTable.Columns.Add("Date", typeof(DateTime));
            DataColumn checkBoxColumn = new DataColumn("Status", typeof(bool));
            combinedTable.Columns.Add(checkBoxColumn);
            //combinedTable.Columns.Add("Status", typeof(string));
            List<XmlNode> students = InstructorDataManipulator.GetStudentsList();
            for (int i = 0; i < students.Count; i++)
            {
                string[,] studentData = getStudentData(students[i]);
                for (int j = 0; j < studentData.GetLength(0); j++)
                {
                    DateTime date = DateTime.Parse(studentData[j, 5]);
                    bool status = studentData[j, 6] == "present" ? true : false;
                    combinedTable.Rows.Add(studentData[j, 0], studentData[j, 1], studentData[j, 2], studentData[j, 3], studentData[j, 4], date, status);
                }
            }
            //combinedTable.Rows.Add("1", "Ahmed", "01010101010", 'M', "2021-05-01", "Present");
            dataGridViewAttendance.DataSource = combinedTable;
            dataGridViewAttendance.Columns["Date"].DefaultCellStyle.Format = "dd-MM-yyyy";
            for (int i = 0; i < dataGridViewAttendance.Columns.Count - 1; i++)
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
            string id = node.SelectSingleNode("id").InnerText;
            string name = node.SelectSingleNode("name").InnerText;
            string phone = node.SelectSingleNode("phone").InnerText;
            string StudentClass = node.SelectSingleNode("class").InnerText;
            string gender = node.SelectSingleNode("gender").InnerText;
            XmlNodeList attendanceDates = node.SelectNodes("attendanceDates");
            bool today = false;
            for (int i = 0; i < attendanceDates.Count; i++)
            {
                if (attendanceDates[i].SelectSingleNode("date").InnerText == DateTime.Now.ToString("yyyy-MM-dd"))
                {
                    today = true;
                    break;
                }
            }
            if (!today)
            {
                XmlNode dateNode = node.OwnerDocument.CreateElement("date");
                dateNode.InnerText = DateTime.Now.ToString("yyyy-MM-dd");
                XmlNode statusNode = node.OwnerDocument.CreateElement("status");
                statusNode.InnerText = "absent";
                XmlNode attendanceNode = node.OwnerDocument.CreateElement("attendanceDates");
                attendanceNode.AppendChild(dateNode);
                attendanceNode.AppendChild(statusNode);
                node.AppendChild(attendanceNode);
                InstructorDataManipulator.SaveChangesInFile();
            }
            attendanceDates = node.SelectNodes("attendanceDates");
            string[,] target = new string[attendanceDates.Count, 7];
            for (int i = 0; i < attendanceDates.Count; i++)
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

        private void comboBoxClass_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            filterRows(comboBoxClass.SelectedItem.ToString());
        }
        private void assignClassesToComboBox()
        {
            comboBoxClass.Items.Clear();
            comboBoxClass.Items.Add("All");
            XmlNodeList teacherClasses = InstructorDataManipulator.GetUserNode().SelectNodes("class");
            //HashSet<string> classes = InstructorDataManipulator.GetClassesSet();
            foreach (XmlNode item in teacherClasses)
            {
                comboBoxClass.Items.Add(item.InnerText);
            }
        }

        private void filterRows(string criteria, string column = "class", string comparison = "=", DateTime dateCriteria = default)
        {
            if (column == "Date")
            {
                var formattedDate = dateCriteria.ToString("MM-d-yyyy");
                combinedTable.DefaultView.RowFilter = $"{column} {comparison} #{formattedDate}#";
            }
            else
            {
                if (criteria == "All")
                {
                    combinedTable.DefaultView.RowFilter = string.Empty;
                    return;
                }

                // To clear the filter
                combinedTable.DefaultView.RowFilter = string.Empty;
                // Assuming 'dataTable' is the DataTable bound to your DataGridView
                combinedTable.DefaultView.RowFilter = string.Format($"{column} {comparison} '%{criteria}%'");
            }
        }
        private void filterRowsByTwoColumns(string criteria, string column1, string column2)
        {
            combinedTable.DefaultView.RowFilter = $"{column1} LIKE '%{criteria}%' OR {column2} LIKE '%{criteria}%'";
        }

        private void dateTimePickerFrom_ValueChanged_1(object sender, EventArgs e)
        {
            filterRows("", "Date", ">=", dateTimePickerFrom.Value);
        }
        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            filterRows("", "Date", "<=", dateTimePickerTo.Value);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxSearchValue.Text;
            string searchColumn = comboBoxSearchBy.SelectedItem.ToString();
            if (searchColumn == "Both" || searchColumn == "")
            {
                filterRowsByTwoColumns(searchValue, "name", "phone");
            }
            else
            {
                filterRows(searchValue, searchColumn, "LIKE");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxExtension.SelectedItem == null)
            {
                MessageBox.Show("Please select a file type to save the file.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MapSaveAsToFile(comboBoxExtension.SelectedItem.ToString());
        }
        private void MapSaveAsToFile(string extension)
        {
            switch (extension)
            {
                case "PDF":
                    InstructorDataManipulator.SaveFileDialogCustom("PDF files (*.pdf)", "pdf", "Save PDF", InstructorDataManipulator.GeneratePdfFromDataGridView, dataGridViewAttendance);
                    break;
                case "CSV":
                    InstructorDataManipulator.SaveFileDialogCustom("CSV files", "csv", "Save CSV", InstructorDataManipulator.ExportDataGridViewToCsv, dataGridViewAttendance);
                    break;
                case "Excel":
                    InstructorDataManipulator.SaveFileDialogCustom("Excel files(*.xlsx)", "xlsx", "Save Excel", InstructorDataManipulator.ExportDataToExcel, dataGridViewAttendance);
                    break;
            }

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            string outerXml = InstructorDataManipulator.DataGridViewToXml(dataGridViewAttendance);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(outerXml);
            doc.Save("C:\\Users\\Ahmad Esam El-Bastaw\\Desktop\\test.xml");
        }
    }
}
