using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace GroupProject
{
    public partial class StudentRegister : Form
    {
        string connectionString;
        SqlConnection conn;
        int studentID;
        int sessionID;
        int seatsFilled;
        int remainingSeats;

        //constructor accepts StudentID from previous form
        public StudentRegister(int stuID)
        {
            //share the studentID to public variable passed to all the methods
            studentID = stuID;
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["GroupProject.Properties.Settings.TinyCollegeDBConnectionString"].ConnectionString;
        }

        private void StudentRegister_Load(object sender, EventArgs e)
        {
            //display student id for student who will be registered (value was passed from previous form)
            txtStudentID.Text = studentID.ToString();

            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT courseName, courseId FROM course", conn))
            using (SqlDataAdapter adapterCourse = new SqlDataAdapter(comd))
            {
                //create a DataTable in working memory for retrieved data
                DataTable CourseTable = new DataTable();
                //use SQLscript to retrieve and fill data table
                adapterCourse.Fill(CourseTable);
                //show course name in ComboBox
                cboCourse.DisplayMember = "courseName";
                //use id behind selection in ComboBox
                cboCourse.ValueMember = "courseId";
                cboCourse.DataSource = CourseTable;
            }
        }

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            //show only sessions for selected course. (retrieve max seats of course for calculating remainingSeats)
            using (SqlCommand comd = new SqlCommand("SELECT session.courseId, session.sessionId, session.sessionSeatsFilled, course.courseMaxNumSeats " +
                "FROM session " +
                "INNER JOIN course ON session.courseId=course.courseId " +
                "WHERE session.courseId = @CourseID", conn))
            using (SqlDataAdapter adapterSession = new SqlDataAdapter(comd))
            {
                //Set courseID in comd to be the value of selected in course ComboBox
                comd.Parameters.AddWithValue("@CourseID", cboCourse.SelectedValue);

                //create a DataTable in working memory for retrieved data
                DataTable SessionTable = new DataTable();
                //use SQLscript to retrieve and fill data table
                adapterSession.Fill(SessionTable);
                //show sessionID in ComboBox
                cboSession.DisplayMember = "sessionId";
                //use id for value
                cboSession.ValueMember = "sessionId";
                cboSession.DataSource = SessionTable;

                //calculate and show remaining seats
                DataRow dr = SessionTable.Rows[0];
                int maxSeats = int.Parse(dr["courseMaxNumSeats"].ToString());
                seatsFilled = int.Parse(dr["sessionSeatsFilled"].ToString());
                remainingSeats = maxSeats-seatsFilled;
                txtSeatsRemaining.Text = remainingSeats.ToString();
                //set public variable session ID (will be updating that table in registration method)
                sessionID = int.Parse(dr["sessionId"].ToString());

                //make button available only if seats remain in this session
                if (remainingSeats > 0)
                {
                    btnRegister.Enabled = true;
                }
                else
                { btnRegister.Enabled = false; }
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("INSERT INTO registration (sessionId, studentId) " +
                "VALUES (@sessionId, @studentId)", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@sessionId", cboSession.Text);
                comd.Parameters.AddWithValue("@studentId", studentID);
                comd.ExecuteScalar();
                conn.Close();
            }

            //update seats filled to one higher
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comdSeats = new SqlCommand("UPDATE session SET sessionSeatsFilled = @seatsFilled WHERE sessionId = @sessionId", conn))
            {
              conn.Open();
            //add 1 to public variable seatsFilled- set in course cbo index change method
            comdSeats.Parameters.AddWithValue("@seatsFilled", seatsFilled + 1);
            comdSeats.Parameters.AddWithValue("@sessionId", sessionID);
            comdSeats.ExecuteScalar();
            }
            MessageBox.Show("Registered for session");


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

