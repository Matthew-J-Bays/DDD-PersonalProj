using DDDProj.Helpers;
using DDDProj.Users;

namespace DDDProj.Menu.StudentMenus
{
    internal class ViewPriorMeetingsMenuItem : MenuItem
    {
        private ConsoleMenu parent;
        private MenuManager manager;
        private Student student;

        public ViewPriorMeetingsMenuItem(ConsoleMenu pParent, MenuManager manager, Student student)
        {
            this.parent = pParent;
            this.manager = manager;
            this.student = student;
        }

        public override string MenuText()
        {
            return "View prior meetings";
        }

        public override void SelectMenu()
        {
            for (int i = 0; i < student.formerMeetings.Count; i++)
            {
                Console.WriteLine($"{student.formerMeetings[i].DateTime} - {student.formerMeetings[i].Location}");
            }
            Console.WriteLine("\nPress enter to return");
            Console.ReadLine();
            parent.IsActive = false;
        }
    }
}