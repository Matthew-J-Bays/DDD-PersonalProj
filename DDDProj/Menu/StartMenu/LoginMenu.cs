using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDProj.Helpers;
using DDDProj.Menu.StudentMenus;

namespace DDDProj.Menu.StartMenu
{
    public class LoginMenu : ConsoleMenu
    {
        MenuManager manager;

        public LoginMenu(MenuManager pManager)
        {
            manager = pManager;
        }

        public override void CreateMenu()
        {
            menuItems.Clear();
            menuItems.Add(new StudentMenu(manager));
        }

        public override string MenuText()
        {
            return "Login";
        }

    }
}
