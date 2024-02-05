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
    public partial class Card_Payment : Form
    {
        public Card_Payment()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Donations donations = new Donations();
            donations.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OTP oTP = new OTP();
            oTP.Show();
        }
    }
}
