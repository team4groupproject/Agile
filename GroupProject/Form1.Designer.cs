namespace GroupProject
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
            this.btnAdministrator = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnMainFormExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdministrator
            // 
            this.btnAdministrator.Location = new System.Drawing.Point(49, 46);
            this.btnAdministrator.Name = "btnAdministrator";
            this.btnAdministrator.Size = new System.Drawing.Size(181, 34);
            this.btnAdministrator.TabIndex = 0;
            this.btnAdministrator.Text = "For Administrators";
            this.btnAdministrator.UseVisualStyleBackColor = true;
            this.btnAdministrator.Click += new System.EventHandler(this.btnAdministrator_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "For Instructors";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(49, 174);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(181, 32);
            this.btnStudents.TabIndex = 2;
            this.btnStudents.Text = "For Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            // 
            // btnMainFormExit
            // 
            this.btnMainFormExit.Location = new System.Drawing.Point(93, 222);
            this.btnMainFormExit.Name = "btnMainFormExit";
            this.btnMainFormExit.Size = new System.Drawing.Size(75, 23);
            this.btnMainFormExit.TabIndex = 3;
            this.btnMainFormExit.Text = "Exit";
            this.btnMainFormExit.UseVisualStyleBackColor = true;
            this.btnMainFormExit.Click += new System.EventHandler(this.btnMainFormExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 257);
            this.Controls.Add(this.btnMainFormExit);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdministrator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdministrator;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnMainFormExit;
    }
}

