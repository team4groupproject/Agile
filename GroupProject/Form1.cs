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
        //administrator button, pressing will bring up Administrator form.
        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            AdminChoices adminChoices = new AdminChoices();
            adminChoices.ShowDialog();
        }
        //Closes form on activation
        private void btnMainFormExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Instructor button, pressing will bring up Instructor form.
        private void button1_Click(object sender, EventArgs e)
        {
            Instructor instructor = new Instructor();
            instructor.ShowDialog();
        }
    }
}
