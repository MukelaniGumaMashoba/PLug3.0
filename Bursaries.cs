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
    public partial class Bursaries : Form
    {
        public Bursaries()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeStud homeStud = new HomeStud();
            homeStud.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vodacom vodacom = new Vodacom();
            vodacom.Show();
        }

        private void btnCSIR_Click(object sender, EventArgs e)
        {
            this.Hide();
            CISR cISR = new CISR();
            cISR.Show();
        }

        private void btnAnglo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Anglo anglo = new Anglo();
            anglo.Show();
        }

        private void btnSasol_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sasol sasol = new Sasol();  
            sasol.Show();
        }

        private void btnSanlam_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sanlam sanlam = new Sanlam();
            sanlam.Show();
        }

        private void btnSibanye_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sibanye sibanye = new Sibanye();
            sibanye.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bursaries bursaries = new Bursaries();
            bursaries.Show();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplicationProcess applicationProcess = new ApplicationProcess();
            applicationProcess.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutStud about = new AboutStud();
            about.Show();
        }
    }
}
