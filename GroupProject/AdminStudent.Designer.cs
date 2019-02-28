namespace GroupProject
{
    partial class AdminStudent
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
            this.btnAdminAddStudent = new System.Windows.Forms.Button();
            this.txtbxStuFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxStuLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentComboBox = new System.Windows.Forms.ComboBox();
            this.btnAdminStudentClear = new System.Windows.Forms.Button();
            this.btnAdminStudentClose = new System.Windows.Forms.Button();
            this.studentUpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Student to Update or Enter New ";
            // 
            // btnAdminAddStudent
            // 
            this.btnAdminAddStudent.Location = new System.Drawing.Point(211, 178);
            this.btnAdminAddStudent.Name = "btnAdminAddStudent";
            this.btnAdminAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAdminAddStudent.TabIndex = 1;
            this.btnAdminAddStudent.Text = "Save";
            this.btnAdminAddStudent.UseVisualStyleBackColor = true;
            this.btnAdminAddStudent.Click += new System.EventHandler(this.btnAdminAddStudent_Click);
            // 
            // txtbxStuFirstName
            // 
            this.txtbxStuFirstName.Location = new System.Drawing.Point(115, 91);
            this.txtbxStuFirstName.Name = "txtbxStuFirstName";
            this.txtbxStuFirstName.Size = new System.Drawing.Size(160, 20);
            this.txtbxStuFirstName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // txtbxStuLastName
            // 
            this.txtbxStuLastName.Location = new System.Drawing.Point(115, 137);
            this.txtbxStuLastName.Name = "txtbxStuLastName";
            this.txtbxStuLastName.Size = new System.Drawing.Size(160, 20);
            this.txtbxStuLastName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // StudentComboBox
            // 
            this.StudentComboBox.FormattingEnabled = true;
            this.StudentComboBox.Location = new System.Drawing.Point(66, 48);
            this.StudentComboBox.Name = "StudentComboBox";
            this.StudentComboBox.Size = new System.Drawing.Size(178, 21);
            this.StudentComboBox.TabIndex = 6;
            this.StudentComboBox.SelectedIndexChanged += new System.EventHandler(this.StudentComboBox_SelectedIndexChanged);
            // 
            // btnAdminStudentClear
            // 
            this.btnAdminStudentClear.Location = new System.Drawing.Point(115, 178);
            this.btnAdminStudentClear.Name = "btnAdminStudentClear";
            this.btnAdminStudentClear.Size = new System.Drawing.Size(75, 23);
            this.btnAdminStudentClear.TabIndex = 7;
            this.btnAdminStudentClear.Text = "Clear";
            this.btnAdminStudentClear.UseVisualStyleBackColor = true;
            this.btnAdminStudentClear.Click += new System.EventHandler(this.btnAdminStudentClear_Click);
            // 
            // btnAdminStudentClose
            // 
            this.btnAdminStudentClose.Location = new System.Drawing.Point(12, 178);
            this.btnAdminStudentClose.Name = "btnAdminStudentClose";
            this.btnAdminStudentClose.Size = new System.Drawing.Size(75, 23);
            this.btnAdminStudentClose.TabIndex = 8;
            this.btnAdminStudentClose.Text = "Close";
            this.btnAdminStudentClose.UseVisualStyleBackColor = true;
            this.btnAdminStudentClose.Click += new System.EventHandler(this.btnAdminStudentClose_Click);
            // 
            // studentUpdateButton
            // 
            this.studentUpdateButton.Location = new System.Drawing.Point(115, 216);
            this.studentUpdateButton.Name = "studentUpdateButton";
            this.studentUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.studentUpdateButton.TabIndex = 9;
            this.studentUpdateButton.Text = "&Update";
            this.studentUpdateButton.UseVisualStyleBackColor = true;
            this.studentUpdateButton.Click += new System.EventHandler(this.studentUpdateButton_Click);
            // 
            // AdminStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 251);
            this.Controls.Add(this.studentUpdateButton);
            this.Controls.Add(this.btnAdminStudentClose);
            this.Controls.Add(this.btnAdminStudentClear);
            this.Controls.Add(this.StudentComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbxStuLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxStuFirstName);
            this.Controls.Add(this.btnAdminAddStudent);
            this.Controls.Add(this.label1);
            this.Name = "AdminStudent";
            this.Text = "AdminStudent";
            this.Load += new System.EventHandler(this.AdminStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdminAddStudent;
        private System.Windows.Forms.TextBox txtbxStuFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxStuLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox StudentComboBox;
        private System.Windows.Forms.Button btnAdminStudentClear;
        private System.Windows.Forms.Button btnAdminStudentClose;
        private System.Windows.Forms.Button studentUpdateButton;
    }
}