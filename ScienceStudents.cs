using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLUG_3._0
{
    public partial class ScienceStudents : Form
    {
        public ScienceStudents()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Faculties faculties = new Faculties();
            faculties.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MotivationalLetter motivationalLetter = new MotivationalLetter();
            motivationalLetter.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
