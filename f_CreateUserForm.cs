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

        // Message string 1
        private const string MessageString = "1 or more peices of required information was missing\n" +
                                        "Please make sure all required information was filled in!";
        
        // Message string 2
        private const string MessageString2 = "Password must be more than 3 characters";

        // Message string 3
        private const string MessageString3 = "User created succesfully!";

#endregion

        /// <summary>
        /// Constructs a new CreateUserForm
        /// </summary>
        public f_CreateUserForm()
        {
            InitializeComponent();

            // Inits random object
            _random = new Random();

            // Inits course codes as a new string array with 5 indexes, because there are 5 periods
            _courseCodes = new string[5];
            
            // Assign all the values in the course codes array blank values for now
            for (var i = 0; i < _courseCodes.Length; i++)
            {
                _courseCodes[i] = "";
            }
        }

        /// <summary>
        /// Called when the user wants to generate a password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_GeneratePassword_Click(object sender, EventArgs e)
        {
            // Set the generated to blank (reset)
            _generatedPassword = "";

            // Generate a string of random integers
            for (var i = 0; i < 6; i++)
            {
                var temp = _random.Next(0, 9);
                _generatedPassword += temp;
            }

            // Display the generated password to a text box
            t_Password.Text = _generatedPassword;
        }

        /// <summary>
        /// Called when the user wants to submit their inputed information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_Submit_Click(object sender, EventArgs e)
        {
            // Check that there are no blank text boxes
            for (var i = 0 ; i < 9 ; i++)
            {
                if (!string.IsNullOrWhiteSpace(t_Login.Text) && !string.IsNullOrWhiteSpace(t_Password.Text) &&
                    !string.IsNullOrWhiteSpace(t_FirstName.Text) && !string.IsNullOrWhiteSpace(t_LastName.Text) &&
                    !string.IsNullOrWhiteSpace(t_Period1.Text) && !string.IsNullOrWhiteSpace(t_Period2.Text) &&
                    !string.IsNullOrWhiteSpace(t_Period3.Text) && !string.IsNullOrWhiteSpace(t_Period4.Text) &&
                    !string.IsNullOrWhiteSpace(t_Period5.Text) && !string.IsNullOrWhiteSpace(t_Email.Text)) continue;

                // Tell user that there is an issue
                MessageBox.Show(MessageString);

                // Leave method
                return;
            }

            // If the password is less than 4 characters, don't let them use it
            if (t_Password.Text.Length < 4)
            {
                MessageBox.Show(MessageString2);
                return;
            }

            // Assign variables values based on text box values
#region _ASSIGNINGSTUFF_
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
            #endregion

            // Add variables to a string that follows 
            // Username,Password,Last Name, First Name,Period 1,Period 2,Period 3, Period 4, Period 5, Email Address
            var str = _username + "," + _password + "," + _lastName + "," + _firstName;
            foreach (var v in _courseCodes)
            {
                str += "," + v;
            }

            str += "," + _email + "," + DataManager.DefaultGraceTime;
            
            // Call SaveAllData to write variables to a data file
            DataManager.SaveAllData(DataManager.LoginFile, str);

            // Tell user that the their was a successful user creation
            MessageBox.Show(MessageString3);
        }

        /// <summary>
        /// Called when user wants to return to the login screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new f_LoginForm();
            form.Show();
        }
    }
}
