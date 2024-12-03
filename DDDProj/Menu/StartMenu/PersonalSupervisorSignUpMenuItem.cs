using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDProj.Helpers;
using DDDProj.Users;

namespace DDDProj.Menu.StartMenu
{
    public class PersonalSupervisorUpMenuItem : MenuItem
    {
        ConsoleMenu parent;
        MenuManager menuManager;
        public PersonalSupervisorUpMenuItem(ConsoleMenu pParent, MenuManager pManager)
        {
            parent = pParent;
            menuManager = pManager;
        }
        public override string MenuText()
        {
            return "- Personal Supervisor";
        }

        public override void SelectMenu()
        {
            Console.Clear();

            
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please enter your email:");
            string email = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please enter a password");
            string pw = Console.ReadLine();
            Console.Clear();
            
            PersonalSupervisor ps = new PersonalSupervisor(name, email, pw);
            JsonHelpers.SerialisePS(ps);

            parent.IsActive = false;
        }
    }
}
