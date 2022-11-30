using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_encapsulation
{
    internal class Admin:User
    {
        public bool IsSuperAdmin;
        public string Section;

        public Admin(string username, string password, bool issuperadmin, string section):base(username, password)
        {
            IsSuperAdmin = issuperadmin;
            Section = section;
        }
        public void AllData()
        {
            Console.WriteLine(Username);
            Console.WriteLine(Password);
            Console.WriteLine(IsSuperAdmin);
            Console.WriteLine(Section);
        }
    }
}
