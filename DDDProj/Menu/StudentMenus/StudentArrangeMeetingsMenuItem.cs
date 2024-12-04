using DDDProj.Helpers;
using DDDProj.Users;
using DDDProj.Menu.StudentMenus;

namespace DDDProj.Menu.StudentMenus;

internal class StudentArrangeMeetingsMenuItem : MenuItem
{
   
    private MenuManager manager;
    private Student student;
    private Menu.ConsoleMenu parent;

    public StudentArrangeMeetingsMenuItem(Menu.ConsoleMenu pParent, MenuManager manager, Student student)
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
        JsonHelpers.SerialiseStudent(student);
        parent.IsActive = false;
    }
}