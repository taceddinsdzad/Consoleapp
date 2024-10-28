namespace ConsoleApp.Models
{
    internal class Student
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string GroupNo { get; set; }
        public bool IsGuaranteed { get; set; }

        public Student(string name, string surname, string groupNo, bool isGuaranteed)
        {
            Name = name;
            Surname = surname;
            GroupNo = groupNo;
            IsGuaranteed = isGuaranteed;
        }
    }
}
