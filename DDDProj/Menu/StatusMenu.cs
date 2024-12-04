using DDDProj.Helpers;
using DDDProj.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDProj.Menu
{
    public class StatusMenu : ConsoleMenu
    {
        MenuManager manager;
        Student student;

        public StatusMenu(MenuManager manager, Student student)
        {
            this.manager = manager;
            this.student = student;
        }

        public override void CreateMenu()
        {
            menuItems.Clear();
            menuItems.Add(new UpdateStatusMenuItem(this, manager, student));
        }

        public override string MenuText()
        {
            return "Status";
        }
    }
}
