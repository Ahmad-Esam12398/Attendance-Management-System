using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml;
using attendence_system.Instructor;
using OfficeOpenXml;
using System.Data;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using System.Reflection.Metadata;
using iText.Layout;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using Document = iText.Layout.Document;

namespace attendence_system
{
    public static class InstructorDataManipulator
    {
        static string path = @"./../../../../../Xml";
        static string userData = "usersAuthenticationC#.xml";
        static string testUser = "userAuthenticationTester.xml";
        static string usersSchema = "usersAuthenticationSchema.xsd";
        static public XmlDocument usersData = new();
        static private XmlDocument testUserDoc = new();
        static private XmlSchemaSet usersSchemaSet = new();
        static private XmlReaderSettings XmlReaderUsersSettings = new();
        static private XmlNode userNode;
        // This field represents a dictionary that maps class names to their corresponding IDs.
        static private Dictionary<string, string> classIdByName = new Dictionary<string, string>();
        //Id field of User
        static private string id = "-1";

        static InstructorDataManipulator()
        {
            usersData.Load(path + "/" + userData);
            testUserDoc.Load(path + "/" + testUser);
            usersSchemaSet.Add("", XmlReader.Create(new StreamReader(path + "/" + usersSchema)));
            XmlReaderUsersSettings.Schemas = usersSchemaSet;
            XmlReaderUsersSettings.ValidationType = ValidationType.Schema;
            classIdByName.Add("L1", "1"); //Should be Removed
            id = "1";
        }
        static public void setId(string _id)
        {
            id = _id;
        }
        static public XmlNode GetUserNode()
        {
            userNode = usersData.SelectSingleNode($"/users/user[id='{id}']");
            XmlNode duplicate = userNode.CloneNode(true);
            return duplicate;
        }
        static public XmlNode GetUserNode(string _id)
        {
            XmlNode target = usersData.SelectSingleNode($"/users/user[id='{_id}']");
            return target;
        }

        public static bool validateUserData(XmlNode underTest, bool update = false)
        {
            XmlNode rootNode = usersData.SelectSingleNode("/users");
            XmlNode importedNode = usersData.ImportNode(underTest, true);
            //XmlNode nameNode = importedNode.SelectSingleNode("name");
            //XmlNode emailNode = importedNode.SelectSingleNode("email");
            //XmlNode phoneNode = importedNode.SelectSingleNode("phone");
            if (update)
            {
                rootNode.ReplaceChild(importedNode, GetUserNode(underTest.SelectSingleNode("id").InnerText));
            }
            else
            {
                rootNode.AppendChild(importedNode);
            }  
            XmlReader reader = XmlReader.Create(new StringReader(usersData.OuterXml), XmlReaderUsersSettings);
            try
            {
                while (reader.Read()) { }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                usersData.Load(path + "/" + userData);
            }
        }
        /*   static public void UpdateUserData(XmlNode newOne)
           {

               string id = newOne.SelectSingleNode("id").InnerText;
               XmlNode oneWillBeAppended = usersData.ImportNode(GetUserNode(id), true);
               oneWillBeAppended.SelectSingleNode("name").InnerText = newOne.SelectSingleNode("name").InnerText;
               oneWillBeAppended.SelectSingleNode("email").InnerText = newOne.SelectSingleNode("email").InnerText;
               oneWillBeAppended.SelectSingleNode("phone").InnerText = newOne.SelectSingleNode("phone").InnerText;
               oneWillBeAppended.SelectSingleNode("password").InnerText = newOne.SelectSingleNode("password").InnerText;
               //oneWillBeAppended.SelectSingleNode("role").InnerText = newOne.SelectSingleNode("role").InnerText;
                if (newOne.SelectSingleNode("class") != null)
                {
                 oneWillBeAppended.SelectSingleNode("class").InnerText = newOne.SelectSingleNode("class").InnerText;
                 oneWillBeAppended.SelectSingleNode("class").Attributes["id"].Value = newOne.SelectSingleNode("class").Attributes["id"].Value;
                }
               oneWillBeAppended.SelectSingleNode("gender").InnerText = newOne.SelectSingleNode("gender").InnerText;

               //if(newOne.SelectNodes("attendanceDates").Count != 0)
               //{
               //    for (int i = 0; i < oneWillBeAppended.SelectNodes("attendanceDates").Count; i++)
               //    {
               //        oneWillBeAppended.SelectNodes("attendanceDates")[i].ParentNode.RemoveChild(oneWillBeAppended.SelectNodes("attendanceDates")[i]);
               //    }
               //    for (int i = 0; i < newOne.SelectNodes("attendanceDates").Count; i++)
               //    {
               //        XmlNode importedNode = usersData.ImportNode(newOne.SelectNodes("attendanceDates")[i], true);
               //        oneWillBeAppended.AppendChild(importedNode);
               //    }
               //}

               usersData.SelectSingleNode("/users").ReplaceChild(oneWillBeAppended, userNode);
               SaveChangesInFile();
           }*/


