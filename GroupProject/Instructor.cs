﻿using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class Instructor : Form
    {
        //declare string variable
        string connectionString;
        SqlConnection conn;

        int instructorEnteredID;

        public Instructor()
        {
            //assign value to variable conn
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["GroupProject.Properties.Settings.TinyCollegeDBConnectionString"].ConnectionString;
        }
        //Exits instructor form upon activation
        private void btnExitInstructor_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Sets up for user input on activation
        private void Instructor_Load(object sender, EventArgs e)
        {
            txtBoxINSTid.Focus();
        }
        //Fills SQL Database values into ComboBox
        private void cmboBoxInstructorCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
                if (cmboBoxInstructorCourses.SelectedIndex != -1)
                {
                    DataTable courseStudentTable = new DataTable();
                    SqlCommand comd = new SqlCommand($@"SELECT registration.studentId AS StudentID, CONCAT (student.studentFirstName, ' ', student.studentLastName) AS FirstLastname, session.courseId AS CourseID 
                        FROM student LEFT OUTER JOIN registration ON student.studentId = registration.studentId LEFT OUTER JOIN session ON registration.sessionId = session.sessionId where session.courseId='{ cmboBoxInstructorCourses.SelectedValue}'", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comd);
                    adapter.Fill(courseStudentTable);
                    if (courseStudentTable.Rows.Count > 0)
                    {
                        this.lstbxCourseStudents.DisplayMember = "FirstLastname";
                        this.lstbxCourseStudents.ValueMember = "StudentID";
                        this.lstbxCourseStudents.DataSource = courseStudentTable;
                    }
                }
        }
        //Clears Student information on activation
        private void btnClearInstructor_Click(object sender, EventArgs e)
        {
            txtBoxINSTid.Clear();
            cmboBoxInstructorCourses.DataSource = null;
            lstbxCourseStudents.DataSource = null;
            lblStuCourseID.Text = "";
            lblStuFirstName.Text = "";
            lblStuLastName.Text = "";
            txtbxStuGrade.Clear();
        }

        //when OKAY button is clicked the instructor entered id will be used to select which course name's are displayed in the dropdown combobox
        private void btnIDokay_Click(object sender, EventArgs e)
        {
            instructorEnteredID = Convert.ToInt32(txtBoxINSTid.Text);
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter($@"SELECT session.sessionId, session.instructorId, session.courseId AS COurseID, course.courseName AS CourseName
                FROM session LEFT OUTER JOIN course ON session.courseId = course.courseID WHERE session.instructorId='{ instructorEnteredID }'", conn))
            {
                DataTable instructorCourseTable = new DataTable();
                adapter.Fill(instructorCourseTable);
                if (instructorCourseTable.Rows.Count > 0)
                {
                    this.cmboBoxInstructorCourses.DisplayMember = "CourseName";
                    this.cmboBoxInstructorCourses.ValueMember = "COurseID";
                    this.cmboBoxInstructorCourses.DataSource = instructorCourseTable;
                }
            }
        }

        //when student is selected it displays their information in the labels and textboxes for the user
        private void lstbxCourseStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
                if (lstbxCourseStudents.SelectedIndex != -1)
                {
                    DataTable stuGradeTable = new DataTable();
                    SqlCommand comd = new SqlCommand($@"SELECT registration.registrationId AS RegistrationID, registration.studentId AS StudentID, registration.sessionId AS SessionId, session.courseId AS CourseID, registration.grade AS Grade, student.studentFirstName AS fName, student.studentLastName AS lName FROM registration LEFT OUTER JOIN student ON registration.studentId = student.studentId LEFT OUTER JOIN session ON registration.sessionId = session.sessionId WHERE student.studentId='{ lstbxCourseStudents.SelectedValue }'", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comd);
                    adapter.Fill(stuGradeTable);

                    if (stuGradeTable.Rows.Count > 0)
                    {
                        
                        comd.Parameters.AddWithValue("@StudentID", lstbxCourseStudents.SelectedValue.ToString());
                        lblStuCourseID.Text = stuGradeTable.Rows[0]["CourseID"].ToString();
                        lblStuFirstName.Text = stuGradeTable.Rows[0]["fName"].ToString();
                        lblStuLastName.Text = stuGradeTable.Rows[0]["lName"].ToString();
                        lblRegistrationID.Text = stuGradeTable.Rows[0]["RegistrationID"].ToString();
                        txtbxStuGrade.Text = stuGradeTable.Rows[0]["Grade"].ToString();
                    }
                }

        }

        //event handler for Update button
        //sets grade for student according to the registrationID
        private void btnUpdateGrade_Click(object sender, EventArgs e)
        {
            int registrationID = Convert.ToInt32(lblRegistrationID.Text);

            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand($@"UPDATE registration SET grade = @grade WHERE registrationId = @RegistrationID", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@grade", txtbxStuGrade.Text);
                comd.Parameters.AddWithValue("@RegistrationID", registrationID);
                comd.ExecuteScalar();
                MessageBox.Show("Grade Updated");
            }
        }
    }
}