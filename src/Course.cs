using System;
using System.Collections.Generic;

namespace ScannerProject
{
    /// <summary>
    /// This class will store the course code, the list of students in this course and
    /// the time the course starts 
    /// </summary>
    internal class Course
    {
        // This courses course code
        public string CourseCode { get; set; }

        // Start time of the class
        public DateTime StartTime { get; set; }

        // End time of the class
        public DateTime EndTime { get; set; }

        // Students in this course
        public List<Student> StudentsInCourse;

        public int Period;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="courseCode"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// Example: CourseCode = ICS4U1, StartTime = 12:00:00, EndTime = 13:17:00
        public Course(string courseCode, DateTime startTime, DateTime endTime)
        {
            StudentsInCourse = new List<Student>();

            CourseCode = courseCode;
            StartTime = startTime;
            EndTime = endTime;

            var currentTime = DateTime.Now;

            if (currentTime.CompareTo(startTime) < 0 || currentTime.CompareTo(endTime) > 0) return;

            if (startTime.Equals("08:10:00 AM")) Period = 0;
            else if (startTime.Equals("09:27:00 AM")) Period = 1;
            else if (startTime.Equals("10:44:00 AM")) Period = 2;
            else if (startTime.Equals("12:00:00 PM")) Period = 3;
            else if (startTime.Equals("01:17:00 PM")) Period = 4;
            else Period = -1;
        }

        /// <summary>
        /// Constructor for the class
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