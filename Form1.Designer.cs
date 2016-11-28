namespace ScannerProject
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
            this.listBox_Pending = new System.Windows.Forms.ListBox();
            this.l_CourseCode = new System.Windows.Forms.Label();
            this.l_Pending = new System.Windows.Forms.Label();
            this.l_CheckedIn = new System.Windows.Forms.Label();
            this.listBox_CheckedIn = new System.Windows.Forms.ListBox();
            this.l_Clock = new System.Windows.Forms.Label();
            this.timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listBox_Pending
            // 
            this.listBox_Pending.FormattingEnabled = true;
            this.listBox_Pending.Location = new System.Drawing.Point(30, 154);
            this.listBox_Pending.Name = "listBox_Pending";
            this.listBox_Pending.Size = new System.Drawing.Size(195, 238);
            this.listBox_Pending.TabIndex = 2;
            // 
            // l_CourseCode
            // 
            this.l_CourseCode.AutoSize = true;
            this.l_CourseCode.Location = new System.Drawing.Point(193, 103);
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
            // listBox_CheckedIn
            // 
            this.listBox_CheckedIn.FormattingEnabled = true;
            this.listBox_CheckedIn.Location = new System.Drawing.Point(231, 154);
            this.listBox_CheckedIn.Name = "listBox_CheckedIn";
            this.listBox_CheckedIn.Size = new System.Drawing.Size(195, 238);
            this.listBox_CheckedIn.TabIndex = 15;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(656, 404);
            this.Controls.Add(this.l_Clock);
            this.Controls.Add(this.listBox_CheckedIn);
            this.Controls.Add(this.l_CheckedIn);
            this.Controls.Add(this.l_Pending);
            this.Controls.Add(this.l_CourseCode);
            this.Controls.Add(this.listBox_Pending);
            this.Name = "Form1";
            this.Text = "Late Buster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_Pending;
        private System.Windows.Forms.Label l_CourseCode;
        private System.Windows.Forms.Label l_Pending;
        private System.Windows.Forms.Label l_CheckedIn;
        private System.Windows.Forms.ListBox listBox_CheckedIn;
        private System.Windows.Forms.Label l_Clock;
        private System.Windows.Forms.Timer timer_Clock;
    }
}

