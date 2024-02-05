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
    public partial class HomeStud : Form
    {
        public HomeStud()
        {
            InitializeComponent();
        }

        private void HomeStud_Load(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bursaries bursaries = new Bursaries();
            bursaries.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplicationProcess applicationProcess = new ApplicationProcess();
            applicationProcess.Show();
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

        private void btnHome_Click(object sender, EventArgs e)
        {

        }
    }
}
