using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ScannerProject
{
    public partial class f_AddOrRemoveStudentForm : Form
    {
#region _VARIABLES_

        private Teacher _teacher;
        private readonly Course _course;

        private string _title;
        private readonly List<Student> ListOfStudents;
#endregion

        public f_AddOrRemoveStudentForm(Teacher teacher, Course course)
        {
            InitializeComponent();

            _teacher = teacher;
            _course = course;

            _title = "Late Buster: Add/Remove -> " + _course.CourseCode + " | " + _teacher.Username;
            Text = _title;

            l_Help.Text = "Scan a student card to add them to\nthe class. Click on a students name in\nthe box" +
                          " to remove them.";

            ListOfStudents = new List<Student>();

            ListOfStudents.Add(new Student("Kisto", "Rohit", 0, "rtkbfmvbvb@hotmail.com"));
            listBox_StudentsInClass.Items.Add(ListOfStudents[0].FirstName + " " + ListOfStudents[0].LastName);
        }

        private void listBox_StudentsInClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_StudentsInClass.Items.Remove(listBox_StudentsInClass.SelectedItem);
        }

        private void b_Save_Click(object sender, EventArgs e)
        {
            var data = new string[ListOfStudents.Count];
            var i = 0;
            foreach (var v in ListOfStudents)
            {
                data[i] = v.Id.ToString();
                i++;
            }

            DataManager.SaveAllData(_course.CourseCode + ".lbs", data);
        }
    }
}
