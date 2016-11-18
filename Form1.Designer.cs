﻿namespace ScannerProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.textBox_TeacherLogin = new System.Windows.Forms.TextBox();
            this.listBox_Pending = new System.Windows.Forms.ListBox();
            this.l_TeacherLogin = new System.Windows.Forms.Label();
            this.l_CourseCode = new System.Windows.Forms.Label();
            this.l_Pending = new System.Windows.Forms.Label();
            this.l_CheckedIn = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_AutoTimer = new System.Windows.Forms.CheckBox();
            this.listBox_CheckedIn = new System.Windows.Forms.ListBox();
            this.listBox_Excused = new System.Windows.Forms.ListBox();
            this.l_Clock = new System.Windows.Forms.Label();
            this.timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.button_StartTimer = new System.Windows.Forms.Button();
            this.l_TeacherPass = new System.Windows.Forms.Label();
            this.textBox_TeacherPassword = new System.Windows.Forms.TextBox();
            this.b_SubmitInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_TeacherLogin
            // 
            this.textBox_TeacherLogin.Location = new System.Drawing.Point(30, 28);
            this.textBox_TeacherLogin.Name = "textBox_TeacherLogin";
            this.textBox_TeacherLogin.Size = new System.Drawing.Size(231, 20);
            this.textBox_TeacherLogin.TabIndex = 1;
            // 
            // listBox_Pending
            // 
            this.listBox_Pending.FormattingEnabled = true;
            this.listBox_Pending.Location = new System.Drawing.Point(30, 154);
            this.listBox_Pending.Name = "listBox_Pending";
            this.listBox_Pending.Size = new System.Drawing.Size(195, 238);
            this.listBox_Pending.TabIndex = 2;
            // 
            // l_TeacherLogin
            // 
            this.l_TeacherLogin.AutoSize = true;
            this.l_TeacherLogin.Location = new System.Drawing.Point(27, 12);
            this.l_TeacherLogin.Name = "l_TeacherLogin";
            this.l_TeacherLogin.Size = new System.Drawing.Size(76, 13);
            this.l_TeacherLogin.TabIndex = 4;
            this.l_TeacherLogin.Text = "Teacher Login";
            // 
            // l_CourseCode
            // 
            this.l_CourseCode.AutoSize = true;
            this.l_CourseCode.Location = new System.Drawing.Point(427, 9);
            this.l_CourseCode.Name = "l_CourseCode";
            this.l_CourseCode.Size = new System.Drawing.Size(68, 13);
            this.l_CourseCode.TabIndex = 8;
            this.l_CourseCode.Text = "Course Code";
            // 
            // l_Pending
            // 
            this.l_Pending.AutoSize = true;
            this.l_Pending.Location = new System.Drawing.Point(104, 138);
            this.l_Pending.Name = "l_Pending";
            this.l_Pending.Size = new System.Drawing.Size(46, 13);
            this.l_Pending.TabIndex = 11;
            this.l_Pending.Text = "Pending";
            // 
            // l_CheckedIn
            // 
            this.l_CheckedIn.AutoSize = true;
            this.l_CheckedIn.Location = new System.Drawing.Point(297, 138);
            this.l_CheckedIn.Name = "l_CheckedIn";
            this.l_CheckedIn.Size = new System.Drawing.Size(62, 13);
            this.l_CheckedIn.TabIndex = 12;
            this.l_CheckedIn.Text = "Checked In";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Excused";
            // 
            // checkBox_AutoTimer
            // 
            this.checkBox_AutoTimer.AutoSize = true;
            this.checkBox_AutoTimer.Location = new System.Drawing.Point(430, 54);
            this.checkBox_AutoTimer.Name = "checkBox_AutoTimer";
            this.checkBox_AutoTimer.Size = new System.Drawing.Size(77, 17);
            this.checkBox_AutoTimer.TabIndex = 14;
            this.checkBox_AutoTimer.Text = "Auto Timer";
            this.checkBox_AutoTimer.UseVisualStyleBackColor = true;
            // 
            // listBox_CheckedIn
            // 
            this.listBox_CheckedIn.FormattingEnabled = true;
            this.listBox_CheckedIn.Location = new System.Drawing.Point(231, 154);
            this.listBox_CheckedIn.Name = "listBox_CheckedIn";
            this.listBox_CheckedIn.Size = new System.Drawing.Size(195, 238);
            this.listBox_CheckedIn.TabIndex = 15;
            // 
            // listBox_Excused
            // 
            this.listBox_Excused.FormattingEnabled = true;
            this.listBox_Excused.Location = new System.Drawing.Point(432, 154);
            this.listBox_Excused.Name = "listBox_Excused";
            this.listBox_Excused.Size = new System.Drawing.Size(195, 238);
            this.listBox_Excused.TabIndex = 16;
            // 
            // l_Clock
            // 
            this.l_Clock.AutoSize = true;
            this.l_Clock.Location = new System.Drawing.Point(559, 9);
            this.l_Clock.Name = "l_Clock";
            this.l_Clock.Size = new System.Drawing.Size(34, 13);
            this.l_Clock.TabIndex = 17;
            this.l_Clock.Text = "Clock";
            // 
            // timer_Clock
            // 
            this.timer_Clock.Enabled = true;
            this.timer_Clock.Interval = 1;
            this.timer_Clock.Tick += new System.EventHandler(this.timer_Clock_Tick);
            // 
            // button_StartTimer
            // 
            this.button_StartTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_StartTimer.Location = new System.Drawing.Point(518, 48);
            this.button_StartTimer.Name = "button_StartTimer";
            this.button_StartTimer.Size = new System.Drawing.Size(75, 30);
            this.button_StartTimer.TabIndex = 18;
            this.button_StartTimer.Text = "Start Timer";
            this.button_StartTimer.UseVisualStyleBackColor = true;
            // 
            // l_TeacherPass
            // 
            this.l_TeacherPass.AutoSize = true;
            this.l_TeacherPass.Location = new System.Drawing.Point(30, 55);
            this.l_TeacherPass.Name = "l_TeacherPass";
            this.l_TeacherPass.Size = new System.Drawing.Size(96, 13);
            this.l_TeacherPass.TabIndex = 19;
            this.l_TeacherPass.Text = "Teacher Password";
            // 
            // textBox_TeacherPassword
            // 
            this.textBox_TeacherPassword.Location = new System.Drawing.Point(30, 71);
            this.textBox_TeacherPassword.Name = "textBox_TeacherPassword";
            this.textBox_TeacherPassword.PasswordChar = '*';
            this.textBox_TeacherPassword.Size = new System.Drawing.Size(231, 20);
            this.textBox_TeacherPassword.TabIndex = 20;
            // 
            // b_SubmitInfo
            // 
            this.b_SubmitInfo.Location = new System.Drawing.Point(268, 28);
            this.b_SubmitInfo.Name = "b_SubmitInfo";
            this.b_SubmitInfo.Size = new System.Drawing.Size(69, 63);
            this.b_SubmitInfo.TabIndex = 21;
            this.b_SubmitInfo.Text = "Submit";
            this.b_SubmitInfo.UseVisualStyleBackColor = true;
            this.b_SubmitInfo.Click += new System.EventHandler(this.b_SubmitInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(656, 404);
            this.Controls.Add(this.b_SubmitInfo);
            this.Controls.Add(this.textBox_TeacherPassword);
            this.Controls.Add(this.l_TeacherPass);
            this.Controls.Add(this.button_StartTimer);
            this.Controls.Add(this.l_Clock);
            this.Controls.Add(this.listBox_Excused);
            this.Controls.Add(this.listBox_CheckedIn);
            this.Controls.Add(this.checkBox_AutoTimer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.l_CheckedIn);
            this.Controls.Add(this.l_Pending);
            this.Controls.Add(this.l_CourseCode);
            this.Controls.Add(this.l_TeacherLogin);
            this.Controls.Add(this.listBox_Pending);
            this.Controls.Add(this.textBox_TeacherLogin);
            this.Name = "Form1";
            this.Text = "Late Buster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_TeacherLogin;
        private System.Windows.Forms.ListBox listBox_Pending;
        private System.Windows.Forms.Label l_TeacherLogin;
        private System.Windows.Forms.Label l_CourseCode;
        private System.Windows.Forms.Label l_Pending;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_AutoTimer;
        private System.Windows.Forms.Label l_CheckedIn;
        private System.Windows.Forms.ListBox listBox_CheckedIn;
        private System.Windows.Forms.ListBox listBox_Excused;
        private System.Windows.Forms.Label l_Clock;
        private System.Windows.Forms.Timer timer_Clock;
        private System.Windows.Forms.Button button_StartTimer;
        private System.Windows.Forms.Label l_TeacherPass;
        private System.Windows.Forms.TextBox textBox_TeacherPassword;
        private System.Windows.Forms.Button b_SubmitInfo;
    }
}
