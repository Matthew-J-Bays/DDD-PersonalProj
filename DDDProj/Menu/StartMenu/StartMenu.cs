using DDDProj.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDProj.Menu.StartMenu
{
    public class StartMenu : ConsoleMenu
    {
        private MenuManager manager;
        
        public StartMenu(MenuManager pManager) { manager = pManager; }

        public override void CreateMenu()
        {
            menuItems.Clear();
            if (manager.Name == null)
            {
                Console.WriteLine("Supervisor management system\n");
                menuItems.Add(new LoginMenu(manager));
                menuItems.Add(new SignUpMenu(manager));
            }
            else
            {
                Console.WriteLine($"{manager.Name}");
                //menuItems.Add(new (manager));
            }
            menuItems.Add(new ExitMenuItem(this));
        }

        public override string MenuText()
        {
            return "";
        }

    }
}
