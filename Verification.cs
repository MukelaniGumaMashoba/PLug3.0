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
    public partial class Verification : Form
    {
        public Verification()
        {
            InitializeComponent();
            string[] saAllowedCharacters = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };


            string sRandomOTP = GenerateRandomOTP(8, saAllowedCharacters);
            lblCode.Text = sRandomOTP;
        }
        private string GenerateRandomOTP(int iOTPLength, string[] saAllowedCharacters)

        {

            string sOTP = String.Empty;

            string sTempChars = String.Empty;

            Random rand = new Random();

            for (int i = 0; i < iOTPLength; i++)

            {

                int p = rand.Next(0, saAllowedCharacters.Length);

                sTempChars = saAllowedCharacters[rand.Next(0, saAllowedCharacters.Length)];

                sOTP += sTempChars;

            }

            return sOTP;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text == lblCode.Text)
            {
                this.Hide();

                HomeSpon home = new HomeSpon();
                home.Show();
            }
            else
            {
                MessageBox.Show("User input incorrect,Please try again", "verifcation", MessageBoxButtons.OK);
                this.Hide();
                Verification verification = new Verification();
                verification.Show();
            }
        }
    }
}
