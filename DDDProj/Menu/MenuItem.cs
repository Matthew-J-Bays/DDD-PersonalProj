using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDProj.Menu
{
    public abstract class MenuItem
    {
        public abstract void SelectMenu();
        public abstract string MenuText();
    }
}
