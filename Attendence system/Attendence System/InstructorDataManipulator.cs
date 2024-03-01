using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml;
using attendence_system.Instructor;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace attendence_system
{
    public static class InstructorDataManipulator
    {
        static string path = @"./../../../../../Xml";
        static string userData = "usersAuthenticationC#.xml";
        static string testUser = "userAuthenticationTester.xml";
        static string usersSchema = "usersAuthenticationSchema.xsd";
        static string classSchema = "ClassesSchema.xsd";
        static string classData = "ClassesTester.xml";
        static public XmlDocument classesData = new();
        static public XmlDocument usersData = new();
        static private XmlDocument testUserDoc = new();
        static private XmlSchemaSet usersSchemaSet = new();
        static private XmlSchemaSet classSchemaSet = new();
        static private XmlReaderSettings XmlReaderUsersSettings = new();
        static private XmlReaderSettings XmlReaderClassesSettings = new();
        static private XmlNode userNode;
        // This field represents a dictionary that maps class names to their corresponding IDs.
        static private Dictionary<string, string> classIdByName = new Dictionary<string, string>();

        static InstructorDataManipulator()
        {
            usersData.Load(path + "/" + userData);
            testUserDoc.Load(path + "/" + testUser);
            usersSchemaSet.Add("", XmlReader.Create(new StreamReader(path + "/" + usersSchema)));
            // class
            classSchemaSet.Add("", XmlReader.Create(new StreamReader(path + "/" + classSchema)));

            XmlReaderUsersSettings.Schemas = usersSchemaSet;
            XmlReaderUsersSettings.ValidationType = ValidationType.Schema;
            //class
            XmlReaderClassesSettings.Schemas = classSchemaSet;
            XmlReaderClassesSettings.ValidationType= ValidationType.Schema;
            //class 
            classesData.Load(path + "/" + classData);
            userNode = GetUserNode("1");
            classIdByName.Add("L1", "1");

        }
        // get count student
        static public int GetCountStudents()
        {
            int studentsCount = usersData.SelectNodes("/users/user[role='student']").Count;
            return studentsCount;
        }

        static public XmlNode GetUserNode(string id)
        {
            XmlNode target = usersData.SelectSingleNode($"/users/user[id='{id}']");
            return target;
        }
        // get specified class 
        static public XmlNode GetClassNode(string id)
        {
            XmlNode target = classesData.SelectSingleNode($"/classes/class[id='{id}']");
            return target;
        }
        public static bool validateUserData(XmlNode underTest)
        {
            XmlNode rootNode = testUserDoc.SelectSingleNode("/users");
            XmlNode importedNode = testUserDoc.ImportNode(underTest, true);
            //XmlNode nameNode = importedNode.SelectSingleNode("name");
            //XmlNode emailNode = importedNode.SelectSingleNode("email");
            //XmlNode phoneNode = importedNode.SelectSingleNode("phone");
            rootNode.AppendChild(importedNode);
            XmlReader reader = XmlReader.Create(new StringReader(testUserDoc.OuterXml), XmlReaderUsersSettings);
            try
            {
                while (reader.Read()) { }
                testUserDoc.Load(path + "/" + testUser);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                testUserDoc.Load(path + "/" + testUser);
                return false;
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
        // update class 
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

        static public XmlNode GetUserNode()
        {
            XmlNode duplicate = userNode.CloneNode(true);
            return duplicate;
        }
        static public XmlDocument GetUsersData()
        {
            return usersData;
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
       /* static public HashSet<string> GetClassesSetV2()
        {
            XmlDocument Allclasses =classesData;
            HashSet<string> classes = new HashSet<string>();
            for (int i = 0; i < Students.Count; i++)
            {
                classes.Add(Students[i].SelectSingleNode("class").InnerText);
            }
            return classes;
        }*/

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
            classesData.Save(@"./../../../../../Xml/ClassesTester.xml");
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
}
