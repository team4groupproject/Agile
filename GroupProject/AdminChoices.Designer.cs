namespace GroupProject
{
    partial class AdminChoices
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
            this.btnAdminStudentChoice = new System.Windows.Forms.Button();
            this.btnAdminInstructorChoice = new System.Windows.Forms.Button();
            this.btnAdminCourseChoice = new System.Windows.Forms.Button();
            this.btnAdminChoicesClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminStudentChoice
            // 
            this.btnAdminStudentChoice.Location = new System.Drawing.Point(54, 43);
            this.btnAdminStudentChoice.Name = "btnAdminStudentChoice";
            this.btnAdminStudentChoice.Size = new System.Drawing.Size(171, 23);
            this.btnAdminStudentChoice.TabIndex = 0;
            this.btnAdminStudentChoice.Text = "Add Or Update Student";
            this.btnAdminStudentChoice.UseVisualStyleBackColor = true;
            this.btnAdminStudentChoice.Click += new System.EventHandler(this.btnAdminStudentChoice_Click);
            // 
            // btnAdminInstructorChoice
            // 
            this.btnAdminInstructorChoice.Location = new System.Drawing.Point(54, 101);
            this.btnAdminInstructorChoice.Name = "btnAdminInstructorChoice";
            this.btnAdminInstructorChoice.Size = new System.Drawing.Size(171, 23);
            this.btnAdminInstructorChoice.TabIndex = 1;
            this.btnAdminInstructorChoice.Text = "Add or Update Instructor";
            this.btnAdminInstructorChoice.UseVisualStyleBackColor = true;
            this.btnAdminInstructorChoice.Click += new System.EventHandler(this.btnAdminInstructorChoice_Click);
            // 
            // btnAdminCourseChoice
            // 
            this.btnAdminCourseChoice.Location = new System.Drawing.Point(54, 155);
            this.btnAdminCourseChoice.Name = "btnAdminCourseChoice";
            this.btnAdminCourseChoice.Size = new System.Drawing.Size(171, 23);
            this.btnAdminCourseChoice.TabIndex = 2;
            this.btnAdminCourseChoice.Text = "Add or Update Course";
            this.btnAdminCourseChoice.UseVisualStyleBackColor = true;
            this.btnAdminCourseChoice.Click += new System.EventHandler(this.btnAdminCourseChoice_Click);
            // 
            // btnAdminChoicesClose
            // 
            this.btnAdminChoicesClose.Location = new System.Drawing.Point(94, 211);
            this.btnAdminChoicesClose.Name = "btnAdminChoicesClose";
            this.btnAdminChoicesClose.Size = new System.Drawing.Size(75, 23);
            this.btnAdminChoicesClose.TabIndex = 3;
            this.btnAdminChoicesClose.Text = "Close";
            this.btnAdminChoicesClose.UseVisualStyleBackColor = true;
            this.btnAdminChoicesClose.Click += new System.EventHandler(this.btnAdminChoicesClose_Click);
            // 
            // AdminChoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAdminChoicesClose);
            this.Controls.Add(this.btnAdminCourseChoice);
            this.Controls.Add(this.btnAdminInstructorChoice);
            this.Controls.Add(this.btnAdminStudentChoice);
            this.Name = "AdminChoices";
            this.Text = "AdminChoices";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminStudentChoice;
        private System.Windows.Forms.Button btnAdminInstructorChoice;
        private System.Windows.Forms.Button btnAdminCourseChoice;
        private System.Windows.Forms.Button btnAdminChoicesClose;
    }
}