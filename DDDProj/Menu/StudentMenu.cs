using DDDProj.Users;
using DDDProj.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DDDProj.Menu;

// Used for login to the student menu.
internal class StudentMenu : ConsoleMenu
{
    MenuManager manager;

    public StudentMenu(MenuManager manager)
    {
        this.manager = manager;
    }


    public override void CreateMenu()
    {
        Console.Clear();

        Student? loggedInStudent = new("Null", "Null", "Null", "Null");
        bool validEmail = false;
        string[] students = Directory.GetFiles("Users\\Students");
        for (int i = 0; i < students.Length; i++)
        {
            string studentTrimmed = Path.GetFileNameWithoutExtension(students[i]);
            students[i] = studentTrimmed;
        }

        while (validEmail == false)
        {
            Console.WriteLine("Please enter your email address:\n ");
            string email = Console.ReadLine();
            foreach (string student in students)
            {
                if (student == email)
                {
                    validEmail = true;
                    loggedInStudent = (Student)JsonHelpers.Deserialise("Student", email);
                }
                else { continue; }
            }
            Console.Clear();
            if (validEmail == false)
            {
                Console.WriteLine("No account found with those credentials. Please try again\n");
            }
        }

        bool validPassword = false;
        while (validPassword == false)
        {
            Console.WriteLine("Please enter your password:\n ");
            string pw = Console.ReadLine();
            if (pw == loggedInStudent.password)
            {
                validPassword = true;
            }
            Console.Clear();
            if (validPassword == false)
            {
                Console.WriteLine("Incorrect password. Please try again\n");
            }
        }

        Console.Clear();

        Console.WriteLine($"Welcome {loggedInStudent.name}!\n");
        menuItems.Add(new StatusMenu(manager, loggedInStudent));
        // menuItems.Add(new MeetingsMenu(manager));
        // menuItems.Add(ExitMenuItem(this, manager));
    }

    public override string MenuText()
    {
        return "Student Login";
    }
}
