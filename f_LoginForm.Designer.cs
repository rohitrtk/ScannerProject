namespace ScannerProject
{
    partial class f_LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_CreateUser = new System.Windows.Forms.Button();
            this.l_Login = new System.Windows.Forms.Label();
            this.l_Password = new System.Windows.Forms.Label();
            this.t_Login = new System.Windows.Forms.TextBox();
            this.t_Password = new System.Windows.Forms.TextBox();
            this.b_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_CreateUser
            // 
            this.b_CreateUser.Location = new System.Drawing.Point(12, 95);
            this.b_CreateUser.Name = "b_CreateUser";
            this.b_CreateUser.Size = new System.Drawing.Size(277, 23);
            this.b_CreateUser.TabIndex = 0;
            this.b_CreateUser.Text = "Create New User";
            this.b_CreateUser.UseVisualStyleBackColor = true;
            this.b_CreateUser.Click += new System.EventHandler(this.b_CreateUser_Click);
            // 
            // l_Login
            // 
            this.l_Login.AutoSize = true;
            this.l_Login.Location = new System.Drawing.Point(13, 13);
            this.l_Login.Name = "l_Login";
            this.l_Login.Size = new System.Drawing.Size(33, 13);
            this.l_Login.TabIndex = 1;
            this.l_Login.Text = "Login";
            // 
            // l_Password
            // 
            this.l_Password.AutoSize = true;
            this.l_Password.Location = new System.Drawing.Point(13, 53);
            this.l_Password.Name = "l_Password";
            this.l_Password.Size = new System.Drawing.Size(53, 13);
            this.l_Password.TabIndex = 2;
            this.l_Password.Text = "Password";
            // 
            // t_Login
            // 
            this.t_Login.Location = new System.Drawing.Point(16, 30);
            this.t_Login.Name = "t_Login";
            this.t_Login.Size = new System.Drawing.Size(134, 20);
            this.t_Login.TabIndex = 3;
            // 
            // t_Password
            // 
            this.t_Password.Location = new System.Drawing.Point(16, 69);
            this.t_Password.Name = "t_Password";
            this.t_Password.Size = new System.Drawing.Size(134, 20);
            this.t_Password.TabIndex = 4;
            // 
            // b_Submit
            // 
            this.b_Submit.Location = new System.Drawing.Point(187, 13);
            this.b_Submit.Name = "b_Submit";
            this.b_Submit.Size = new System.Drawing.Size(102, 76);
            this.b_Submit.TabIndex = 5;
            this.b_Submit.Text = "Submit";
            this.b_Submit.UseVisualStyleBackColor = true;
            this.b_Submit.Click += new System.EventHandler(this.b_Submit_Click);
            // 
            // f_LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 128);
            this.Controls.Add(this.b_Submit);
            this.Controls.Add(this.t_Password);
            this.Controls.Add(this.t_Login);
            this.Controls.Add(this.l_Password);
            this.Controls.Add(this.l_Login);
            this.Controls.Add(this.b_CreateUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "f_LoginForm";
            this.Text = "Late Buster: Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_CreateUser;
        private System.Windows.Forms.Label l_Login;
        private System.Windows.Forms.Label l_Password;
        private System.Windows.Forms.TextBox t_Login;
        private System.Windows.Forms.TextBox t_Password;
        private System.Windows.Forms.Button b_Submit;
    }
}