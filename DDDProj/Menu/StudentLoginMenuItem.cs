using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDProj.Menu;

internal class StudentMenu : ConsoleMenu
{
    public override void CreateMenu()
    {
        Console.Clear();
        bool loop = false;
        while (loop == false)
        {
            Console.WriteLine("Please enter your email address:\n ");
            string email = Console.ReadLine();

        }
    }

    public override string MenuText()
    {
        return "- Student Login";
    }
}
