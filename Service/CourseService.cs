using System.Text.RegularExpressions;

namespace ConsoleApp.Service
{
    internal class CourseService
    {

        public List<Group> Groups { get; set; } = new List<Group>();

        public void CreateGroup()
        {
            string groupNo = GetGroupNo();
            if (GroupExists(groupNo))
            {
                Console.WriteLine("Bu qrup movcuddur.");
                return;
            }

            string category = GetCategory();
            bool isOnline = IsOnline();

            Groups.Add(new Group(groupNo, category, isOnline));
            Console.WriteLine("Yeni qrup yaradildi.");
        }

        private bool GroupExists(string groupNo)
        {
            throw new NotImplementedException();
        }

        private string GetGroupNo()
        {
            Console.Write("Qrup nomresi daxil edin: ");
            return Console.ReadLine();
        }

        private string GetCategory()
        {
            Console.Write("Qrup kateqoriyasini daxil edin (Programming/Design/System Administration): ");
            return Console.ReadLine();
        }

        private bool IsOnline()
        {
            Console.Write("Qrup onlinedirmi? (yes/no): ");
            return Console.ReadLine().Trim().ToLower() == "yes";
        }
        public void ShowAllGroups()
        {
            if (Groups.Count == 0)
            {
                Console.WriteLine("Heç bir qrup yoxdur.");
                return;
            }

            Console.WriteLine("\nButun qruplar:");
            foreach (Group group in Groups)
            {
                Console.WriteLine($"Qrup Nömrəsi: {group.}, Kateqoriya: {group.Category}, Tələbə Sayı: {group.Students.Count}");
            }
        }

        internal void EditGroup()
        {
            throw new NotImplementedException();
        }
    }

}
