using ConsoleApp.Service;

namespace ConsoleApp.Models
{
    internal class Group : CourseService
    {

        public string NO { get; set; }

        public string Category { get; set; }

        public bool IsOnline { get; set; }

        public int Limit { get; set; }

        public List<Student> Students { get; set; }

        public Group(string no, string category, bool isOnline)

        {
            NO = no;
            Category = category;
            IsOnline = isOnline;
            if (isOnline)
            {
                Limit = 15;
            }
            else
            {
                Limit = 10;
            }

            Students = new List<Student>();
        }
    }
}
