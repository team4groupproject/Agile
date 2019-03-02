namespace GroupProject
{
    partial class StudentChoices
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
            this.btnExit = new System.Windows.Forms.Button();
            this.tinyCollegeDBDataSet = new GroupProject.TinyCollegeDBDataSet();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new GroupProject.TinyCollegeDBDataSetTableAdapters.courseTableAdapter();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.btnFindStudentID = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.txtEarnedCredits = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastNameStudent = new System.Windows.Forms.TextBox();
            this.txtFirstNameStudent = new System.Windows.Forms.TextBox();
            this.sessionTableAdapter = new GroupProject.TinyCollegeDBDataSetTableAdapters.sessionTableAdapter();
            this.registrationTableAdapter = new GroupProject.TinyCollegeDBDataSetTableAdapters.registrationTableAdapter();
            this.fksessioncourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fkregistrationsessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tinyCollegeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fksessioncourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkregistrationsessionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(154, 425);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 29);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // tinyCollegeDBDataSet
            // 
            this.tinyCollegeDBDataSet.DataSetName = "TinyCollegeDBDataSet";
            this.tinyCollegeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            this.courseBindingSource.DataSource = this.tinyCollegeDBDataSet;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Enabled = false;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(109, 60);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(169, 32);
            this.btnRegister.TabIndex = 21;
            this.btnRegister.Text = "Register for Classes";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter Student ID:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(139, 14);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(114, 24);
            this.txtStudentID.TabIndex = 13;
            // 
            // btnFindStudentID
            // 
            this.btnFindStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindStudentID.Location = new System.Drawing.Point(259, 12);
            this.btnFindStudentID.Name = "btnFindStudentID";
            this.btnFindStudentID.Size = new System.Drawing.Size(54, 26);
            this.btnFindStudentID.TabIndex = 12;
            this.btnFindStudentID.Text = "Find";
            this.btnFindStudentID.UseVisualStyleBackColor = true;
            this.btnFindStudentID.Click += new System.EventHandler(this.btnFindStudentID_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtEarnedCredits);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLastNameStudent);
            this.groupBox1.Controls.Add(this.txtFirstNameStudent);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 292);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCourses);
            this.groupBox2.Location = new System.Drawing.Point(7, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 149);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Completed Courses:";
            // 
            // dgvCourses
            // 
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(6, 19);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.Size = new System.Drawing.Size(321, 130);
            this.dgvCourses.TabIndex = 0;
            // 
            // txtEarnedCredits
            // 
            this.txtEarnedCredits.Enabled = false;
            this.txtEarnedCredits.Location = new System.Drawing.Point(200, 111);
            this.txtEarnedCredits.Name = "txtEarnedCredits";
            this.txtEarnedCredits.Size = new System.Drawing.Size(55, 24);
            this.txtEarnedCredits.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Credits Earned:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "First Name:";
            // 
            // txtLastNameStudent
            // 
            this.txtLastNameStudent.Enabled = false;
            this.txtLastNameStudent.Location = new System.Drawing.Point(127, 64);
            this.txtLastNameStudent.Name = "txtLastNameStudent";
            this.txtLastNameStudent.Size = new System.Drawing.Size(171, 24);
            this.txtLastNameStudent.TabIndex = 24;
            // 
            // txtFirstNameStudent
            // 
            this.txtFirstNameStudent.Enabled = false;
            this.txtFirstNameStudent.Location = new System.Drawing.Point(127, 26);
            this.txtFirstNameStudent.Name = "txtFirstNameStudent";
            this.txtFirstNameStudent.Size = new System.Drawing.Size(171, 24);
            this.txtFirstNameStudent.TabIndex = 23;
            // 
            // sessionTableAdapter
            // 
            this.sessionTableAdapter.ClearBeforeFill = true;
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // fksessioncourseBindingSource
            // 
            this.fksessioncourseBindingSource.DataMember = "fk_session_course";
            this.fksessioncourseBindingSource.DataSource = this.courseBindingSource;
            // 
            // fkregistrationsessionBindingSource
            // 
            this.fkregistrationsessionBindingSource.DataMember = "fk_registration_session";
            this.fkregistrationsessionBindingSource.DataSource = this.fksessioncourseBindingSource;
            // 
            // StudentChoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.btnFindStudentID);
            this.Controls.Add(this.btnExit);
            this.Name = "StudentChoices";
            this.Text = "For Students";
            this.Load += new System.EventHandler(this.StudentChoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tinyCollegeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fksessioncourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkregistrationsessionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private TinyCollegeDBDataSet tinyCollegeDBDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private TinyCollegeDBDataSetTableAdapters.courseTableAdapter courseTableAdapter;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button btnFindStudentID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEarnedCredits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastNameStudent;
        private System.Windows.Forms.TextBox txtFirstNameStudent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource fksessioncourseBindingSource;
        private TinyCollegeDBDataSetTableAdapters.sessionTableAdapter sessionTableAdapter;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.BindingSource fkregistrationsessionBindingSource;
        private TinyCollegeDBDataSetTableAdapters.registrationTableAdapter registrationTableAdapter;
        //private object tinyCollegeDBDataSet;
    }
}