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

            _teacher = teacher;
            _course = course;

            _title = ("Late Buster: Add/Remove -> " + _course.CourseCode + " | " + _teacher.Username).Replace(".lbs", string.Empty);
            Text = _title;

            l_Help.Text = "Scan a student card to add them to\nthe class. Click on a students name in\nthe box" +
                          " to remove them.";

            ListOfStudents = new List<Student>();

            data = DataManager.ReadAllData(_course.CourseCode);

            foreach (var d in data)
            {
                ListOfStudents.Add(new Student("Kisto", "Rohit", int.Parse(d), "asd@hotmail.com"));
                listBox_StudentsInClass.Items.Add(ListOfStudents.Last().FirstName);
            }
        }

        private void textBox_AddStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (timer_Scanner.Enabled || textBox_AddStudent.Text.Length != 0) return;

            textBox_AddStudent.Clear();
            timer_Scanner.Start();
        }

        private void button_AddStudent_Click(object sender, EventArgs e)
        {
            var studentID = textBox_AddStudent.Text;

            if (studentID.Equals(string.Empty)) return;

            ListOfStudents.Add(new Student("Rohit", "Kisto", int.Parse(studentID), "weed@hotmail.com"));
            listBox_StudentsInClass.Items.Add(ListOfStudents.Last().FirstName);
        }

        private void listBox_StudentsInClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListOfStudents.RemoveAt(listBox_StudentsInClass.SelectedIndex);
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

            DataManager.SaveAllData(_course.CourseCode, data);
        }
    }
}
