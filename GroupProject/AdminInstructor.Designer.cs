namespace GroupProject
{
    partial class AdminInstructor
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
            this.InstructorComboBox = new System.Windows.Forms.ComboBox();
            this.btnAdminInstructorClose = new System.Windows.Forms.Button();
            this.btnAdminInstructorClear = new System.Windows.Forms.Button();
            this.btnAdminInstructorSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxInstructorFirstName = new System.Windows.Forms.TextBox();
            this.txtbxInstructorLastName = new System.Windows.Forms.TextBox();
            this.instructorUpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Instructor to Update or Enter New";
            // 
            // InstructorComboBox
            // 
            this.InstructorComboBox.FormattingEnabled = true;
            this.InstructorComboBox.Location = new System.Drawing.Point(55, 71);
            this.InstructorComboBox.Name = "InstructorComboBox";
            this.InstructorComboBox.Size = new System.Drawing.Size(196, 21);
            this.InstructorComboBox.TabIndex = 1;
            this.InstructorComboBox.SelectedIndexChanged += new System.EventHandler(this.InstructorComboBox_SelectedIndexChanged);
            // 
            // btnAdminInstructorClose
            // 
            this.btnAdminInstructorClose.Location = new System.Drawing.Point(23, 198);
            this.btnAdminInstructorClose.Name = "btnAdminInstructorClose";
            this.btnAdminInstructorClose.Size = new System.Drawing.Size(75, 23);
            this.btnAdminInstructorClose.TabIndex = 2;
            this.btnAdminInstructorClose.Text = "Close";
            this.btnAdminInstructorClose.UseVisualStyleBackColor = true;
            this.btnAdminInstructorClose.Click += new System.EventHandler(this.btnAdminInstructorClose_Click);
            // 
            // btnAdminInstructorClear
            // 
            this.btnAdminInstructorClear.Location = new System.Drawing.Point(120, 198);
            this.btnAdminInstructorClear.Name = "btnAdminInstructorClear";
            this.btnAdminInstructorClear.Size = new System.Drawing.Size(75, 23);
            this.btnAdminInstructorClear.TabIndex = 3;
            this.btnAdminInstructorClear.Text = "Clear";
            this.btnAdminInstructorClear.UseVisualStyleBackColor = true;
            this.btnAdminInstructorClear.Click += new System.EventHandler(this.btnAdminInstructorClear_Click);
            // 
            // btnAdminInstructorSave
            // 
            this.btnAdminInstructorSave.Location = new System.Drawing.Point(219, 198);
            this.btnAdminInstructorSave.Name = "btnAdminInstructorSave";
            this.btnAdminInstructorSave.Size = new System.Drawing.Size(75, 23);
            this.btnAdminInstructorSave.TabIndex = 4;
            this.btnAdminInstructorSave.Text = "Save";
            this.btnAdminInstructorSave.UseVisualStyleBackColor = true;
            this.btnAdminInstructorSave.Click += new System.EventHandler(this.btnAdminInstructorSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // txtbxInstructorFirstName
            // 
            this.txtbxInstructorFirstName.Location = new System.Drawing.Point(120, 119);
            this.txtbxInstructorFirstName.Name = "txtbxInstructorFirstName";
            this.txtbxInstructorFirstName.Size = new System.Drawing.Size(174, 20);
            this.txtbxInstructorFirstName.TabIndex = 7;
            // 
            // txtbxInstructorLastName
            // 
            this.txtbxInstructorLastName.Location = new System.Drawing.Point(120, 155);
            this.txtbxInstructorLastName.Name = "txtbxInstructorLastName";
            this.txtbxInstructorLastName.Size = new System.Drawing.Size(174, 20);
            this.txtbxInstructorLastName.TabIndex = 8;
            // 
            // instructorUpdateButton
            // 
            this.instructorUpdateButton.Location = new System.Drawing.Point(120, 244);
            this.instructorUpdateButton.Name = "instructorUpdateButton";
            this.instructorUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.instructorUpdateButton.TabIndex = 9;
            this.instructorUpdateButton.Text = "&Update";
            this.instructorUpdateButton.UseVisualStyleBackColor = true;
            this.instructorUpdateButton.Click += new System.EventHandler(this.instructorUpdateButton_Click);
            // 
            // AdminInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 279);
            this.Controls.Add(this.instructorUpdateButton);
            this.Controls.Add(this.txtbxInstructorLastName);
            this.Controls.Add(this.txtbxInstructorFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdminInstructorSave);
            this.Controls.Add(this.btnAdminInstructorClear);
            this.Controls.Add(this.btnAdminInstructorClose);
            this.Controls.Add(this.InstructorComboBox);
            this.Controls.Add(this.label1);
            this.Name = "AdminInstructor";
            this.Text = "AdminInstructor";
            this.Load += new System.EventHandler(this.AdminInstructor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox InstructorComboBox;
        private System.Windows.Forms.Button btnAdminInstructorClose;
        private System.Windows.Forms.Button btnAdminInstructorClear;
        private System.Windows.Forms.Button btnAdminInstructorSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxInstructorFirstName;
        private System.Windows.Forms.TextBox txtbxInstructorLastName;
        private System.Windows.Forms.Button instructorUpdateButton;
    }
}