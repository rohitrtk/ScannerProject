namespace ScannerProject
{
    internal class Student : Person
    {
        public string ParentEmail { set; get; }
        public bool Absent { set; get; }

        public Student(string lastName, string firstName, int id, string parentEmail) 
            : base(lastName, firstName, id)
        {
            ParentEmail = parentEmail;
            Absent = false;
        }

        public Student(string lastName, string firstName, int id, string parentEmail, bool absent) 
            : base(lastName, firstName, id)
        {
            ParentEmail = parentEmail;
            Absent = absent;
        }
    }
}