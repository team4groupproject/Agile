namespace GroupProject
{
    partial class Instructor
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
            this.cmboBoxInstructorCourses = new System.Windows.Forms.ComboBox();
            this.lstbxCourseStudents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStuFirstName = new System.Windows.Forms.Label();
            this.lblStuLastName = new System.Windows.Forms.Label();
            this.lblStuCourseID = new System.Windows.Forms.Label();
            this.txtbxStuGrade = new System.Windows.Forms.TextBox();
            this.btnClearInstructor = new System.Windows.Forms.Button();
            this.btnExitInstructor = new System.Windows.Forms.Button();
            this.btnUpdateGrade = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxINSTid = new System.Windows.Forms.TextBox();
            this.btnIDokay = new System.Windows.Forms.Button();
            this.lblRegistrationID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmboBoxInstructorCourses
            // 
            this.cmboBoxInstructorCourses.FormattingEnabled = true;
            this.cmboBoxInstructorCourses.Location = new System.Drawing.Point(75, 92);
            this.cmboBoxInstructorCourses.Name = "cmboBoxInstructorCourses";
            this.cmboBoxInstructorCourses.Size = new System.Drawing.Size(278, 21);
            this.cmboBoxInstructorCourses.TabIndex = 3;
            this.cmboBoxInstructorCourses.SelectedIndexChanged += new System.EventHandler(this.cmboBoxInstructorCourses_SelectedIndexChanged);
            // 
            // lstbxCourseStudents
            // 
            this.lstbxCourseStudents.FormattingEnabled = true;
            this.lstbxCourseStudents.Location = new System.Drawing.Point(12, 142);
            this.lstbxCourseStudents.Name = "lstbxCourseStudents";
            this.lstbxCourseStudents.Size = new System.Drawing.Size(178, 212);
            this.lstbxCourseStudents.TabIndex = 4;
            this.lstbxCourseStudents.SelectedIndexChanged += new System.EventHandler(this.lstbxCourseStudents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Course ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Grade";
            // 
            // lblStuFirstName
            // 
            this.lblStuFirstName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStuFirstName.Location = new System.Drawing.Point(279, 146);
            this.lblStuFirstName.Name = "lblStuFirstName";
            this.lblStuFirstName.Size = new System.Drawing.Size(142, 23);
            this.lblStuFirstName.TabIndex = 5;
            // 
            // lblStuLastName
            // 
            this.lblStuLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStuLastName.Location = new System.Drawing.Point(279, 169);
            this.lblStuLastName.Name = "lblStuLastName";
            this.lblStuLastName.Size = new System.Drawing.Size(142, 23);
            this.lblStuLastName.TabIndex = 6;
            // 
            // lblStuCourseID
            // 
            this.lblStuCourseID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStuCourseID.Location = new System.Drawing.Point(279, 192);
            this.lblStuCourseID.Name = "lblStuCourseID";
            this.lblStuCourseID.Size = new System.Drawing.Size(142, 23);
            this.lblStuCourseID.TabIndex = 7;
            // 
            // txtbxStuGrade
            // 
            this.txtbxStuGrade.Location = new System.Drawing.Point(279, 264);
            this.txtbxStuGrade.Name = "txtbxStuGrade";
            this.txtbxStuGrade.Size = new System.Drawing.Size(74, 20);
            this.txtbxStuGrade.TabIndex = 9;
            // 
            // btnClearInstructor
            // 
            this.btnClearInstructor.Location = new System.Drawing.Point(219, 331);
            this.btnClearInstructor.Name = "btnClearInstructor";
            this.btnClearInstructor.Size = new System.Drawing.Size(75, 23);
            this.btnClearInstructor.TabIndex = 11;
            this.btnClearInstructor.Text = "Clear";
            this.btnClearInstructor.UseVisualStyleBackColor = true;
            this.btnClearInstructor.Click += new System.EventHandler(this.btnClearInstructor_Click);
            // 
            // btnExitInstructor
            // 
            this.btnExitInstructor.Location = new System.Drawing.Point(328, 331);
            this.btnExitInstructor.Name = "btnExitInstructor";
            this.btnExitInstructor.Size = new System.Drawing.Size(75, 23);
            this.btnExitInstructor.TabIndex = 12;
            this.btnExitInstructor.Text = "Close";
            this.btnExitInstructor.UseVisualStyleBackColor = true;
            this.btnExitInstructor.Click += new System.EventHandler(this.btnExitInstructor_Click);
            // 
            // btnUpdateGrade
            // 
            this.btnUpdateGrade.Location = new System.Drawing.Point(237, 302);
            this.btnUpdateGrade.Name = "btnUpdateGrade";
            this.btnUpdateGrade.Size = new System.Drawing.Size(134, 23);
            this.btnUpdateGrade.TabIndex = 10;
            this.btnUpdateGrade.Text = "Update Grade";
            this.btnUpdateGrade.UseVisualStyleBackColor = true;
            this.btnUpdateGrade.Click += new System.EventHandler(this.btnUpdateGrade_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "For Instructors";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Enter Your ID then click Okay";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Your Courses";
            // 
            // txtBoxINSTid
            // 
            this.txtBoxINSTid.Location = new System.Drawing.Point(262, 35);
            this.txtBoxINSTid.Name = "txtBoxINSTid";
            this.txtBoxINSTid.Size = new System.Drawing.Size(72, 20);
            this.txtBoxINSTid.TabIndex = 0;
            // 
            // btnIDokay
            // 
            this.btnIDokay.Location = new System.Drawing.Point(346, 33);
            this.btnIDokay.Name = "btnIDokay";
            this.btnIDokay.Size = new System.Drawing.Size(75, 23);
            this.btnIDokay.TabIndex = 1;
            this.btnIDokay.Text = "Okay";
            this.btnIDokay.UseVisualStyleBackColor = true;
            this.btnIDokay.Click += new System.EventHandler(this.btnIDokay_Click);
            // 
            // lblRegistrationID
            // 
            this.lblRegistrationID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRegistrationID.Location = new System.Drawing.Point(279, 215);
            this.lblRegistrationID.Name = "lblRegistrationID";
            this.lblRegistrationID.Size = new System.Drawing.Size(142, 23);
            this.lblRegistrationID.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Registration ID";
            // 
            // Instructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 366);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblRegistrationID);
            this.Controls.Add(this.btnIDokay);
            this.Controls.Add(this.txtBoxINSTid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdateGrade);
            this.Controls.Add(this.btnExitInstructor);
            this.Controls.Add(this.btnClearInstructor);
            this.Controls.Add(this.txtbxStuGrade);
            this.Controls.Add(this.lblStuCourseID);
            this.Controls.Add(this.lblStuLastName);
            this.Controls.Add(this.lblStuFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbxCourseStudents);
            this.Controls.Add(this.cmboBoxInstructorCourses);
            this.Name = "Instructor";
            this.Text = "Instructor";
            this.Load += new System.EventHandler(this.Instructor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboBoxInstructorCourses;
        private System.Windows.Forms.ListBox lstbxCourseStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStuFirstName;
        private System.Windows.Forms.Label lblStuLastName;
        private System.Windows.Forms.Label lblStuCourseID;
        private System.Windows.Forms.TextBox txtbxStuGrade;
        private System.Windows.Forms.Button btnClearInstructor;
        private System.Windows.Forms.Button btnExitInstructor;
        private System.Windows.Forms.Button btnUpdateGrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxINSTid;
        private System.Windows.Forms.Button btnIDokay;
        private System.Windows.Forms.Label lblRegistrationID;
        private System.Windows.Forms.Label label8;
    }
}