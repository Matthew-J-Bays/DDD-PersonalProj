using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDProj.Menu
{
    class ExitMenuItem : MenuItem
    {
        private ConsoleMenu _menu;
        public ExitMenuItem(ConsoleMenu parentItem)
        {
            _menu = parentItem;
        }

        public override string MenuText()
        {
            return "Exit";
        }

        public override void SelectMenu()
        {
            _menu.IsActive = false;
        }
    }
}
