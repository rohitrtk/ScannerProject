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

        // Time in seconds student has to get to class after the bell
        public int GraceTime { get; set; }

        // Maximum time in seconds student has to get to class
        public const int MaxGraceTime = 180;

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