using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;


namespace attendence_system.classes
{
    internal class Validation
    {
        static string path = "H:\\ITI-9\\AttendanceProject\\new-attendance-project-repo\\Xml\\usersAuthentication.xml";

        public static List<SystemUser> GetUsers()
        {

            List<SystemUser> users = new List<SystemUser>();
            XDocument dataFile = XDocument.Load(path);
            users = (from user in dataFile.Root.Elements("user")

                     select new SystemUser
                     {
                         id = (int)user.Element("id"),
                         Name = (string)user.Element("name"),
                         Email = (string)user.Element("email"),
                         PhoneNumber = "010200222",
                         Password = (string)user.Element("password"),
                         role = (string)user.Element("role")
                     }
                     ).ToList();
            return users;
        }
        public static bool IsValidName(string name)
        {
            if (name.Length < 3 || name.Length > 40) return false;
            else return true;

            /*var regex = new Regex(@"^[a-zA-Z]{3,}(?:\s[a-zA-Z]{3,})*$");

            return regex.IsMatch(name);*/
        }
        public static bool IsValidEmail(string email)
        {

            var regex = new Regex(@"^[a-zA-Z0-9]{1}[a-zA-Z0-9._-]{1,18}[a-zA-Z0-9]{1}@(gmail\.com|yahoo\.com)$");

            return regex.IsMatch(email);
        }
        public static bool IsValidPassword(string password)
        {
           if (password.Length < 8 || password.Length > 20)
            {
                return false;
            }
            else
            {
                return true;
            }

           /* var regex = new Regex(@"^(?=.[0-9])(?=.[a-zA-Z])(?=.*[#@$%]).{8,20}$");

            return regex.IsMatch(password);*/
        }

        public static int GetLastUserId()
        {
            int lastId = 0;
            XDocument dataFile = XDocument.Load(path);

            // Select the last <user> element in the document
            XElement lastUserElement = dataFile.Root.Elements("user").LastOrDefault();

            if (lastUserElement != null)
            {
                // Get the value of the <id> element within the last <user> element
                XElement idElement = lastUserElement.Element("id");

                if (idElement != null && int.TryParse(idElement.Value, out lastId))
                {
                    // Return the ID of the last user
                    return lastId;
                }
            }

            // If no user found or ID parsing fails, return 0
            return lastId;
        }

    }
}