        static public void UpdateUserData(XmlNode newOne)
        {
            string id = newOne.SelectSingleNode("id").InnerText;
            XmlNode oneWillBeAppended = usersData.ImportNode(GetUserNode(id), true);
            oneWillBeAppended.SelectSingleNode("name").InnerText = newOne.SelectSingleNode("name").InnerText;
            oneWillBeAppended.SelectSingleNode("email").InnerText = newOne.SelectSingleNode("email").InnerText;
            oneWillBeAppended.SelectSingleNode("phone").InnerText = newOne.SelectSingleNode("phone").InnerText;
            oneWillBeAppended.SelectSingleNode("password").InnerText = newOne.SelectSingleNode("password").InnerText;

            if (newOne.SelectSingleNode("class") != null)
            {
                oneWillBeAppended.SelectSingleNode("class").InnerText = newOne.SelectSingleNode("class").InnerText;
                oneWillBeAppended.SelectSingleNode("class").Attributes["id"].Value = newOne.SelectSingleNode("class").Attributes["id"].Value;
            }

            oneWillBeAppended.SelectSingleNode("gender").InnerText = newOne.SelectSingleNode("gender").InnerText;
       
            // Replace the existing user node with the updated user node
            usersData.SelectSingleNode("/users").ReplaceChild(oneWillBeAppended, GetUserNode(id));
            SaveChangesInFile();
        }
        static public XmlDocument GetUsersData()
        {
            return usersData;
        }
        static public List<XmlNode> GetStudentsList() { 
            int studentsCount = usersData.SelectNodes("/users/user[role='student']").Count;
            List<XmlNode> students = new List<XmlNode>();
            for(int i = 0; i < studentsCount; i++)
            {
                students.Add(usersData.SelectNodes("/users/user[role='student']")[i]);
            }
            return students;
        }
        // get count student
        static public int GetCountStudents()
        {
            int studentsCount = usersData.SelectNodes("/users/user[role='student']").Count;
            return studentsCount;
        }

        // Function to retrieve the last ID in usersAuthenticationC#.xml
        public static int GetLastUserId()
        {
            int lastId = 0;

            // Select all "user" nodes
            XmlNodeList userNodes = usersData.SelectNodes("//user");

            if (userNodes != null && userNodes.Count > 0)
            {
                // Iterate through all user nodes to find the last ID
                foreach (XmlNode userNode in userNodes)
                {
                    XmlNode idNode = userNode.SelectSingleNode("id");

                    if (idNode != null)
                    {
                        // Parse the ID value to an integer
                        if (int.TryParse(idNode.InnerText, out int id))
                        {
                            // Update lastId if the current ID is greater
                            lastId = Math.Max(lastId, id);
                        }
                    }
                }
            }

            return lastId;
        }

        static public HashSet<string> GetClassesSet()
        {
            List<XmlNode> Students = GetStudentsList();
            HashSet<string> classes = new HashSet<string>();
            for(int i = 0; i < Students.Count; i++)
            {
                classes.Add(Students[i].SelectSingleNode("class").InnerText);
            }
            return classes;
        }
        static public HashSet<string> GetClassesForInstructor(XmlNode instructorNode)
        {
            HashSet<string> result = new HashSet<string>();
            var classes = instructorNode.SelectNodes("class");
            foreach (XmlNode classNode in classes)
            {
                result.Add(classNode.InnerText);
            }
            return result;
        }
        // Add New User
        static public void AddNewUser(XmlNode newUser)
        {
            XmlNode root = usersData.SelectSingleNode("/users");
            XmlNode importedUser = usersData.ImportNode(newUser, true);
            root.AppendChild(importedUser);
            SaveChangesInFile();
        }
        static public void SaveChangesInFile()
        {
            usersData.Save(@"./../../../../../Xml/usersAuthenticationC#.xml");
            userNode = GetUserNode("1");
        }
       
        
        // This  method initializes the mapping between class names and their corresponding IDs.
        // 1. Retrieves a list of student nodes from the XML data.
        // 2. Clears any existing mappings in the classIdByName dictionary.
        // 3. Iterates through each student node and extracts the class name and ID.
        // 4. Checks if the class name already exists in the mapping. If not, adds the class name
        //    and its corresponding ID to the dictionary.
        //
        static public void InitializeClassIdMapping()
        {
            List<XmlNode> students = GetStudentsList();

            // Clear existing mappings
            classIdByName.Clear();

            foreach (XmlNode student in students)
            {
                XmlNode classNode = student.SelectSingleNode("class");
                if (classNode != null)
                {
                    string className = classNode.InnerText;
                    string classId = classNode.Attributes["id"].Value;

                    // Check if the class name already exists in the mapping
                    if (!classIdByName.ContainsKey(className))
                    {
                        classIdByName.Add(className, classId);
                    }
                }
            }
        }

        static public string GetClassIdByName(string className)
        {
            if (classIdByName.ContainsKey(className))
            {
                return classIdByName[className];
            }
            else
            {
                return null; 
            }
        }
        //======================================================= Methods For Exporting Data =======================================================

        static public void SaveFileDialogCustom(string typo, string extension, string title, Action<DataGridView, string> execute, DataGridView dataGridView)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = typo + "|*." + extension;
            saveFileDialog.Title = title;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string outputPath = saveFileDialog.FileName;
                    execute(dataGridView, outputPath);
                    MessageBox.Show("File has been saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
         static public void ExportDataGridViewToCsv(DataGridView dgv, string filename)
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
                    if (row.Index == dgv.Rows.Count - 1)
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
        static public void ExportDataToExcel(DataGridView dataGridView, string fileName)
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
        static public void GeneratePdfFromDataGridView(DataGridView dataGridView, string outputPath)
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


    }
    //===============================================================================================
}
