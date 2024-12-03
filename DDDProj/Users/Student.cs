using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDProj.Users
{
    public class Student : User
    {
        string supervisor;
        public Student(string name, string email, string password, string supervisor) : base(name, email, password, "Student")
        {
            this.supervisor = supervisor;
        }
    }
}
