﻿using System;
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
    public partial class AcceptLetter : Form
    {
        public AcceptLetter()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScienceStudents scienceStudents = new ScienceStudents();
            scienceStudents.Show();
        }
    }
}
