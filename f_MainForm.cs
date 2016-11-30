using System;
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
        private Teacher _teacher;
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

            // Set the title of the MainForm
            Text += "Late Buster: Lobby | " + _teacher.Username;
        }

        /// <summary>
        /// This method is called every tick on the timer of MainForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Clock_Tick(object sender, EventArgs e)
        {
            // What period is it?
            if (DateTime.Now.CompareTo(DateTime.Parse("02:35:00 PM")) >= 0 || DateTime.Now.CompareTo(DateTime.Parse("08:10:00")) < 0) CurrentPeriod = (int) DataManager.Period.Noperiod;
            else if (DateTime.Now.CompareTo(DateTime.Parse("01:21:00 PM")) >= 0) CurrentPeriod = (int) DataManager.Period.Period5;
            else if (DateTime.Now.CompareTo(DateTime.Parse("12:04:00 PM")) >= 0) CurrentPeriod = (int) DataManager.Period.Period4;
            else if (DateTime.Now.CompareTo(DateTime.Parse("10:47:00 AM")) >= 0) CurrentPeriod = (int) DataManager.Period.Period3;
            else if (DateTime.Now.CompareTo(DateTime.Parse("09:30:00 AM")) >= 0) CurrentPeriod = (int) DataManager.Period.Period2;
            else if (DateTime.Now.CompareTo(DateTime.Parse("08:10:00 AM")) >= 0) CurrentPeriod = (int) DataManager.Period.Period1;

            // Set the course code label to the course that coresponds with the time
            l_CourseCode.Text = _teacher.CourseManager.GetCourseAtPeriod(CurrentPeriod).CourseCode;

            // Update the clock
            l_Clock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void toolStripMenuItem_AddOrRemoveStudent_Click(object sender, EventArgs e)
        {
            var form = new f_AddOrRemoveStudentForm(_teacher, _teacher.CourseManager.GetCourseAtPeriod(CurrentPeriod));
            form.Show();
        }
    }
}