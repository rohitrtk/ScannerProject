namespace ScannerProject
{
    partial class f_AddOrRemoveStudentForm
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
            this.listBox_StudentsInClass = new System.Windows.Forms.ListBox();
            this.b_Save = new System.Windows.Forms.Button();
            this.l_Help = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_StudentsInClass
            // 
            this.listBox_StudentsInClass.FormattingEnabled = true;
            this.listBox_StudentsInClass.Location = new System.Drawing.Point(292, 11);
            this.listBox_StudentsInClass.Name = "listBox_StudentsInClass";
            this.listBox_StudentsInClass.Size = new System.Drawing.Size(204, 316);
            this.listBox_StudentsInClass.TabIndex = 0;
            this.listBox_StudentsInClass.SelectedIndexChanged += new System.EventHandler(this.listBox_StudentsInClass_SelectedIndexChanged);
            // 
            // b_Save
            // 
            this.b_Save.Location = new System.Drawing.Point(52, 263);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(186, 64);
            this.b_Save.TabIndex = 1;
            this.b_Save.Text = "Save";
            this.b_Save.UseVisualStyleBackColor = true;
            this.b_Save.Click += new System.EventHandler(this.b_Save_Click);
            // 
            // l_Help
            // 
            this.l_Help.AutoSize = true;
            this.l_Help.Location = new System.Drawing.Point(13, 12);
            this.l_Help.Name = "l_Help";
            this.l_Help.Size = new System.Drawing.Size(37, 13);
            this.l_Help.TabIndex = 2;
            this.l_Help.Text = "l_Help";
            // 
            // f_AddOrRemoveStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 339);
            this.Controls.Add(this.l_Help);
            this.Controls.Add(this.b_Save);
            this.Controls.Add(this.listBox_StudentsInClass);
            this.Name = "f_AddOrRemoveStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_StudentsInClass;
        private System.Windows.Forms.Button b_Save;
        private System.Windows.Forms.Label l_Help;
    }
}