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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeSpon homeSpon = new HomeSpon();
            homeSpon.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile();
            profile.Show();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            Faculties faculties = new Faculties();
            faculties.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Donations donations = new Donations();
            donations.Show();
        }
    }
}
