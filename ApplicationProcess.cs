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
    public partial class ApplicationProcess : Form
    {
        public ApplicationProcess()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeStud homeStud = new HomeStud();
            homeStud.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnDonation_Click(object sender, EventArgs e)
        {
            this.Hide();
            MotivationalLetterStud motivationalLetter = new MotivationalLetterStud();
            motivationalLetter.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutStud about = new AboutStud();
            about.Show();
        }
    }
}
