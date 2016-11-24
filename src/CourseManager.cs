using System.Collections.Generic;

namespace ScannerProject
{
    /// <summary>
    /// Each teacher will have a course manager
    /// </summary>
    internal class CourseManager
    {
        public List<Course> ListOfCourses;

        public CourseManager()
        {
            ListOfCourses = new List<Course>();
        }
    }
}