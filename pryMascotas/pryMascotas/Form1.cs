﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMascotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            progressBar1.Increment(5);
            progressBar1.ForeColor =Color.Sienna;
            lblCargando.Text=progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == progressBar1.Maximum) {
                timer1.Stop();
                this.Hide();
                frmLogin frm = new frmLogin();
                frm.Show();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
