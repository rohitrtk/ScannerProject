namespace ScannerProject
{
    partial class f_GraceTime
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
            this.b_Save = new System.Windows.Forms.Button();
            this.l_GraceTime = new System.Windows.Forms.Label();
            this.textBox_GraceTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_Save
            // 
            this.b_Save.Location = new System.Drawing.Point(107, 51);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(75, 23);
            this.b_Save.TabIndex = 0;
            this.b_Save.Text = "Save";
            this.b_Save.UseVisualStyleBackColor = true;
            this.b_Save.Click += new System.EventHandler(this.b_Save_Click);
            // 
            // l_GraceTime
            // 
            this.l_GraceTime.AutoSize = true;
            this.l_GraceTime.Location = new System.Drawing.Point(88, 9);
            this.l_GraceTime.Name = "l_GraceTime";
            this.l_GraceTime.Size = new System.Drawing.Size(113, 13);
            this.l_GraceTime.TabIndex = 1;
            this.l_GraceTime.Text = "Grace Time (Seconds)";
            // 
            // textBox_GraceTime
            // 
            this.textBox_GraceTime.Location = new System.Drawing.Point(88, 25);
            this.textBox_GraceTime.Name = "textBox_GraceTime";
            this.textBox_GraceTime.Size = new System.Drawing.Size(113, 20);
            this.textBox_GraceTime.TabIndex = 2;
            this.textBox_GraceTime.TextChanged += new System.EventHandler(this.textBox_GraceTime_TextChanged);
            // 
            // f_GraceTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(288, 79);
            this.Controls.Add(this.textBox_GraceTime);
            this.Controls.Add(this.l_GraceTime);
            this.Controls.Add(this.b_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "f_GraceTime";
            this.Text = "Late Buster: Grace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Save;
        private System.Windows.Forms.Label l_GraceTime;
        private System.Windows.Forms.TextBox textBox_GraceTime;
    }
}