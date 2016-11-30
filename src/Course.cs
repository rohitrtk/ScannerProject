using System;
using System.Collections.Generic;

namespace ScannerProject
{
    /// <summary>
    /// Stores the students in this course code
    /// </summary>
    public class Course
    {
        // This courses course code
        public string CourseCode { get; set; }

        // Students in this course
        public List<Student> StudentsInCourse;

        public int Period;

        /// <summary>
        /// Constructs a new Course
        /// </summary>
        /// <param name="courseCode"></param>
        /// <param name="period"></param>
        public Course(string courseCode, int period)
        {
            StudentsInCourse = new List<Student>();

            CourseCode = courseCode;
            Period = period;
        }
    }
}