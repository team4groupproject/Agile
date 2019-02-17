using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class AdminCourses : Form
    {
        string connectionString;
        SqlConnection conn;

        public AdminCourses()
        {
            InitializeComponent(); connectionString =
                 ConfigurationManager.ConnectionStrings["GroupProject.Properties.Settings.TinyCollegeDBConnectionString"].ConnectionString;
        }

        private void btnAdminCourseClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCoursesClear_Click(object sender, EventArgs e)
        {
            txtbxCourseName.Text = String.Empty;
            txtbxCourseStatus.Text = String.Empty;
            txtbxCourseCreditHours.Text = String.Empty;
            txtbxCourseMaxSeats.Text = String.Empty;
        }

        private void btnSessinClear_Click(object sender, EventArgs e)
        {
            txtbxSessionCourseId.Text = String.Empty;
            txtbxSessionInstructorId.Text = String.Empty;
            txtbxSessionSeatsFilled.Text = String.Empty;
        }

        private void AdminCourses_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter

                ("SELECT * FROM course", conn))
            {
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);
                CourseComboBox.DisplayMember = "courseName ";
                CourseComboBox.ValueMember = "courseId";
                CourseComboBox.DataSource = courseTable;

            }

            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter
            ("SELECT * FROM session", conn))
            {
                DataTable sessionTable = new DataTable();
                adapter.Fill(sessionTable);
                SessionComboBox.DisplayMember = "sessionId";
                SessionComboBox.ValueMember = "sessionId";
                SessionComboBox.DataSource = sessionTable;
            }
        }

        private void btnCourseSave_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand

            ("INSERT INTO course (courseName, courseStatus, courseCreditHours, courseMaxNumSeats) " +
            "VALUES (@courseName, @courseStatus, @courseCreditHours, @courseMaxNumSeats)", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@courseName", txtbxCourseName.Text);
                comd.Parameters.AddWithValue("@courseStatus", txtbxCourseStatus.Text);
                comd.Parameters.AddWithValue("@courseCreditHours", txtbxCourseCreditHours.Text);
                comd.Parameters.AddWithValue("@courseMaxNumSeats", txtbxCourseMaxSeats.Text);
                comd.ExecuteScalar();
                MessageBox.Show("Course Saved");
            }
        }

        private void btnSessionSave_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand

            ("INSERT INTO session(sessionSeatsFilled, instructorId, courseId) " +
            "VALUES (@sessionSeatsFilled, @instructorId, @courseId)", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@sessionSeatsFilled", txtbxSessionSeatsFilled.Text);
                comd.Parameters.AddWithValue("@instructorId", txtbxSessionInstructorId.Text);
                comd.Parameters.AddWithValue("@courseId", txtbxSessionCourseId.Text);
                comd.ExecuteScalar();
                MessageBox.Show("Session Saved");
            }
        }

        private void CourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand
                ("SELECT courseId, courseName, courseStatus, courseCreditHours, courseMaxNumSeats FROM course" + "WHERE course.courseId = @courseId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@courseId", CourseComboBox.SelectedValue.ToString());
                DataTable courseTable = new DataTable();
                txtbxCourseName.Text = "courseName";
                txtbxCourseStatus.Text = "courseStatus";
                txtbxCourseCreditHours.Text = "courseCreditHours";
                txtbxCourseMaxSeats.Text = "courseMaxNumSeats";
            }
        }

        private void SessionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand
                ("SELECT sessionId, sessionSeatsFilled, instructorId, courseId FROM session" + "WHERE session.sessionId = @sessionId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@sessionId", SessionComboBox.SelectedValue.ToString());
                DataTable studentTable = new DataTable();
                txtbxSessionCourseId.Text = "courseId";
                txtbxSessionInstructorId.Text = "instructorId";
                txtbxSessionSeatsFilled.Text = "sessionSeatsFilled";
            }
        }
    }
}
