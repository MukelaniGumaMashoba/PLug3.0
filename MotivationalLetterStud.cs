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
    public partial class MotivationalLetterStud : Form
    {
        public MotivationalLetterStud()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeStud homeStud = new HomeStud();
            homeStud.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Motivational Letter Updated", "Update", MessageBoxButtons.OK);
        }
    }
}
