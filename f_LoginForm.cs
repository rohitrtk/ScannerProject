using System;
using System.Windows.Forms;

namespace ScannerProject
{
    /// <summary>
    /// Class used to run the login form, if the user logs in succesfully, they will be taken to the class form
    /// </summary>
    public partial class f_LoginForm : Form
    {
#region _VARIABLES_

        // Data string from login file .lbf
        private string[] data;

        // Username string
        private string _username;

        // Password string
        private string _password;
#endregion

        /// <summary>
        /// Called when form is inited
        /// </summary>
        public f_LoginForm()
        {
            InitializeComponent();

            // Read all the data from Logins.lbf and store them in string array
            data = DataManager.ReadAllData("Logins.lbs");
        }

        // Called when user clicks on the the submit button
        private void b_Submit_Click(object sender, EventArgs e)
        {
            // Set the _username to the text of the login box
            _username = t_Login.Text;

            // Set the _password to the text of the password box
            _password = t_Password.Text;
            
            // Foreach string in data
            foreach (var s in data)
            {
                // Temp variable splits the string @ , and stores them in an array
                var temp = s.Split(',');

                // If the user login info matches a stored login info, succesful login
                if (temp[0].Equals(_username) && temp[1].Equals(_password)) 
                {
                    Console.WriteLine("Signed In!");
                }
            }
        }

        // Called when the user clicks the create user button
        private void b_CreateUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new f_CreateUserForm();
            form.Show();
        }
    }
}
