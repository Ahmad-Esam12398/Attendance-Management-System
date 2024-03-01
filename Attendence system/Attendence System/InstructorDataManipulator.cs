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
using System.Xml.Xsl;
namespace attendence_system
{
    public static class InstructorDataManipulator
    {
        static string path = @"./../../../Xml";
        static string userData = "usersAuthentication.xml";
        //static string testUser = "userAuthenticationTester.xml";
        static string usersSchema = "usersAuthenticationSchema.xsd";
        static string classSchema = "ClassesSchema.xsd";
        static string attendanceXslt = path + "/" + "ExportToHtml.xslt";
        static string classData = "ClassesData.xml";
        static public XmlDocument classesData = new();
        static public XmlDocument usersData = new();
        //static private XmlDocument testUserDoc = new();
        static private XmlSchemaSet usersSchemaSet = new();
        static private XmlSchemaSet classSchemaSet = new();
        static private XmlReaderSettings XmlReaderUsersSettings = new();
        static private XmlReaderSettings XmlReaderClassesSettings = new();
        static private XmlNode userNode;
        // This field represents a dictionary that maps class names to their corresponding IDs.
        static private Dictionary<string, string> classIdByName = new Dictionary<string, string>();
        //Id field of User
        static private string id = "-1";
        static private string dateCustomizer;
        static InstructorDataManipulator()
        {
            //testUserDoc.Load(path + "/" + testUser);
            usersData.Load(path + "/" + userData);
            usersSchemaSet.Add("", XmlReader.Create(new StreamReader(path + "/" + usersSchema)));
            // class
            classSchemaSet.Add("", XmlReader.Create(new StreamReader(path + "/" + classSchema)));

            XmlReaderUsersSettings.Schemas = usersSchemaSet;
            XmlReaderUsersSettings.ValidationType = ValidationType.Schema;
            //classIdByName.Add("L1", "1"); //Should be Removed
        }
        static public void SetDateCustomizer(string date)
        {
            dateCustomizer = date;
        }
        static public void setId(string _id)
        {
            id = _id;
        }
        // get count student
        static public int GetCountStudents()
        {
            int studentsCount = usersData.SelectNodes("/users/user[role='student']").Count;
            return studentsCount;
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
        static public XmlDocument GetUsersData()
        {
            return usersData;
        }
        static public HashSet<string> GetClassesForInstructor(XmlNode node)
        {
            HashSet<string> classes = new HashSet<string>();
            string id = node.SelectSingleNode("id").InnerText;
            XmlNodeList classNodes = usersData.SelectNodes($"/users/user[id='{id}']/class");
            foreach (XmlNode classNode in classNodes)
            {
                classes.Add(classNode.InnerText);
            }
            return classes;
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







        public static bool validateClassesData(XmlNode underTest)
        {

            XmlNode classesNode = classesData.SelectSingleNode("/classes");
            XmlNode importedNode = classesData.ImportNode(underTest, true);

            // Determine whether to add or replace based on the presence of existing data
            XmlNode existingNode = classesNode.SelectSingleNode($"class[id='{underTest.SelectSingleNode("id").InnerText}']");
            // Assume classesData is the XmlDocument containing the classes


            if (existingNode != null)
            {
                // If the class already exists, replace it
                classesNode.ReplaceChild(importedNode, existingNode);
            }
            else
            {
                // If the class doesn't exist, append it
                classesNode.AppendChild(importedNode);
            }
            XmlReader reader = XmlReader.Create(new StringReader(classesData.OuterXml), XmlReaderClassesSettings);
            try
            {
                while (reader.Read()) { }
                classesData.Load(path + "/" + classData);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                classesData.Load(path + "/" + classData);
                return false;
            }


        }

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
            }

            oneWillBeAppended.SelectSingleNode("gender").InnerText = newOne.SelectSingleNode("gender").InnerText;
       
            // Replace the existing user node with the updated user node
            usersData.SelectSingleNode("/users").ReplaceChild(oneWillBeAppended, GetUserNode(id));
            SaveChangesInFile();
        }


