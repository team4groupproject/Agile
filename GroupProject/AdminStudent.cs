using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class AdminStudent : Form
    {
        string connectionString;
        SqlConnection conn;
        public AdminStudent()
        {
            InitializeComponent();
            connectionString =
                ConfigurationManager.ConnectionStrings["GroupProject.Properties.Settings.TinyCollegeDBConnectionString"].ConnectionString;
        }

        private void AdminStudent_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter

                ("SELECT * FROM student", conn))
            {
                DataTable studentTable = new DataTable();
                adapter.Fill(studentTable);
                StudentComboBox.DisplayMember = "studentFirstName " + "studentLastName";
                StudentComboBox.ValueMember = "studentId";
                StudentComboBox.DataSource = studentTable;
                
            }
        }

        private void StudentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand
                ("SELECT studentId, studentFirstName, studentLastName FROM student" + "WHERE student.studentId = @studentId", conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@studentId", StudentComboBox.SelectedValue.ToString());
                DataTable studentTable = new DataTable();
                txtbxStuFirstName.Text = "studentFirstName";
                txtbxStuLastName.Text = "studentLastName";
            }
        }

        private void btnAdminStudentClear_Click(object sender, EventArgs e)
        {
            txtbxStuLastName.Text = String.Empty;
            txtbxStuFirstName.Text = String.Empty;
        }

        private void btnAdminStudentClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdminAddStudent_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("INSERT INTO student (studentFirstName, studentLastName) " + "VALUES (@studentFirstName, @studentLastName)", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@studentFirstName", txtbxStuFirstName.Text);
                comd.Parameters.AddWithValue("@studentLastName", txtbxStuLastName.Text);
                comd.ExecuteScalar();
                MessageBox.Show("StudentAdded");
            }
        }
    }
}
