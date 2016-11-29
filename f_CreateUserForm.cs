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

        // String that holds email address of user
        private string _email;

        // Array of strings that hold the course codes
        private string[] _courseCodes;

        // String that holds the password generated from the generate password button
        private string _generatedPassword;

        // Array of booleans that store if requred data is acquired 
        private bool[] _dataBools;

        // Message string
        private const string _messageString = "1 or more peices of required information was missing\n" +
                                        "Please make sure all required information was filled in!";

#endregion

        public f_CreateUserForm()
        {
            InitializeComponent();

            _random = new Random();

            _courseCodes = new string[5];
            for (var i = 0; i < _courseCodes.Length; i++)
            {
                _courseCodes[i] = "";
            }

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
                if (!string.IsNullOrWhiteSpace(t_Login.Text) && !string.IsNullOrWhiteSpace(t_Password.Text) &&
                    !string.IsNullOrWhiteSpace(t_FirstName.Text) && !string.IsNullOrWhiteSpace(t_LastName.Text) &&
                    !string.IsNullOrWhiteSpace(t_Period1.Text) && !string.IsNullOrWhiteSpace(t_Period2.Text) &&
                    !string.IsNullOrWhiteSpace(t_Period3.Text) && !string.IsNullOrWhiteSpace(t_Period4.Text) &&
                    !string.IsNullOrWhiteSpace(t_Period5.Text) && !string.IsNullOrWhiteSpace(t_Email.Text)) continue;

                MessageBox.Show(_messageString);
                break;
            }

            _firstName = t_FirstName.Text;
            _lastName = t_LastName.Text;
            _username = t_Login.Text;
            _password = t_Password.Text;
            _email = t_Email.Text;
            _courseCodes[0] = t_Period1.Text;
            _courseCodes[1] = t_Period2.Text;
            _courseCodes[2] = t_Period3.Text;
            _courseCodes[3] = t_Period4.Text;
            _courseCodes[4] = t_Period5.Text;

            var str = _username + "," + _password + "," + _lastName + "," + _firstName;
            foreach (var v in _courseCodes)
            {
                str += "," + v;
            }
        
            DataManager.SaveAllData(DataManager.LoginFile, str);
        }
    }
}
