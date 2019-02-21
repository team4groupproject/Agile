using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class AdminInstructor : Form
    {
        string connectionString;
        SqlConnection conn;
        public AdminInstructor()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings ["GroupProject.Properties.Settings.TinyCollegeDBConnectionString"].ConnectionString;
        }
        
        private void AdminInstructor_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter ("SELECT instructorId, CONCAT (instructorFirstName, ' ', instructorLastName) as FirstLast FROM instructor ORDER BY FirstLast ASC", conn))
            {
                DataTable instructorTable = new DataTable();
                adapter.Fill(instructorTable);
                InstructorComboBox.DisplayMember = "FirstLast";
                InstructorComboBox.ValueMember = "instructorId";
                InstructorComboBox.DataSource = instructorTable;
            }
        }

        private void InstructorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
                if (InstructorComboBox.SelectedIndex != -1)
                {
                    DataTable instructorTable = new DataTable();
                    SqlCommand comd = new SqlCommand("SELECT instructorId, instructorFirstName, instructorLastName FROM instructor where instructorId='" + InstructorComboBox.SelectedValue + "'", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comd);
                    adapter.Fill(instructorTable);
                    if (instructorTable.Rows.Count > 0)
                    {
                        txtbxInstructorFirstName.Text = instructorTable.Rows[0]["instructorFirstName"].ToString(); 
                        txtbxInstructorLastName.Text = instructorTable.Rows[0]["instructorLastName"].ToString(); ;
                    }
                }
        }

        private void btnAdminInstructorSave_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand
                ("INSERT INTO instructor (instructorFirstName, instructorLastName) " +
                "VALUES (@instructorFirstName, @instructorLastName)", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@instructorFirstName", txtbxInstructorFirstName.Text);
                comd.Parameters.AddWithValue("@instructorLastName", txtbxInstructorLastName.Text);
                comd.ExecuteScalar();
                MessageBox.Show("Instructor Added");
            }
        }

        private void btnAdminInstructorClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdminInstructorClear_Click(object sender, EventArgs e)
        {
            txtbxInstructorFirstName.Text = String.Empty;
            txtbxInstructorLastName.Text = String.Empty;
        }        
    }
}