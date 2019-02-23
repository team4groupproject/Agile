using System;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            AdminChoices adminChoices = new AdminChoices();
            adminChoices.ShowDialog();
        }

        private void btnMainFormExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Instructor instructor = new Instructor();
            instructor.ShowDialog();
        }
    }
}
