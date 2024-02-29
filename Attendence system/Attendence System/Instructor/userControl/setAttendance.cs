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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex != -1)
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
            //string dummyDataPath = Path.Combine(Application.StartupPath, @"../../../../../Xml/dummyData.xml");
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
            int dateCounts = node.SelectNodes("attendanceDates").Count;
            string[,] target = new string[dateCounts, 7];
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
                attendanceDates = node.SelectNodes("attendanceDates");
            }
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

        private void dateTimePickerTo_ValueChanged_1(object sender, EventArgs e)
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExportPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialogCustom("PDF files (*.pdf)", "pdf", "Save PDF", GeneratePdfFromDataGridView);
        }
        public void GeneratePdfFromDataGridView(DataGridView dataGridView, string outputPath)
        {
            // Initialize a new PDF writer
            PdfWriter writer = new PdfWriter(outputPath);

            // Initialize a new PDF document
            PdfDocument pdf = new PdfDocument(writer);

            // Initialize a new document
            Document document = new Document(pdf);

            // Create a new table with the same number of columns as the data grid view
            Table table = new Table(dataGridView.ColumnCount);

            // Add the headers to the table
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                table.AddCell(new Cell().Add(new Paragraph(column.HeaderText)));
            }

            // Add the rows to the table
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Index == dataGridView.Rows.Count - 1)
                {
                    break;
                }
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == 6)
                        table.AddCell(new Cell().Add(new Paragraph(cell.Value.ToString() == "True" ? "Absent" : "Present")));
                    else if (cell.ColumnIndex == 5)
                        table.AddCell(new Cell().Add(new Paragraph(Convert.ToDateTime(cell.Value).ToString("dd-MM-yyyy"))));
                    else
                        table.AddCell(new Cell().Add(new Paragraph(cell.Value.ToString())));
                }
            }

            // Add the table to the document
            document.Add(table);

            // Close the document
            document.Close();
        }

        private void buttonExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialogCustom("Excel files(*.xlsx)", "xlsx", "Save Excel", ExportDataToExcel);
        }
        public void ExportDataGridViewToExcel(DataGridView dgv)
        {
            // Create a new Excel application
            Excel.Application excel = new Excel.Application();

            // Add a new workbook
            Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = null;

            try
            {
                // Use the first sheet
                worksheet = (Excel.Worksheet)workbook.ActiveSheet;

                // Write the header
                for (int i = 1; i < dgv.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                }

                // Write the data
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Save the workbook
                workbook.SaveAs("output.xsl");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Clean up
                excel.Quit();
                if (workbook != null) { Marshal.ReleaseComObject(workbook); }
                if (worksheet != null) { Marshal.ReleaseComObject(worksheet); }
                Marshal.ReleaseComObject(excel);
            }
        }
        public void ExportDataToExcel(DataGridView dataGridView, string fileName)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (ExcelPackage pck = new ExcelPackage())
            {
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Sheet1");
                ws.Cells["A1"].LoadFromDataTable((DataTable)dataGridView.DataSource, true);
                ws.Column(6).Style.Numberformat.Format = "dd-MM-yyyy";
                for (int row = 2; row <= ws.Dimension.End.Row; row++)
                {
                    if (ws.Cells[row, 7].Value.ToString().ToLower() == "true")
                    {
                        ws.Cells[row, 7].Value = "Absent";
                    }
                    else
                    {
                        ws.Cells[row, 7].Value = "Present";
                    }
                }
                using (var stream = File.Create(fileName))
                {
                    pck.SaveAs(stream);
                }
            }
        }
        public void ExportDataGridViewToCsv(DataGridView dgv, string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                // Write column headers
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    writer.Write(dgv.Columns[i].HeaderText);
                    if (i < dgv.Columns.Count - 1)
                    {
                        writer.Write(",");
                    }
                }
                writer.WriteLine();

                // Write rows
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if(row.Index == dgv.Rows.Count - 1)
                    {
                        break;
                    }
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (i == 5)
                            writer.Write(Convert.ToDateTime(row.Cells[i].Value).ToString("dd-MM-yyyy"));
                        else if (i == 6)
                            writer.Write(row.Cells[i].Value.ToString() == "True" ? "Absent" : "Present");
                        else
                            writer.Write(row.Cells[i].Value);
                        if (i < row.Cells.Count - 1)
                        {
                            writer.Write(",");
                        }
                    }
                    writer.WriteLine();
                }
            }
        }

        private void buttonExportCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialogCustom("CSV files", "csv", "Save CSV", ExportDataGridViewToCsv);
        }
        private void SaveFileDialogCustom(string typo, string extension, string title, Action<DataGridView, string> execute)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = typo + "|*."+ extension;
            saveFileDialog.Title = title;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string outputPath = saveFileDialog.FileName;
                    execute(dataGridViewAttendance, outputPath);
                    MessageBox.Show("File has been saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
