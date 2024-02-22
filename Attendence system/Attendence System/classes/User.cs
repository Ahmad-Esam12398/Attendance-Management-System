using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attendence_system.classes
{
    public class SystemUser
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string role { get; set; }

        public override string ToString()
        {
            return $"{id} : {Name} : {Email} : {PhoneNumber} : {Password} : {role} ";
        }


    }
}
