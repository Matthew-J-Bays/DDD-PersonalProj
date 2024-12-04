using DDDProj.Users;
using DDDProj.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DDDProj.Menu.StudentMenus;

// Used for login to the student menu.
internal class StudentMenu : ConsoleMenu
{
    MenuManager manager;
    Student loggedInStudent;
    public StudentMenu(MenuManager manager)
    {
        this.manager = manager;
        UniversalHelpers.loggedInUser = null;
        UniversalHelpers.loggedOn = false;
    }


    public override void CreateMenu()
    {
        Console.Clear();
        if (UniversalHelpers.loggedOn == false)
        {
            loggedInStudent = Login();
        }
        else
        {
            loggedInStudent = (Student)JsonHelpers.Deserialise("Student", UniversalHelpers.loggedInUser);
        }

        menuItems.Clear();
        Console.WriteLine($"Welcome {loggedInStudent.name}!\n");
        menuItems.Add(new StatusMenu(manager, loggedInStudent));
        menuItems.Add(new StudentMeetingsMenu(manager, loggedInStudent));
        menuItems.Add(new ExitMenuItem(this));
    }

    public override string MenuText()
    {
        return "Student Login";
    }



    public Student Login()
    {
        string email;
        Student loggedInStudent = new("null", "null", "null", "null");
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
            email = Console.ReadLine();
            foreach (string student in students)
            {
                if (student == email)
                {
                    validEmail = true;
                    Student temp = (Student)JsonHelpers.Deserialise("Student", email);

                    bool validPassword = false;
                    while (validPassword == false)
                    {
                        Console.WriteLine("Please enter your password:\n ");
                        string pw = Console.ReadLine();
                        if (pw == temp.password)
                        {
                            validPassword = true;
                            UniversalHelpers.loggedInUser = email;
                        }
                        Console.Clear();
                        if (validPassword == false)
                        {
                            Console.WriteLine("Incorrect password. Please try again\n");
                        }
                    }
                }
                else { continue; }
            }
            Console.Clear();
            if (validEmail == false)
            {
                Console.WriteLine("No account found with those credentials. Please try again\n");
            }
            UniversalHelpers.loggedOn = true;
        }
        return loggedInStudent;

    }
}
