using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections.Generic;

namespace GroupProject
{
    public partial class AdminStudent : Form
    {
        string connectionString;
        SqlConnection conn;

        public AdminStudent()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["GroupProject.Properties.Settings.TinyCollegeDBConnectionString"].ConnectionString;
        }

        private void AdminStudent_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT studentId, CONCAT (studentFirstName,  ' ', studentLastName) as FirstLast FROM student ORDER BY FirstLast ASC", conn))
            {
                DataTable studentTable = new DataTable();
                adapter.Fill(studentTable);
                if (studentTable.Rows.Count > 0)
                {
                    this.StudentComboBox.DisplayMember = "FirstLast";
                    this.StudentComboBox.ValueMember = "studentId";
                    this.StudentComboBox.DataSource = studentTable;
                }
            }
        }

        private void StudentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            if (StudentComboBox.SelectedIndex != -1)
            {
                DataTable studentTable = new DataTable();
                SqlCommand comd = new SqlCommand("SELECT studentId, studentFirstName, studentLastName FROM student where studentId='" + StudentComboBox.SelectedValue + "'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(comd);
                adapter.Fill(studentTable);
                if (studentTable.Rows.Count > 0)
                {
                    txtbxStuFirstName.Text = studentTable.Rows[0]["studentFirstName"].ToString();
                    txtbxStuLastName.Text = studentTable.Rows[0]["studentLastName"].ToString();                    
                }                
            }
        }

        private void btnAdminStudentClear_Click(object sender, EventArgs e)
        {
            txtbxStuLastName.Text = String.Empty;
            txtbxStuFirstName.Text = String.Empty;
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

        private void btnAdminStudentClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}