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
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings ["GroupProject.Properties.Settings.TinyCollegeDBConnectionString"].ConnectionString;
        }
       
        private void AdminCourses_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter ("SELECT * FROM course ORDER BY courseName ASC", conn))
            {
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);
                CourseComboBox.DisplayMember = "courseName";
                CourseComboBox.ValueMember = "courseId";
                CourseComboBox.DataSource = courseTable;
            }

            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter ("SELECT * FROM session", conn))
            {
                DataTable sessionTable = new DataTable();
                adapter.Fill(sessionTable);
                SessionComboBox.DisplayMember = "sessionId";
                SessionComboBox.ValueMember = "sessionId";
                SessionComboBox.DataSource = sessionTable;
            }
        }        

        private void CourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
                if (CourseComboBox.SelectedIndex != -1)
                {
                    DataTable courseTable = new DataTable();
                    SqlCommand comd = new SqlCommand("SELECT courseId, courseName, courseStatus, courseCreditHours, courseMaxNumSeats FROM course where courseId='" + CourseComboBox.SelectedValue + "'", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comd);
                    adapter.Fill(courseTable);
                    if (courseTable.Rows.Count > 0)
                    {
                        comd.Parameters.AddWithValue("@courseId", CourseComboBox.SelectedValue.ToString());
                        txtbxCourseName.Text = courseTable.Rows[0]["courseName"].ToString();
                        txtbxCourseStatus.Text = courseTable.Rows[0]["courseStatus"].ToString();
                        txtbxCourseCreditHours.Text = courseTable.Rows[0]["courseCreditHours"].ToString();
                        txtbxCourseMaxSeats.Text = courseTable.Rows[0]["courseMaxNumSeats"].ToString();
                    }
                }
        }

        private void SessionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
                if (SessionComboBox.SelectedIndex != -1)
                {
                    DataTable studentTable = new DataTable();
                    SqlCommand comd = new SqlCommand("SELECT sessionId, sessionSeatsFilled, instructorId, courseId  FROM session where sessionId='" + SessionComboBox.SelectedValue + "'", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comd);
                    adapter.Fill(studentTable);
                    if (studentTable.Rows.Count > 0)
                    {
                        comd.Parameters.AddWithValue("@sessionId", SessionComboBox.SelectedValue.ToString());
                        txtbxSessionCourseId.Text = studentTable.Rows[0]["sessionId"].ToString();
                        txtbxSessionInstructorId.Text = studentTable.Rows[0]["instructorId"].ToString();
                        txtbxSessionSeatsFilled.Text = studentTable.Rows[0]["sessionSeatsFilled"].ToString();
                    }
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

        private void btnAdminCourseClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}