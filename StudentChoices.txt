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


namespace Student
{
    public partial class StudentChoices : Form
    {
        string connectionString;
        SqlConnection conn;
        BindingSource studentBindingSource = new BindingSource();
        int studentID;

        public StudentChoices()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Student.Properties.Settings.TinyCollegeDB1ConnectionString"].ConnectionString;
        }

        private void btnFindStudentID_Click_1(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT * FROM student WHERE studentID = @studentID", conn))
            using (SqlDataAdapter adapterStudent = new SqlDataAdapter(comd))
            {
                //use the studentID which user entered in text box to pull the data in sqlscript
                comd.Parameters.AddWithValue("@studentID", txtStudentID.Text);
                //create a datatable in working memory for retrieved data
                DataTable studentTable = new DataTable();
                //use SQLscript to retrieve and fill data table
                adapterStudent.Fill(studentTable);
                //check to see if any data was pulled based on ID entered
                if (studentTable.Rows.Count < 1)
                { MessageBox.Show("Not a valid Student ID"); }//show feedback if ID entered does not exist in DB
                else
                {
                    //name first row of table in working memory (this is the only row since studentID is unique)
                    DataRow rowStudent = studentTable.Rows[0];
                    studentID = int.Parse(rowStudent["studentID"].ToString()); //define shared public variable
                    //load student data based on row found 
                    txtFirstNameStudent.Text = rowStudent["studentFirstName"].ToString();
                    txtLastNameStudent.Text = rowStudent["studentLastName"].ToString();

                    //load datagrid
                    dgvCourses.DataSource = studentBindingSource;
                    //select the data needed for datagrid and to calculate credits completed                
                    //************ Add grades from registration table*********************
                    using (SqlCommand command =new SqlCommand ("SELECT course.courseName, course.courseCreditHours FROM registration " +
                        "INNER JOIN session ON registration.sessionId = session.sessionId " +
                        "INNER JOIN course ON session.courseId = course.courseId " +
                        "WHERE registration.studentID=@studentID", conn))
                    using (SqlDataAdapter adapterCourses = new SqlDataAdapter(command))
                    {
                        command.Parameters.AddWithValue("@studentID", studentID);
                        SqlCommandBuilder comdBuilder = new SqlCommandBuilder(adapterCourses);//?
                        //datatable in workign memory to contain query results
                        DataTable registrationTable = new DataTable();
                        adapterCourses.Fill(registrationTable);
                        studentBindingSource.DataSource = registrationTable;

                        //******adjust to only count completed courses with a grade***************
                        //sum credit hours 
                        int creditsEarned= 0; //clear out any previous search results
                        //do for each row in registration table
                        for (int x =0; x < registrationTable.Rows.Count; x++)
                        {
                            DataRow currentRow = registrationTable.Rows[x];
                            creditsEarned = creditsEarned + int.Parse(currentRow["courseCreditHours"].ToString());
                        }
                        txtEarnedCredits.Text = creditsEarned.ToString();
                    }

                    //enable register button if student found
                    btnRegister.Enabled = true;
                }
            }

        }

        private void StudentChoices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tinyCollegeDB1DataSet.registration' table. You can move, or remove it, as needed.
            this.registrationTableAdapter.Fill(this.tinyCollegeDB1DataSet.registration);

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //create a new form for registration and pass the studentID entered to new form
            StudentRegister newRegisterForm = new StudentRegister(studentID);
            newRegisterForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
