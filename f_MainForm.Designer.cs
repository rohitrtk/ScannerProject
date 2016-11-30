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
            this.toolStripMenuItem_Class = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_AddOrRemoveStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_Absent = new System.Windows.Forms.ListBox();
            this.l_Absent = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.l_Late = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Pending
            // 
            this.listBox_Pending.FormattingEnabled = true;
            this.listBox_Pending.Location = new System.Drawing.Point(13, 72);
            this.listBox_Pending.Name = "listBox_Pending";
            this.listBox_Pending.Size = new System.Drawing.Size(180, 238);
            this.listBox_Pending.TabIndex = 2;
            // 
            // l_CourseCode
            // 
            this.l_CourseCode.AutoSize = true;
            this.l_CourseCode.Location = new System.Drawing.Point(627, 24);
            this.l_CourseCode.Name = "l_CourseCode";
            this.l_CourseCode.Size = new System.Drawing.Size(68, 13);
            this.l_CourseCode.TabIndex = 8;
            this.l_CourseCode.Text = "Course Code";
            // 
            // l_Pending
            // 
            this.l_Pending.AutoSize = true;
            this.l_Pending.Location = new System.Drawing.Point(13, 56);
            this.l_Pending.Name = "l_Pending";
            this.l_Pending.Size = new System.Drawing.Size(46, 13);
            this.l_Pending.TabIndex = 11;
            this.l_Pending.Text = "Pending";
            // 
            // l_SignedIn
            // 
            this.l_SignedIn.AutoSize = true;
            this.l_SignedIn.Location = new System.Drawing.Point(196, 56);
            this.l_SignedIn.Name = "l_SignedIn";
            this.l_SignedIn.Size = new System.Drawing.Size(52, 13);
            this.l_SignedIn.TabIndex = 12;
            this.l_SignedIn.Text = "Signed In";
            // 
            // listBox_SignedIn
            // 
            this.listBox_SignedIn.FormattingEnabled = true;
            this.listBox_SignedIn.Location = new System.Drawing.Point(199, 72);
            this.listBox_SignedIn.Name = "listBox_SignedIn";
            this.listBox_SignedIn.Size = new System.Drawing.Size(180, 238);
            this.listBox_SignedIn.TabIndex = 15;
            // 
            // l_Clock
            // 
            this.l_Clock.AutoSize = true;
            this.l_Clock.Location = new System.Drawing.Point(627, 47);
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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Class});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem_Class
            // 
            this.toolStripMenuItem_Class.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_AddOrRemoveStudent});
            this.toolStripMenuItem_Class.Name = "toolStripMenuItem_Class";
            this.toolStripMenuItem_Class.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem_Class.Text = "Class";
            // 
            // toolStripMenuItem_AddOrRemoveStudent
            // 
            this.toolStripMenuItem_AddOrRemoveStudent.Name = "toolStripMenuItem_AddOrRemoveStudent";
            this.toolStripMenuItem_AddOrRemoveStudent.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem_AddOrRemoveStudent.Text = "Add/Remove Student";
            this.toolStripMenuItem_AddOrRemoveStudent.Click += new System.EventHandler(this.toolStripMenuItem_AddOrRemoveStudent_Click);
            // 
            // listBox_Absent
            // 
            this.listBox_Absent.FormattingEnabled = true;
            this.listBox_Absent.Location = new System.Drawing.Point(571, 72);
            this.listBox_Absent.Name = "listBox_Absent";
            this.listBox_Absent.Size = new System.Drawing.Size(180, 238);
            this.listBox_Absent.TabIndex = 20;
            // 
            // l_Absent
            // 
            this.l_Absent.AutoSize = true;
            this.l_Absent.Location = new System.Drawing.Point(568, 56);
            this.l_Absent.Name = "l_Absent";
            this.l_Absent.Size = new System.Drawing.Size(40, 13);
            this.l_Absent.TabIndex = 19;
            this.l_Absent.Text = "Absent";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(385, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 238);
            this.listBox1.TabIndex = 21;
            // 
            // l_Late
            // 
            this.l_Late.AutoSize = true;
            this.l_Late.Location = new System.Drawing.Point(382, 56);
            this.l_Late.Name = "l_Late";
            this.l_Late.Size = new System.Drawing.Size(28, 13);
            this.l_Late.TabIndex = 22;
            this.l_Late.Text = "Late";
            // 
            // f_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(763, 322);
            this.Controls.Add(this.l_Late);
            this.Controls.Add(this.listBox1);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label l_Late;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Class;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_AddOrRemoveStudent;
    }
}

