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
    public partial class f_LoginForm : Form
    {
        #region _VARIABLES_

        private string[] _seperators = {","};

        // Data string from login file .lbf
        private string[] data;

        // Username string
        private string _username;

        // Password string
        private string _password;
#endregion

        public f_LoginForm()
        {
            InitializeComponent();

            data = DataManager.ReadAllData("Logins.lbf");
        }

        private void b_Submit_Click(object sender, EventArgs e)
        {
            _username = t_Login.Text;
            _password = t_Password.Text;

            string[] temp;

            foreach (var s in data)
            {
                temp = s.Split(_seperators, StringSplitOptions.None);

                if (_username.Equals(temp[0]) && _password.Equals(temp[1]))
                {
                    MessageBox.Show("LOGIN");
                }
            }
        }

        private void b_CreateUser_Click(object sender, EventArgs e)
        {

        }
    }
}
