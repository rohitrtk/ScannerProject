using System;
using System.Collections.Generic;

namespace ScannerProject
{
    /// <summary>
    /// Each teacher will have a course manager, responsible for
    /// holding a list of courses the teacher has this semester
    /// </summary>
    public class CourseManager
    {
#region _VARIABLES_
        // List of courses the teacher teaches this semester
        public List<Course> ListOfCourses;
#endregion

        /// <summary>
        /// Constructs a new CourseManager, inits a new list of courses
        /// </summary>
        public CourseManager()
        {
            ListOfCourses = new List<Course>();
        }

        /// <summary>
        /// Returns the course at a given period, which is just
        /// the index at which a course code resides
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Course GetCourseAtPeriod(int p)
        {
            return p < 1 ? new Course("NONE", p) : ListOfCourses[p];
        }
    }
}