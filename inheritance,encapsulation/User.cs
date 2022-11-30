using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace inheritance_encapsulation
{
    internal class User
    {
        private string _username;
        private string _password;

        public string Username 
        {
            get 
            {
                return _username;
            }
            set
            {
                if (value.Length>6)
                {
                    _username=value;
                }
                else
                {
                    Console.WriteLine("Zehmet olmasa yeniden cehd edin");
                }
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                Regex regex = new Regex(@"[A-Z]");
                Match match = regex.Match(value);
                    if (match.Success==true)
                    {
                        _password=value;
                    }
                    else
                    {
                        Console.WriteLine("Zehmet olmasa yeniden cehd edin");
                    }
            }
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
