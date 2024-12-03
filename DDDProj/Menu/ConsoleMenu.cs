using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDProj.Helpers;

namespace DDDProj.Menu
{
    public abstract class ConsoleMenu : MenuItem
    {

        protected List<MenuItem> menuItems = new List<MenuItem>();

        public bool IsActive { get; set; }

        public abstract void CreateMenu();

        public override void SelectMenu()
        {
            IsActive = true;
            do
            {
                Console.Clear();
                CreateMenu();
                string output = $"{MenuText()}{Environment.NewLine}";
                int selection = UniversalHelpers.GetIntegerInRange(1, menuItems.Count, this.ToString()) - 1;
                menuItems[selection].SelectMenu();
            } while (IsActive);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(MenuText());
            for (int i = 0; i < menuItems.Count; i++)
            {
                sb.AppendLine($"{i + 1}. {menuItems[i].MenuText()}");
            }
            return sb.ToString();
        }
    }
}
