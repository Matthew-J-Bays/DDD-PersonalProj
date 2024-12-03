using DDDProj.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDProj.Menu.StartMenu
{
    public class SignUpMenu : ConsoleMenu
    {

        MenuManager manager;

        public SignUpMenu(MenuManager pManager)
        {
            manager = pManager;
        }
        public override void CreateMenu()
        {
            Console.WriteLine("Choose account type\n");
            menuItems.Add(new StudentSignUpMenuItem(this, manager));
            menuItems.Add(new PersonalSupervisorUpMenuItem(this, manager));
        }

        public override string MenuText()
        {
            return "Sign Up";
        }
    }
}
