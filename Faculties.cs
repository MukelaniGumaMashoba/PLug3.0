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
    public partial class Faculties : Form
    {
        public Faculties()
        {
            InitializeComponent();
        }

        private void btnScience_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScienceStudents scienceStudents = new ScienceStudents();
            scienceStudents.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeSpon homeSpon = new HomeSpon();
            homeSpon.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Donations donations = new Donations();
            donations.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnCommerce_Click(object sender, EventArgs e)
        {
            this.Hide();
            Math_And_Commerce math_And_Commerce = new Math_And_Commerce();
            math_And_Commerce.Show();
        }

        private void btnTechnology_Click(object sender, EventArgs e)
        {
            this.Hide();
            Technology technology = new Technology();
            technology.Show();
        }

        private void btnEngineering_Click(object sender, EventArgs e)
        {
            this.Hide();
            Engineering engineering = new Engineering();
            engineering.Show();
        }

        private void btnLaw_Click(object sender, EventArgs e)
        {
            this.Hide();
            Law law = new Law();
            law.Show();
        }

        private void btnEducation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Education education = new Education();
            education.Show();
        }

        private void btnAgri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agriculture agriculture = new Agriculture();
            agriculture.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Art art = new Art();
            art.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile();
            profile.Show();
        }
    }
}
