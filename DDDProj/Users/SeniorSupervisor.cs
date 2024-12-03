using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDProj.Users
{
    public class SeniorSupervisor : User
    {
        public SeniorSupervisor(string name, string email, string password) : base(name, email, password, "Senior Supervisor")
        {
        }
    }
}
