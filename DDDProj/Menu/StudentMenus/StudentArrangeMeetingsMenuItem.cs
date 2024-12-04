using DDDProj.Helpers;
using DDDProj.Users;
using DDDProj.Menu.StudentMenus;

namespace DDDProj.Menu.StudentMenus;

internal class StudentArrangeMeetingsMenuItem : MenuItem
{
   
    private MenuManager manager;
    private Student student;
    private ConsoleMenu parent;

    public StudentArrangeMeetingsMenuItem(ConsoleMenu pParent, MenuManager manager, Student student)
    {
        this.manager = manager;
        this.parent = pParent;
        this.student = student;
    }

    public override string MenuText()
    {
        return "Arrange Meeting";
    }

    public override void SelectMenu()
    {
        Console.Clear();
        student.activeMeetings.Add(student.ArrangeMeeting());
        parent.IsActive = false;
    }
}