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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.b_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(289, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 316);
            this.listBox1.TabIndex = 0;
            // 
            // b_Save
            // 
            this.b_Save.Location = new System.Drawing.Point(12, 304);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(75, 23);
            this.b_Save.TabIndex = 1;
            this.b_Save.Text = "Save";
            this.b_Save.UseVisualStyleBackColor = true;
            // 
            // f_AddOrRemoveStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 339);
            this.Controls.Add(this.b_Save);
            this.Controls.Add(this.listBox1);
            this.Name = "f_AddOrRemoveStudentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button b_Save;
    }
}