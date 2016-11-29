using System;
using System.Windows.Forms;

namespace ScannerProject
{
    public partial class f_CreateUserForm : Form
    {
#region _VARIABLES_
        // Random object
        private Random _random;        

        // String that holds users first name
        private string _firstName;

        // String that holds users last name
        private string _lastName;

        // String that holds users user name
        private string _username;
        
        // String that holds users password
        private string _password;

        // Array of strings that hold the course codes
        private string[] _courseCodes;

        // String that holds the password generated from the generate password button
        private string _generatedPassword;

        // Array of booleans that store if requred data is acquired 
        private bool[] _dataBools;

#endregion

        public f_CreateUserForm()
        {
            InitializeComponent();

            _random = new Random();

            _dataBools = new bool[9];
            for (var i = 0; i < _dataBools.Length; i++)
            {
                _dataBools[i] = false;
            }
        }

        private void b_GeneratePassword_Click(object sender, EventArgs e)
        {
            _generatedPassword = "";

            for (var i = 0; i < 6; i++)
            {
                var temp = _random.Next(0, 9);
                _generatedPassword += temp;
            }
            t_Password.Text = _generatedPassword;
        }

        private void b_Submit_Click(object sender, EventArgs e)
        {
            foreach (var b in _dataBools)
            {
                
            }
        }
    }
}
