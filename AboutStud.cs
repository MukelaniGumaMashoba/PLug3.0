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
    public partial class AboutStud : Form
    {
        public AboutStud()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bursaries bursaries = new Bursaries();
            bursaries.Show();
        }

        private void btnApp_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplicationProcess applicationProcess = new ApplicationProcess();
            applicationProcess.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }

        private void btnDonation_Click(object sender, EventArgs e)
        {
            this.Hide();
            MotivationalLetterStud motivationalLetter = new MotivationalLetterStud();
            motivationalLetter.Show();
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
    }
}
