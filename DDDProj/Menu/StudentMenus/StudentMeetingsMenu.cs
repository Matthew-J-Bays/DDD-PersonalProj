using DDDProj.Helpers;
using DDDProj.Users;
using System;

namespace DDDProj.Menu.StudentMenus;

internal class StudentMeetingsMenu : ConsoleMenu
{
    private MenuManager manager;
    private Student student;

    public StudentMeetingsMenu(MenuManager manager, Student pStudent)
    {
        this.manager = manager;
        student = pStudent;
    }

    public override void CreateMenu()
    {
        Console.Clear();
        menuItems.Clear();

        menuItems.Add(new StudentArrangeMeetingsMenuItem(this, manager, student));
        // menuItems.Add(new ViewActiveMeetingsMenuItem(this, manager, student))
        // menuItems.Add(new ViewPriorMeetingsMenuItem(this, manager, student))
    }

    public override string MenuText()
    {
        return "Meetings";
    }


}