using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDProj.Helpers;
using DDDProj.Users;

namespace DDDProj.Menu.StartMenu
{
    public class StudentSignUpMenuItem : MenuItem
    {
        ConsoleMenu parent;
        MenuManager menuManager;
        public StudentSignUpMenuItem(ConsoleMenu pParent, MenuManager pManager)
        {
            parent = pParent;
            menuManager = pManager;
        }
        public override string MenuText()
        {
            return "- Student";
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

            bool validSup = false;
            string[] supervisors = Directory.GetFiles("Users\\Personal Supervisors");
            string sup = "NotAssigned";
            while (validSup = false)
            {
                Console.WriteLine("Please enter your supervisor's email address:");
                sup = Console.ReadLine();
                foreach (string supervisor in supervisors)
                {
                    if (sup == supervisor)
                    {
                        validSup = true;
                    }
                    else { continue; }
                }
                Console.Clear();
                if (validSup == false)
                {
                    Console.WriteLine("No valid supervisor found. Please try again\n");
                }
            }


            Student student = new Student(name, email, pw, sup);
            JsonHelpers.SerialiseStudent(student);

            parent.IsActive = false;
        }
    }
}
