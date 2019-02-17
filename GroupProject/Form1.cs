using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
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
    }
}
