using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml;
using attendence_system.Instructor;

namespace attendence_system
{
    public static class InstructorDataManipulator
    {
        static string path = @"./../../../../../Xml";
        static string userData = "usersAuthenticationC#.xml";
        static string testUser = "userAuthenticationTester.xml";
        static string usersSchema = "usersAuthenticationSchema.xsd";
        static private XmlDocument usersData = new();
        static private XmlDocument testUserDoc = new();
        static private XmlSchemaSet usersSchemaSet = new();
        static private XmlReaderSettings XmlReaderUsersSettings = new();
        static private XmlNode userNode;
        static InstructorDataManipulator()
        {
            usersData.Load(path + "/" + userData);
            testUserDoc.Load(path + "/" + testUser);
            usersSchemaSet.Add("", XmlReader.Create(new StreamReader(path + "/" + usersSchema)));
            XmlReaderUsersSettings.Schemas = usersSchemaSet;
            XmlReaderUsersSettings.ValidationType = ValidationType.Schema;
            userNode = GetUserNode("1");
        }
        
        static public XmlNode GetUserNode(string id)
        {
            XmlNode target = usersData.SelectSingleNode($"/users/user[id='{id}']");
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
        static public void UpdateUserData(XmlNode newOne)
        {
            string id = newOne.SelectSingleNode("id").InnerText;
            XmlNode oneWillBeAppended = usersData.ImportNode(GetUserNode(id), true);
            oneWillBeAppended.SelectSingleNode("name").InnerText = newOne.SelectSingleNode("name").InnerText;
            oneWillBeAppended.SelectSingleNode("email").InnerText = newOne.SelectSingleNode("email").InnerText;
            oneWillBeAppended.SelectSingleNode("phone").InnerText = newOne.SelectSingleNode("phone").InnerText;
            oneWillBeAppended.SelectSingleNode("password").InnerText = newOne.SelectSingleNode("password").InnerText;
            //oneWillBeAppended.SelectSingleNode("role").InnerText = newOne.SelectSingleNode("role").InnerText;
            //if (newOne.SelectSingleNode("class") != null)
            //{
            //    oneWillBeAppended.SelectSingleNode("class").InnerText = newOne.SelectSingleNode("class").InnerText;
            //    oneWillBeAppended.SelectSingleNode("class").Attributes["id"].Value = newOne.SelectSingleNode("class").Attributes["id"].Value;
            //}
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
        static public List<XmlNode> GetStudentsList() { 
            int studentsCount = usersData.SelectNodes("/users/user[role='student']").Count;
            List<XmlNode> students = new List<XmlNode>();
            for(int i = 0; i < studentsCount; i++)
            {
                students.Add(usersData.SelectNodes("/users/user[role='student']")[i]);
            }
            return students;
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
        static public void SaveChangesInFile()
        {
            usersData.Save(@"./../../../../../Xml/usersAuthenticationC#.xml");
            userNode = GetUserNode("1");
        }
    }
}
