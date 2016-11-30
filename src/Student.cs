namespace ScannerProject
{
    /// <summary>
    /// This class inherits from Person, contains a parent email and a boolean
    /// which is a representation of whether or not this student was in x class today
    /// </summary>
    public class Student : Person
    {
#region _VARIABLES_
        // The email address of the student
        public string ParentEmail { set; get; }

        // Whether or not this student was absent in x class
        public bool Absent { set; get; }
#endregion

        /// <summary>
        /// Constructs a Student, default absent = false
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <param name="id"></param>
        /// <param name="parentEmail"></param>
        public Student(string lastName, string firstName, int id, string parentEmail) 
            : base(lastName, firstName, id)
        {
            ParentEmail = parentEmail;
            Absent = false;
        }

        /// <summary>
        /// Constructs a Student
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <param name="id"></param>
        /// <param name="parentEmail"></param>
        /// <param name="absent"></param>
        public Student(string lastName, string firstName, int id, string parentEmail, bool absent) 
            : base(lastName, firstName, id)
        {
            ParentEmail = parentEmail;
            Absent = absent;
        }
    }
}