using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class AdminChoices : Form
    {
        public AdminChoices()
        {
            InitializeComponent();
        }

        private void btnAdminStudentChoice_Click(object sender, EventArgs e)
        {
            AdminStudent adminStudent = new AdminStudent();
            adminStudent.ShowDialog();
        }

        private void btnAdminInstructorChoice_Click(object sender, EventArgs e)
        {
            AdminInstructor adminInstructor = new AdminInstructor();
            adminInstructor.ShowDialog();
        }

        private void btnAdminCourseChoice_Click(object sender, EventArgs e)
        {
            AdminCourses adminCourses = new AdminCourses();
            adminCourses.ShowDialog();
        }

        private void btnAdminChoicesClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
