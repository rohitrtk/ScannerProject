namespace ScannerProject
{
    partial class f_MainForm
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
            this.l_SignedIn = new System.Windows.Forms.Label();
            this.listBox_SignedIn = new System.Windows.Forms.ListBox();
            this.l_Clock = new System.Windows.Forms.Label();
            this.timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listBox_Absent = new System.Windows.Forms.ListBox();
            this.l_Absent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_Pending
            // 
            this.listBox_Pending.FormattingEnabled = true;
            this.listBox_Pending.Location = new System.Drawing.Point(12, 154);
            this.listBox_Pending.Name = "listBox_Pending";
            this.listBox_Pending.Size = new System.Drawing.Size(180, 238);
            this.listBox_Pending.TabIndex = 2;
            // 
            // l_CourseCode
            // 
            this.l_CourseCode.AutoSize = true;
            this.l_CourseCode.Location = new System.Drawing.Point(214, 24);
            this.l_CourseCode.Name = "l_CourseCode";
            this.l_CourseCode.Size = new System.Drawing.Size(68, 13);
            this.l_CourseCode.TabIndex = 8;
            this.l_CourseCode.Text = "Course Code";
            // 
            // l_Pending
            // 
            this.l_Pending.AutoSize = true;
            this.l_Pending.Location = new System.Drawing.Point(12, 138);
            this.l_Pending.Name = "l_Pending";
            this.l_Pending.Size = new System.Drawing.Size(46, 13);
            this.l_Pending.TabIndex = 11;
            this.l_Pending.Text = "Pending";
            // 
            // l_SignedIn
            // 
            this.l_SignedIn.AutoSize = true;
            this.l_SignedIn.Location = new System.Drawing.Point(195, 138);
            this.l_SignedIn.Name = "l_SignedIn";
            this.l_SignedIn.Size = new System.Drawing.Size(52, 13);
            this.l_SignedIn.TabIndex = 12;
            this.l_SignedIn.Text = "Signed In";
            // 
            // listBox_SignedIn
            // 
            this.listBox_SignedIn.FormattingEnabled = true;
            this.listBox_SignedIn.Location = new System.Drawing.Point(198, 154);
            this.listBox_SignedIn.Name = "listBox_SignedIn";
            this.listBox_SignedIn.Size = new System.Drawing.Size(180, 238);
            this.listBox_SignedIn.TabIndex = 15;
            // 
            // l_Clock
            // 
            this.l_Clock.AutoSize = true;
            this.l_Clock.Location = new System.Drawing.Point(508, 24);
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
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(576, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listBox_Absent
            // 
            this.listBox_Absent.FormattingEnabled = true;
            this.listBox_Absent.Location = new System.Drawing.Point(384, 154);
            this.listBox_Absent.Name = "listBox_Absent";
            this.listBox_Absent.Size = new System.Drawing.Size(180, 238);
            this.listBox_Absent.TabIndex = 20;
            // 
            // l_Absent
            // 
            this.l_Absent.AutoSize = true;
            this.l_Absent.Location = new System.Drawing.Point(381, 138);
            this.l_Absent.Name = "l_Absent";
            this.l_Absent.Size = new System.Drawing.Size(40, 13);
            this.l_Absent.TabIndex = 19;
            this.l_Absent.Text = "Absent";
            // 
            // f_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(576, 404);
            this.Controls.Add(this.listBox_Absent);
            this.Controls.Add(this.l_Absent);
            this.Controls.Add(this.l_Clock);
            this.Controls.Add(this.listBox_SignedIn);
            this.Controls.Add(this.l_SignedIn);
            this.Controls.Add(this.l_Pending);
            this.Controls.Add(this.l_CourseCode);
            this.Controls.Add(this.listBox_Pending);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "f_MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_Pending;
        private System.Windows.Forms.Label l_CourseCode;
        private System.Windows.Forms.Label l_Pending;
        private System.Windows.Forms.Label l_SignedIn;
        private System.Windows.Forms.ListBox listBox_SignedIn;
        private System.Windows.Forms.Label l_Clock;
        private System.Windows.Forms.Timer timer_Clock;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox listBox_Absent;
        private System.Windows.Forms.Label l_Absent;
    }
}

