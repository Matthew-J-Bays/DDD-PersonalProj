using DDDProj.Helpers;
using DDDProj.Users;

namespace DDDProj.Menu.StudentMenus
{
    internal class StudentViewActiveMeetingsMenuItem : MenuItem
    {
        private Menu.ConsoleMenu parent;
        private MenuManager manager;
        private Student student;

        public StudentViewActiveMeetingsMenuItem(Menu.ConsoleMenu pParent, MenuManager manager, Student student)
        {
            this.parent = pParent;
            this.manager = manager;
            this.student = student;
        }

        public override string MenuText()
        {
            return "View upcoming meetings";
        }

        public override void SelectMenu()
        {
            for (int i = 0; i < student.activeMeetings.Count; i++)
            {
                Console.WriteLine($"{student.activeMeetings[i].DateTime} - {student.activeMeetings[i].Location}");
            }
            Console.WriteLine("\nPress enter to return");
            Console.ReadLine();
            parent.IsActive = false;
        }
    }
}