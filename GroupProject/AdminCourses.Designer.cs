namespace GroupProject
{
    partial class AdminCourses
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
            this.label1 = new System.Windows.Forms.Label();
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SessionComboBox = new System.Windows.Forms.ComboBox();
            this.btnAdminCourseClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbxSessionCourseId = new System.Windows.Forms.TextBox();
            this.txtbxSessionInstructorId = new System.Windows.Forms.TextBox();
            this.txtbxSessionSeatsFilled = new System.Windows.Forms.TextBox();
            this.btnSessinClear = new System.Windows.Forms.Button();
            this.btnSessionSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbxCourseName = new System.Windows.Forms.TextBox();
            this.txtbxCourseStatus = new System.Windows.Forms.TextBox();
            this.txtbxCourseCreditHours = new System.Windows.Forms.TextBox();
            this.txtbxCourseMaxSeats = new System.Windows.Forms.TextBox();
            this.btnCoursesClear = new System.Windows.Forms.Button();
            this.btnCourseSave = new System.Windows.Forms.Button();
            this.sessionUpdateButton = new System.Windows.Forms.Button();
            this.courseUpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Course to Update or Enter New";
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Location = new System.Drawing.Point(15, 61);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(185, 21);
            this.CourseComboBox.TabIndex = 1;
            this.CourseComboBox.SelectedIndexChanged += new System.EventHandler(this.CourseComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Session to Update or Enter New";
            // 
            // SessionComboBox
            // 
            this.SessionComboBox.FormattingEnabled = true;
            this.SessionComboBox.Location = new System.Drawing.Point(319, 61);
            this.SessionComboBox.Name = "SessionComboBox";
            this.SessionComboBox.Size = new System.Drawing.Size(189, 21);
            this.SessionComboBox.TabIndex = 3;
            this.SessionComboBox.SelectedIndexChanged += new System.EventHandler(this.SessionComboBox_SelectedIndexChanged);
            // 
            // btnAdminCourseClose
            // 
            this.btnAdminCourseClose.Location = new System.Drawing.Point(225, 271);
            this.btnAdminCourseClose.Name = "btnAdminCourseClose";
            this.btnAdminCourseClose.Size = new System.Drawing.Size(97, 23);
            this.btnAdminCourseClose.TabIndex = 4;
            this.btnAdminCourseClose.Text = "Close";
            this.btnAdminCourseClose.UseVisualStyleBackColor = true;
            this.btnAdminCourseClose.Click += new System.EventHandler(this.btnAdminCourseClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Session Course Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Session Instructor Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Session Seats Filled";
            // 
            // txtbxSessionCourseId
            // 
            this.txtbxSessionCourseId.Location = new System.Drawing.Point(409, 109);
            this.txtbxSessionCourseId.Name = "txtbxSessionCourseId";
            this.txtbxSessionCourseId.Size = new System.Drawing.Size(100, 20);
            this.txtbxSessionCourseId.TabIndex = 8;
            // 
            // txtbxSessionInstructorId
            // 
            this.txtbxSessionInstructorId.Location = new System.Drawing.Point(410, 152);
            this.txtbxSessionInstructorId.Name = "txtbxSessionInstructorId";
            this.txtbxSessionInstructorId.Size = new System.Drawing.Size(100, 20);
            this.txtbxSessionInstructorId.TabIndex = 9;
            // 
            // txtbxSessionSeatsFilled
            // 
            this.txtbxSessionSeatsFilled.Location = new System.Drawing.Point(409, 189);
            this.txtbxSessionSeatsFilled.Name = "txtbxSessionSeatsFilled";
            this.txtbxSessionSeatsFilled.Size = new System.Drawing.Size(100, 20);
            this.txtbxSessionSeatsFilled.TabIndex = 10;
            // 
            // btnSessinClear
            // 
            this.btnSessinClear.Location = new System.Drawing.Point(300, 228);
            this.btnSessinClear.Name = "btnSessinClear";
            this.btnSessinClear.Size = new System.Drawing.Size(103, 23);
            this.btnSessinClear.TabIndex = 11;
            this.btnSessinClear.Text = "Clear Session";
            this.btnSessinClear.UseVisualStyleBackColor = true;
            this.btnSessinClear.Click += new System.EventHandler(this.btnSessinClear_Click);
            // 
            // btnSessionSave
            // 
            this.btnSessionSave.Location = new System.Drawing.Point(421, 227);
            this.btnSessionSave.Name = "btnSessionSave";
            this.btnSessionSave.Size = new System.Drawing.Size(88, 23);
            this.btnSessionSave.TabIndex = 12;
            this.btnSessionSave.Text = "Session Save";
            this.btnSessionSave.UseVisualStyleBackColor = true;
            this.btnSessionSave.Click += new System.EventHandler(this.btnSessionSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Course Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Status (Y/N)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Credit Hours";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Max Number of Seats";
            // 
            // txtbxCourseName
            // 
            this.txtbxCourseName.Location = new System.Drawing.Point(100, 99);
            this.txtbxCourseName.Name = "txtbxCourseName";
            this.txtbxCourseName.Size = new System.Drawing.Size(135, 20);
            this.txtbxCourseName.TabIndex = 17;
            // 
            // txtbxCourseStatus
            // 
            this.txtbxCourseStatus.Location = new System.Drawing.Point(178, 130);
            this.txtbxCourseStatus.Name = "txtbxCourseStatus";
            this.txtbxCourseStatus.Size = new System.Drawing.Size(57, 20);
            this.txtbxCourseStatus.TabIndex = 18;
            // 
            // txtbxCourseCreditHours
            // 
            this.txtbxCourseCreditHours.Location = new System.Drawing.Point(172, 164);
            this.txtbxCourseCreditHours.Name = "txtbxCourseCreditHours";
            this.txtbxCourseCreditHours.Size = new System.Drawing.Size(63, 20);
            this.txtbxCourseCreditHours.TabIndex = 19;
            // 
            // txtbxCourseMaxSeats
            // 
            this.txtbxCourseMaxSeats.Location = new System.Drawing.Point(172, 196);
            this.txtbxCourseMaxSeats.Name = "txtbxCourseMaxSeats";
            this.txtbxCourseMaxSeats.Size = new System.Drawing.Size(63, 20);
            this.txtbxCourseMaxSeats.TabIndex = 20;
            // 
            // btnCoursesClear
            // 
            this.btnCoursesClear.Location = new System.Drawing.Point(14, 228);
            this.btnCoursesClear.Name = "btnCoursesClear";
            this.btnCoursesClear.Size = new System.Drawing.Size(92, 23);
            this.btnCoursesClear.TabIndex = 21;
            this.btnCoursesClear.Text = "Clear Course";
            this.btnCoursesClear.UseVisualStyleBackColor = true;
            this.btnCoursesClear.Click += new System.EventHandler(this.btnCoursesClear_Click);
            // 
            // btnCourseSave
            // 
            this.btnCourseSave.Location = new System.Drawing.Point(138, 227);
            this.btnCourseSave.Name = "btnCourseSave";
            this.btnCourseSave.Size = new System.Drawing.Size(97, 23);
            this.btnCourseSave.TabIndex = 22;
            this.btnCourseSave.Text = "Course Save";
            this.btnCourseSave.UseVisualStyleBackColor = true;
            this.btnCourseSave.Click += new System.EventHandler(this.btnCourseSave_Click);
            // 
            // sessionUpdateButton
            // 
            this.sessionUpdateButton.Location = new System.Drawing.Point(377, 271);
            this.sessionUpdateButton.Name = "sessionUpdateButton";
            this.sessionUpdateButton.Size = new System.Drawing.Size(97, 23);
            this.sessionUpdateButton.TabIndex = 23;
            this.sessionUpdateButton.Text = "Up&date Session";
            this.sessionUpdateButton.UseVisualStyleBackColor = true;
            this.sessionUpdateButton.Click += new System.EventHandler(this.sessionUpdateButton_Click);
            // 
            // courseUpdateButton
            // 
            this.courseUpdateButton.Location = new System.Drawing.Point(82, 271);
            this.courseUpdateButton.Name = "courseUpdateButton";
            this.courseUpdateButton.Size = new System.Drawing.Size(97, 23);
            this.courseUpdateButton.TabIndex = 24;
            this.courseUpdateButton.Text = "&Update Course";
            this.courseUpdateButton.UseVisualStyleBackColor = true;
            this.courseUpdateButton.Click += new System.EventHandler(this.courseUpdateButton_Click);
            // 
            // AdminCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 306);
            this.Controls.Add(this.courseUpdateButton);
            this.Controls.Add(this.sessionUpdateButton);
            this.Controls.Add(this.btnCourseSave);
            this.Controls.Add(this.btnCoursesClear);
            this.Controls.Add(this.txtbxCourseMaxSeats);
            this.Controls.Add(this.txtbxCourseCreditHours);
            this.Controls.Add(this.txtbxCourseStatus);
            this.Controls.Add(this.txtbxCourseName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSessionSave);
            this.Controls.Add(this.btnSessinClear);
            this.Controls.Add(this.txtbxSessionSeatsFilled);
            this.Controls.Add(this.txtbxSessionInstructorId);
            this.Controls.Add(this.txtbxSessionCourseId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdminCourseClose);
            this.Controls.Add(this.SessionComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.label1);
            this.Name = "AdminCourses";
            this.Text = "AdminCourses";
            this.Load += new System.EventHandler(this.AdminCourses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SessionComboBox;
        private System.Windows.Forms.Button btnAdminCourseClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbxSessionCourseId;
        private System.Windows.Forms.TextBox txtbxSessionInstructorId;
        private System.Windows.Forms.TextBox txtbxSessionSeatsFilled;
        private System.Windows.Forms.Button btnSessinClear;
        private System.Windows.Forms.Button btnSessionSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbxCourseName;
        private System.Windows.Forms.TextBox txtbxCourseStatus;
        private System.Windows.Forms.TextBox txtbxCourseCreditHours;
        private System.Windows.Forms.TextBox txtbxCourseMaxSeats;
        private System.Windows.Forms.Button btnCoursesClear;
        private System.Windows.Forms.Button btnCourseSave;
        private System.Windows.Forms.Button sessionUpdateButton;
        private System.Windows.Forms.Button courseUpdateButton;
    }
}