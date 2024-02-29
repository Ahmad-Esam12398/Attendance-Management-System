using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using attendence_system;
namespace attendence_system.Admin.userControl
{
    public partial class UserControlAddClass : UserControl
    {
        string ClsString = "";
        public UserControlAddClass()
        {
            InitializeComponent();
        }
        private void ClearText()
        {
            textBoxClassName.Clear();
            textBoxHMstudent.Clear();
            tabControlAddClass.SelectedTab = tabPageAddClass;
        }

        private void ClearText1()
        {
            textBoxClassName1.Clear();
            textBoxHMstudent1.Clear();
        }

        // ===============fun to add new class===============
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            if (textBoxClassName.Text == "" || textBoxHMstudent.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Create a new class node
                XmlDocument doc = new XmlDocument();
                XmlNode newClass = doc.CreateElement("class");

                XmlNode idNode = doc.CreateElement("id");

                idNode.InnerText = (InstructorDataManipulator.GetLastClassId() + 1).ToString();
                newClass.AppendChild(idNode);

                XmlNode nameNode = doc.CreateElement("name");
                nameNode.InnerText = textBoxClassName.Text.Trim();
                newClass.AppendChild(nameNode);

                XmlNode maxNode = doc.CreateElement("max");
                maxNode.InnerText = textBoxHMstudent.Text.Trim();
                newClass.AppendChild(maxNode);

                if (InstructorDataManipulator.validateClassesData(newClass))
                {

                    InstructorDataManipulator.AddNewClass(newClass);
                    MessageBox.Show("class Added successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

      
        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            // Check if SID is not empty and is a valid integer
            if (!string.IsNullOrEmpty(ClsString) && int.TryParse(ClsString, out int userId))
            {
            // Retrieve the existing user node from the data source
                XmlNode existingClassNode = InstructorDataManipulator.GetClassNode(userId.ToString());

                if (existingClassNode != null)
                {

                    existingClassNode.SelectSingleNode("name").InnerText = textBoxClassName1.Text.Trim();
                    existingClassNode.SelectSingleNode("max").InnerText = textBoxHMstudent1.Text.Trim();

                    if (InstructorDataManipulator.validateClassesData(existingClassNode))
                    {
                        InstructorDataManipulator.UpdateClassData(existingClassNode);
                        MessageBox.Show("Class updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row from the table.", "Select Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(ClsString))
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to delete this Class?", "Delete Class", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)

                {
                    DeleteClass(ClsString);
                }
            }
            else
            {
                MessageBox.Show("Please select a row from the table.", "Select Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        // ======================= Delete Specific Class =======================
        private void DeleteClass(string id)
        {
            // Get the class node by ID
            XmlNode classNodeToDelete = InstructorDataManipulator.GetClassNode(id);

            // Check if the class node exists
            if (classNodeToDelete != null)
            {

                XmlNode parentNode = classNodeToDelete.ParentNode;

                parentNode.RemoveChild(classNodeToDelete);

                InstructorDataManipulator.SaveChangesClassesInFile();

                MessageBox.Show("Class deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText1();


            }

        }

        private void tabPageUpdateAndDelete_Leave(object sender, EventArgs e)
        {
            ClearText1();
        }

        private void tabControlAddClass_Leave(object sender, EventArgs e)
        {
            textBoxSearchClass.Clear();

        }

        private void tabPageAddClass_Click(object sender, EventArgs e)
        {

        }

        private void tabPageSearchClass_Enter(object sender, EventArgs e)
        {
            textBoxSearchClass.Clear();
            // Call the function to get the student data
            DataTable classesData = GetClassesDataTable();
            // Assuming dataGridViewStudent is your DataGridView control
            dataGridViewClass.DataSource = classesData;
            labelTotalClasses.Text = dataGridViewClass.Rows.Count.ToString();
        }
        public static DataTable GetClassesDataTable()
        {
            // Create a new DataTable
            DataTable table = new DataTable();

            // Add columns to the DataTable
            table.Columns.Add("id", typeof(string));
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("max", typeof(string));

            // Load XML from file
            XmlDocument doc = InstructorDataManipulator.GetAllClasses();

            // Loop through each <class> node
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                DataRow row = table.NewRow();
                row["id"] = node.SelectSingleNode("id").InnerText;
                row["name"] = node.SelectSingleNode("name").InnerText;
                row["max"] = node.SelectSingleNode("max").InnerText;
                table.Rows.Add(row);
            }

            return table;
        }

        private void textBoxSearchClass_TextChanged(object sender, EventArgs e)
        {

            string searchText = textBoxSearchClass.Text.Trim().ToLower(); // Convert search text to lowercase for case-insensitive search
            List<XmlNode> allClasses = InstructorDataManipulator.GetClassessList();

            // Filter students whose names contain the search text
            List<XmlNode> filteredClasses = allClasses.Where(classs => classs.SelectSingleNode("name")?.InnerText.ToLower().Contains(searchText) ?? false).ToList();

            dataGridViewClass.DataSource = ConvertXmlNodeListToDataTable(filteredClasses);
            labelTotalClasses.Text = filteredClasses.Count.ToString();
        }
        // Method to convert XmlNodeList to DataTable
        private DataTable ConvertXmlNodeListToDataTable(List<XmlNode> nodeList)
        {
            DataTable dataTable = new DataTable();
            // Add columns
            dataTable.Columns.Add("id", typeof(string));
            dataTable.Columns.Add("name", typeof(string));
            dataTable.Columns.Add("max", typeof(string));
            // Add rows
            foreach (XmlNode node in nodeList)
            {
                DataRow row = dataTable.NewRow();
                row["id"] = node.SelectSingleNode("id").InnerText;
                row["name"] = node.SelectSingleNode("name").InnerText;
                row["max"] = node.SelectSingleNode("max").InnerText;
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        private void dataGridViewClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewClass.Rows[e.RowIndex];
            ClsString = row.Cells["Column1"].Value.ToString(); // Assuming Cls is a string
            int CLI;
            if (int.TryParse(ClsString, out CLI))
            {
                textBoxClassName1.Text = row.Cells["Column2"].Value.ToString();
                textBoxHMstudent1.Text = row.Cells["Column3"].Value.ToString();
            }
        }
        // get specified class 




    }
}
