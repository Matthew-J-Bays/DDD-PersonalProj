using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDProj.Helpers;

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
            
        }

        public override string MenuText()
        {
            return "Login";
        }

    }
}
