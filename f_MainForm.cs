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

        private bool _autoLate;

        private string[] _data;

        private List<string> _totalStudenList;

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

            _autoLate = false;

            _totalStudenList = new List<string>();

            // Set the title of the MainForm
            Text += "Late Buster: Lobby | " + _teacher.Username;

            CurrentPeriod = GetCurrentPeriod();

            LoadInfo();
        }

        private void LoadInfo()
        {
            _data = DataManager.ReadAllData(_teacher.CourseManager.GetCourseAtPeriod(CurrentPeriod).CourseCode);
            _totalStudenList = _data.ToList();
            DataManager.LoadAllData(_data, listBox_Pending);
        }

        /// <summary>
        /// This method is called every tick on the timer of MainForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Clock_Tick(object sender, EventArgs e)
        {
            CurrentPeriod = GetCurrentPeriod();
            
            // Set the course code label to the course that coresponds with the time
            l_CourseCode.Text = _teacher.CourseManager.GetCourseAtPeriod(CurrentPeriod).CourseCode.Replace(".lbs", string.Empty);

            // Update the clock
            l_Clock.Text = DateTime.Now.ToString("hh:mm:ss tt");

            
        }

        private void f_MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            var key = e.KeyChar;
            if (key >= 48 && key <= 57)
            {
                //DataManager.GetScannerInput();
            }
        }

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
            return 0;
        }

        private void toolStripMenuItem_AddOrRemoveStudent_Click(object sender, EventArgs e)
        {
            var form = new f_AddOrRemoveStudentForm(_teacher, _teacher.CourseManager.GetCourseAtPeriod(CurrentPeriod));
            form.Show();
        }

        private void setGraceTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new f_GraceTime(_teacher.GraceTime, _teacher.CourseManager.GetCourseAtPeriod(CurrentPeriod));
            form.Show();
        }

        private void checkBox_AutoLate_CheckedChanged(object sender, EventArgs e)
        {
            _autoLate = checkBox_AutoLate.Checked;
        }
    }
}