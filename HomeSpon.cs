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
    public partial class HomeSpon : Form
    {
        public HomeSpon()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void HomeSpon_Load(object sender, EventArgs e)
        {
            
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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile();
            profile.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.Hide();
            About about = new About();
            about.Show();
        }
    }
}
