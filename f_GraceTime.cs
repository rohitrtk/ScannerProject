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
    public partial class f_GraceTime : Form
    {
        private readonly Course _course;
        private string _graceTimeAsString;
        private int _graceTime;
        private const int MaxGraceTime = 180;

        public f_GraceTime(int graceTime, Course course)
        {
            InitializeComponent();
            _graceTime = graceTime;
            _course = course;

            textBox_GraceTime.Text = DataManager.ReadLine(_course.CourseCode, 0);
        }

        private void textBox_GraceTime_TextChanged(object sender, EventArgs e)
        {
            _graceTimeAsString = textBox_GraceTime.Text;
        }

        private void b_Save_Click(object sender, EventArgs e)
        {
            int number;

            var result = int.TryParse(_graceTimeAsString, out number);

            if (result) _graceTime = number;
            else
            {
                MessageBox.Show("Error occured while reading grace time value\nMake sure they're all integers!");
                return;
            }

            if (_graceTime > MaxGraceTime)
            {
                MessageBox.Show("Maximum grace time is 3 minutes!", "Stop being nice to your students.");
                _graceTime = MaxGraceTime;
            }

            //var dataList = DataManager.ReadAllData(_course.CourseCode).ToList();

            //dataList.Insert(0, _graceTime.ToString());
            //DataManager.SaveAllData(_course.CourseCode, dataList.ToArray());

            var data = DataManager.ReadAllData(_course.CourseCode);
            data[0] = _graceTime.ToString();
            DataManager.SaveAllData(_course.CourseCode, data);
        }
    }
}