        // get all Classes From class xml 
        static public XmlDocument GetAllClasses()
        {
            return classesData;
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
        static public List<XmlNode> GetinstructorList()
        {
            int instructorCount = usersData.SelectNodes("/users/user[role='instructor']").Count;
            List<XmlNode> instructor = new List<XmlNode>();
            for (int i = 0; i < instructorCount; i++)
            {
                instructor.Add(usersData.SelectNodes("/users/user[role='instructor']")[i]);
            }
            return instructor;
        }



        // get all classes  from class.xml 
        static public List<XmlNode> GetClassessList()
        {
            int classesCount = classesData.SelectNodes("/classes/class").Count;
            List<XmlNode> classes = new List<XmlNode>();
            for (int i = 0; i < classesCount; i++)
            {
                classes.Add(classesData.SelectNodes("/classes/class")[i]);
            }
            return classes;
        }

        // Function to retrieve the last ID in usersAuthentication.xml
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


        // Function to retrieve the last ID in classes.xml

        public static int GetLastClassId()
        {
            int lastId = 0;

            // Select all "class" nodes
            XmlNodeList classNodes = classesData.SelectNodes("//class/id");

            if (classNodes != null && classNodes.Count > 0)
            {
                // Iterate through all class nodes to find the last ID
                foreach (XmlNode classIdNode in classNodes)
                {
                    // Parse the ID value to an integer
                    if (int.TryParse(classIdNode.InnerText, out int id))
                    {
                        // Update lastId if the current ID is greater
                        lastId = Math.Max(lastId, id);
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
            usersData.Save(path + "/" + userData);
            userNode = GetUserNode();
        }
        // Add New Class
        static public void AddNewClass(XmlNode newClass)
        {
            XmlNode root = classesData.SelectSingleNode("/classes");
            XmlNode importedUser = classesData.ImportNode(newClass, true);
            root.AppendChild(importedUser);
            SaveChangesClassesInFile();
        }
        //========== save changes in classes  
        static public void SaveChangesClassesInFile()
        {
            classesData.Save(@"./../../../Xml/ClassesTester.xml");
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


  




        public static bool IsClassCapacityAvailable(string className)
        {
            // Find the class with the specified name
            XmlNode classNode = classesData.SelectSingleNode($"/classes/class[name='{className}']");

            if (classNode != null)
            {
                int maxUsers = int.Parse(classNode.SelectSingleNode("max").InnerText);
                int currentUsers = usersData.SelectNodes($"/users/user[class='{className}']").Count;

                // Check if adding a new user exceeds the maximum limit
                return currentUsers < maxUsers;
            }

            // Return false if the class is not found or if an error occurred
            return false;
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
                        table.AddCell(new Cell().Add(new Paragraph(cell.Value.ToString() == "True" ? "Present" : "Absent")));
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
        public static string DataGridViewToXml(DataGridView dgv)
        {
            var xmlDocument = new XmlDocument();
            var xmlDeclaration = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmlDocument.AppendChild(xmlDeclaration);

            var root = xmlDocument.CreateElement("students");
            xmlDocument.AppendChild(root);

            foreach (DataGridViewRow row in dgv.Rows)
            {
                var xmlElement = xmlDocument.CreateElement("student");
                foreach (DataGridViewCell cell in row.Cells)
                {
                    var element = xmlDocument.CreateElement(cell.OwningColumn.HeaderText);
                    if(cell.OwningColumn.HeaderText == "Date")
                        element.InnerText = Convert.ToDateTime(cell.Value).ToString("dd-MM-yyyy");
                    else if(cell.OwningColumn.HeaderText == "Status")
                        element.InnerText = cell.Value.ToString() == "True" ? "Present" : "Absent";
                    else
                        element.InnerText = cell.Value.ToString();
                    xmlElement.AppendChild(element);
                }
                root.AppendChild(xmlElement);
            }
            return xmlDocument.OuterXml;
        }
        public static void ExportFromDataGridToHtml(DataGridView dataGridView, string outputPath)
        {
            string xml = DataGridViewToXml(dataGridView);
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(attendanceXslt);
            using (var writer = XmlWriter.Create(outputPath))
            {
                xslt.Transform(XmlReader.Create(new StringReader(xml)), writer);
            }
        }
        static public XmlNode GetClassNode(string id)
        {
            XmlNode target = classesData.SelectSingleNode($"/classes/class[id='{id}']");
            return target;
        }
        static public void UpdateClassData(XmlNode newOne)
        {
            string id = newOne.SelectSingleNode("id").InnerText;
            XmlNode oneWillBeAppended = classesData.ImportNode(GetClassNode(id), true);
            oneWillBeAppended.SelectSingleNode("name").InnerText = newOne.SelectSingleNode("name").InnerText;
            oneWillBeAppended.SelectSingleNode("max").InnerText = newOne.SelectSingleNode("max").InnerText;

            // Replace the existing user node with the updated user node
            classesData.SelectSingleNode("/classes").ReplaceChild(oneWillBeAppended, GetClassNode(id));
            SaveChangesClassesInFile();
        }
        static public bool CheckUsersInClass(string className)
        {
            XmlNodeList userNodes = usersData.SelectNodes("//user");
            foreach (XmlNode userNode in userNodes)
            {
                XmlNode classNode = userNode.SelectSingleNode("class");
                if (classNode != null && classNode.InnerText == className)
                {
                    return true;
                }
            }

            return false;
        }

    }
    //===============================================================================================
}
