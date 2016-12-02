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
        private int _graceTime;
        private const int MaxGraceTime = 180;

        public f_GraceTime(int graceTime)
        {
            InitializeComponent();
            _graceTime = graceTime;
        }

        private void b_Save_Click(object sender, EventArgs e)
        {
            if (_graceTime > MaxGraceTime)
            {
                MessageBox.Show("Maximum grace time is 3 minutes!", "Stop being nice to your students.");
                _graceTime = MaxGraceTime;
                return;
            }

        }
    }
}
