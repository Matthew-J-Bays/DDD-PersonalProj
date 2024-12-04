using DDDProj.Helpers;
using DDDProj.Users;

namespace DDDProj.Menu
{
    internal class UpdateStatusMenuItem : MenuItem
    {
        ConsoleMenu parent;
        MenuManager menuManager;
        Student student;
        public UpdateStatusMenuItem(ConsoleMenu pParent, MenuManager pManager, Student pStudent)
        {
            this.parent = pParent;
            this.menuManager = pManager;
            this.student = pStudent;
        }

        public override string MenuText()
        {
            return "Update your status";
        }

        public override void SelectMenu()
        {
            Console.Clear();
            Console.WriteLine("How are you getting on?\n");
            this.student.status = Console.ReadLine();
            Console.WriteLine("Status updated successfully");
            Thread.Sleep(1750);
            parent.IsActive = false;
        }
    }
}