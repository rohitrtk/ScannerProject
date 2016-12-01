using System;

namespace ScannerProject
{
    /// <summary>
    /// This class inherits from Person, contains a username for the teacher which is used to log into the program,
    /// contains a password for the teacher to use as a password to log in
    /// </summary>
    public class Teacher : Person
    {
#region _VARIABLES_
        public string Username { get; }
        public string Password { get; }
        public int GraceTime { get; }
        public CourseManager CourseManager;
#endregion

        /// <summary>
        /// Constructs a new Teacher, assigns the username and password values from parameters.
        /// Inits the CourseManager and adds the teachers courses to the list of courses they teach
        /// via a string array of courses read from a file
        /// </summary>
        /// <param name="username"></param>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <param name="id"></param>
        /// <param name="password"></param>
        /// <param name="courseStrings"></param>
        /// <param name="graceTime"></param>
        public Teacher(string username, string lastName, string firstName, int id, string password, string[] courseStrings, int graceTime) 
            : base(lastName, firstName, id)
        {
            Username = username;
            Password = password;
            GraceTime = graceTime;
            CourseManager = new CourseManager();

            // Add courses to the list of courses based on the data retrived from .lbs file
            var i = 0;
            foreach (var s in courseStrings)
            {
                CourseManager.ListOfCourses.Add(new Course(s, i));
                i++;
            }
        }
    }
}