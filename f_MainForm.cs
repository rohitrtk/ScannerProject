using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ScannerProject
{
    /// <summary>
    /// This class is responsible for events on the MainForm
    /// </summary>
    public partial class f_MainForm : Form
    {
#region _VARIABLES_
        // The current period based on time
        public int CurrentPeriod;

        // Teacher object
        private readonly Teacher _teacher;

        // Boolean that stores whether or not the teacher would like to automatically
        // set students to late if they haven't reached class on time
        private bool _autoLate;

        // Array of data for the class read from the file that coresponds with the
        // course code of the current course
        private string[] _data;

        // List of students as strings
        private List<string> _totalStudenList;

        // Enum of the type of lists 
        private enum ListType
        {
            Total,
            Pending,
            SignedIn,
            Late,
            Absent
        }

        // A list of list of students, total list of students, pending list of students, etc...
        private List<List<Student>> _listOfStudents;

        // String to hold the barcode of scanner
        private string _barcode;

#endregion

        /// <summary>
        /// Constructs a new MainForm
        /// </summary>
        /// <param name="teacher"></param>
        public f_MainForm(Teacher teacher)
        {
            InitializeComponent();

            // Assigns this.teacher the value of the teacher passed in
            _teacher = teacher;

            // Set auto late to false, teacher checks a check box to change it to true
            _autoLate = false;

            // Init list of list of students
            _listOfStudents = new List<List<Student>>();

            // Init list of students
            _totalStudenList = new List<string>();

            // Set the title of the MainForm
            Text += "Late Buster: Lobby | " + _teacher.Username;

            // Set the barcode to an empty string
            _barcode = string.Empty;

            // Focus the scanner textbox
            textBox_Scanner.Focus();

            // Hide the scanner textbox
            textBox_Scanner.Hide();

            // Set the current period to the returned value from a method
            CurrentPeriod = GetCurrentPeriod();

            // Call method LoadInfo
            LoadInfo();
        }

        /// <summary>
        /// Loads data from a file into a string array and displays it to a listbox on screen
        /// </summary>
        private void LoadInfo()
        {
            // Read data from file
            _data = DataManager.ReadAllData(_teacher.CourseManager.GetCourseAtPeriod(CurrentPeriod).CourseCode);

            // Add the names to a list
            _totalStudenList = _data.ToList();

            // Load the data to a listbox
            DataManager.LoadAllData(_data, listBox_Pending);
        }

        /// <summary>
        /// This method is called every tick on the timer of MainForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Clock_Tick(object sender, EventArgs e)
        {
            // If the scanner textbox isn't focuses, focus ////// REMOVE THIS
            if (!textBox_Scanner.Focused) textBox_Scanner.Focus();
            
            // Set the current period
            CurrentPeriod = GetCurrentPeriod();
            
            // Set the course code label to the course that coresponds with the time
            l_CourseCode.Text = _teacher.CourseManager.GetCourseAtPeriod(CurrentPeriod).CourseCode.Replace(".lbs", string.Empty);

            // Update the clock
            l_Clock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        /// <summary>
        /// This method is called every tick on the timer, timer used for scanner stuff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Scanner_Tick(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Called when a key is pressed on the main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void f_MainForm_KeyPress(object sender, KeyPressEventArgs e)    ///// REMOVE THIS?
        {
            // Didn't want to type e.keyChar each time
            var key = e.KeyChar;

            // If the key is an integer key
            if (key >= 48 && key <= 57)
            {
                Console.WriteLine(key.ToString());
            }
        }

        /// <summary>
        /// Called to return the current period based on what time it is
        /// Can also be forced into setting what period it is via changing code (DEBUGGING PURPOSES!)
        /// </summary>
        /// <returns></returns>
        private static int GetCurrentPeriod()
        {
            // Force a period to be returned despite time, use for debugging purposes
            //return (int)DataManager.Period.Period1;

            // What period is it?
            if (DateTime.Now.CompareTo(DateTime.Parse("02:35:00 PM")) >= 0 || DateTime.Now.CompareTo(DateTime.Parse("08:10:00")) < 0) return (int)DataManager.Period.Noperiod;
            if (DateTime.Now.CompareTo(DateTime.Parse("01:21:00 PM")) >= 0) return (int)DataManager.Period.Period5;
            if (DateTime.Now.CompareTo(DateTime.Parse("12:04:00 PM")) >= 0) return (int)DataManager.Period.Period4;
            if (DateTime.Now.CompareTo(DateTime.Parse("10:47:00 AM")) >= 0) return (int)DataManager.Period.Period3;
            if (DateTime.Now.CompareTo(DateTime.Parse("09:30:00 AM")) >= 0) return (int)DataManager.Period.Period2;
            if (DateTime.Now.CompareTo(DateTime.Parse("08:10:00 AM")) >= 0) return (int)DataManager.Period.Period1;
            return -1;
        }

        /// <summary>
        /// Called when the user clicks on the menu bar and clicks on the add or remove student option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_AddOrRemoveStudent_Click(object sender, EventArgs e)
        {
            // Create a new form and show it
            var form = new f_AddOrRemoveStudentForm(_teacher, _teacher.CourseManager.GetCourseAtPeriod(CurrentPeriod));
            form.Show();
        }

        /// <summary>
        /// Called when the user clicks on the menu bar and clicks on the grace time button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setGraceTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new form and show it 
            var form = new f_GraceTime(_teacher.GraceTime, _teacher.CourseManager.GetCourseAtPeriod(CurrentPeriod));
            form.Show();
        }

        /// <summary>
        /// If the check box value is changed, change the value of _autoLate to the value of the check box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_AutoLate_CheckedChanged(object sender, EventArgs e)
        {
            _autoLate = checkBox_AutoLate.Checked;
        }
    }
}