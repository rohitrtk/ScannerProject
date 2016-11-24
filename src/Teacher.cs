namespace ScannerProject
{
    /// <summary>
    /// Each teacher will have a teacher class which stores the name, id and password
    /// </summary>
    internal class Teacher : Person
    {
        public string Password { get; }

        private readonly CourseManager _courseManager; 

        public Teacher(string lastName, string firstName, int id, string password) 
            : base(lastName, firstName, id)
        {
            Password = password;
            _courseManager = new CourseManager();
        }

        public Course GetCourseAt(int period)
        {
            return _courseManager.ListOfCourses[period];
        }
    }
}