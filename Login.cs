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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            comboBox.Items.Add("Student");
            comboBox.Items.Add("Sponsor");
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.ToLower() == "admin" && txtPassword.Text.ToLower() == "admin" && checkBox.Checked && comboBox.Text == "Student")
            {
                this.Hide();
                VerficationStud verification = new VerficationStud();
                verification.Show();
            }
            else if(txtUsername.Text.ToLower() == "admin" && txtPassword.Text.ToLower() == "admin" && checkBox.Checked && comboBox.Text == "Sponsor") 
            {
                this.Hide();
                Verification verification = new Verification();
                verification.Show();
            }
            else if(txtUsername.Text.ToLower() == "admin" && txtPassword.Text.ToLower() == "admin")
            {
                MessageBox.Show("Check Box not selected","checkbox",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Username/Password incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
