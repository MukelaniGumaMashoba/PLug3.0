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
    public partial class Donations : Form
    {
        public Donations()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Card_Payment card_Payment = new Card_Payment();
            card_Payment.Show();
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

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.Hide();
            About about = new About();
            about.Show();
        }
    }
}
