using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScannerProject
{
    public partial class f_AddOrRemoveStudentForm : Form
    {
#region _VARIABLES_

        private Teacher _teacher;
        private Course _course;

        private string _title;
#endregion

        public f_AddOrRemoveStudentForm(Teacher teacher, Course course)
        {
            InitializeComponent();

            _teacher = teacher;
            _course = course;

            _title = "Late Buster: Add/Remove -> " + _course.CourseCode + " | " + _teacher.Username;
            Text = _title;
        }
    }
}
