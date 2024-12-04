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
        public struct Meeting
        {
            public string DateTime { get;  set; }
            public string Location { get; set; }
        }

        public Meeting ArrangeMeeting()
        {
            Console.WriteLine("Please input the meeting date (Written as 'XX.XX.XXXX'):");
            string date = Console.ReadLine();
            Console.WriteLine("\n Please input the meeting location:");
            string location = Console.ReadLine();


            Meeting meeting = new Meeting();
            meeting.DateTime = date;
            meeting.Location = location;
            return meeting;
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
