using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class AdminCourses : Form
    {
        //Declare string variable
        string connectionString;
        SqlConnection conn;

        public AdminCourses()
        {
            //Assign value to variable conn
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings ["GroupProject.Properties.Settings.TinyCollegeDBConnectionString"].ConnectionString;
        }
       
        private void AdminCourses_Load(object sender, EventArgs e)
        {
            //Displays Course info on activation
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter ("SELECT * FROM course ORDER BY courseName ASC", conn))
            {
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);
                CourseComboBox.DisplayMember = "courseName";
                CourseComboBox.ValueMember = "courseId";
                CourseComboBox.DataSource = courseTable;
            }
            //Displays Session info on activation
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
        //Fills SQL Database Course values into ComboBox
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
        //Fills SQL Database Session values into ComboBox
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
        //Saves changes to course
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
        //Saves changes to session
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
        //Clears course information on activation
        private void btnCoursesClear_Click(object sender, EventArgs e)
        {
            txtbxCourseName.Text = String.Empty;
            txtbxCourseStatus.Text = String.Empty;
            txtbxCourseCreditHours.Text = String.Empty;
            txtbxCourseMaxSeats.Text = String.Empty;
        }
        //Clears session information on activation
        private void btnSessinClear_Click(object sender, EventArgs e)
        {
            txtbxSessionCourseId.Text = String.Empty;
            txtbxSessionInstructorId.Text = String.Empty;
            txtbxSessionSeatsFilled.Text = String.Empty;
        }
        //Closes administrator form on activation
        private void btnAdminCourseClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void courseUpdateButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("UPDATE course SET courseName" + "= @cName, courseStatus" + "= @status, courseCreditHours" + "=@cHours, courseMaxNumSeats" + "= @cSeats WHERE courseId" + "= @CourseID", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@cName", txtbxCourseName.Text);
                comd.Parameters.AddWithValue("@status", txtbxCourseStatus.Text);
                comd.Parameters.AddWithValue("@cHours", txtbxCourseCreditHours.Text);
                comd.Parameters.AddWithValue("@cSeats", txtbxCourseMaxSeats.Text);
                comd.Parameters.AddWithValue("@CourseID", CourseComboBox.SelectedValue);
                comd.ExecuteScalar();
                MessageBox.Show("The Course Information Has Been Updated");

            }
        }

        private void sessionUpdateButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("UPDATE session SET session.courseId" + "= @sCId, sessionSeatsFilled" + "= @sSeats, session.instructorId" + "=@sId  WHERE sessionId" + "= @SessionID", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@sCId", txtbxSessionCourseId.Text);
                comd.Parameters.AddWithValue("@sId", txtbxSessionInstructorId.Text);
                comd.Parameters.AddWithValue("@sSeats", txtbxSessionSeatsFilled.Text);
                comd.Parameters.AddWithValue("@SessionID", SessionComboBox.SelectedValue);
                comd.ExecuteScalar();
                MessageBox.Show("The Course Information Has Been Updated");

            }
        }
    }
}
