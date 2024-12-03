using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace DDDProj.Users
{
    public abstract class User
    {
        public string name { get; private set; }
        public string email { get; private set; }
        public string password { get; private set; }
        public string userType { get; private set; }

        // Did not use "p" in parameter names due to issues with Desirialization
        public User(string name, string email, string password, string userType)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.userType = userType;
        }

        public void Dump()
        {
            Console.WriteLine(name);
            Console.WriteLine(email);
            Console.WriteLine(password);
            Console.WriteLine(userType);
        }
    }
}
