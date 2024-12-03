using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDProj.Users
{
    public class PersonalSupervisor : User
    {
        List<Student> students { get; set; }
        public PersonalSupervisor(string name, string email, string password) : base(name, email, password, "Personal Supervisor")
        {
        }
    }
}
