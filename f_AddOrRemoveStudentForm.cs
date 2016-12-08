using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ScannerProject
{
    public partial class f_AddOrRemoveStudentForm : Form
    {
#region _VARIABLES_

        private Teacher _teacher;
        private readonly Course _course;

        private string _title;
        private readonly List<Student> ListOfStudents;
        private string[] data;
#endregion

        public f_AddOrRemoveStudentForm(Teacher teacher, Course course)
        {
            InitializeComponent();

            // Set the teacher to parameter of teacher
            _teacher = teacher;

            // Set the course to paramerter of course
            _course = course;

            // Set title to the course code and teacher username
            _title = ("Late Buster: Add/Remove -> " + _course.CourseCode + " | " + _teacher.Username).Replace(".lbs", string.Empty);

            // Display title
            Text = _title;

            // Set the help text on screen
            l_Help.Text = "Scan a student card to add them to\nthe class. Click on a students name in\nthe box" +
                          " to remove them.";

            // List of students in the current class
            ListOfStudents = new List<Student>();

            // Read the data from the course code .lbs, ignoring the first line
            data = DataManager.ReadAllData(_course.CourseCode, true);

            // Foreach variable in data array, add a new student to the list of students and display them
            foreach (var v in data)
            {
                ListOfStudents.Add(new Student("Kisto", "Rohit", int.Parse(v), "something@hotmail.com"));
                listBox_StudentsInClass.Items.Add(v);
            }
        }

        /// <summary>
        /// This method is called when a key is pressed on this form
        /// Used for scanner stuff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_AddStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataManager.GetScannerInput(timer_Scanner, textBox_AddStudent);
        }

        /// <summary>
        /// This method is called when the user presses the add student button ///// TEMP (Not to be in final version)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_AddStudent_Click(object sender, EventArgs e)
        {
            // String the same as the text in textbox
            var studentId = textBox_AddStudent.Text;

            // If the string is blank
            if (studentId.Equals(string.Empty)) return;

            // Add a new student to the list of students
            ListOfStudents.Add(new Student("Rohit", "Kisto", int.Parse(studentId), "weed@hotmail.com"));

            // Add the new students first name to the list box
            listBox_StudentsInClass.Items.Add(ListOfStudents.Last().Id);
        }

        /// <summary>
        /// This method is called when the selected index of the list box is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_StudentsInClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If the selected index is less than 0 or greater than the number of objects in the list box
            if (listBox_StudentsInClass.SelectedIndex < 0 || 
                listBox_StudentsInClass.SelectedIndex > listBox_StudentsInClass.Items.Count) return;

            // Remove the selected item from the student list
            ListOfStudents.RemoveAt(listBox_StudentsInClass.SelectedIndex);

            // Remove the selected item from the list box
            listBox_StudentsInClass.Items.Remove(listBox_StudentsInClass.SelectedItem);
        }

        /// <summary>
        /// This method is called when the user clicks on the save button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_Save_Click(object sender, EventArgs e)
        {
            // String array w/ length of the list of student count
            var localdata = new string[ListOfStudents.Count];

            // Counter
            var i = 0;

            // Foreach variable in ListOfStudents
            foreach (var v in ListOfStudents)
            {
                // String array at counter is the same as the variables id
                localdata[i] = v.Id.ToString();

                // Add one to counter
                i++;
            }

            // Save all of the data from string array into the course code .lbs file
            DataManager.SaveAllData(_course.CourseCode, localdata);
        }
    }
}