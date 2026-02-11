using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yksinkertainen_C__tietovisa
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ARB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LähetäBT_Click(object sender, EventArgs e)
        {
            int pisteet = 0;
            if (k1bRB.Checked)
            {
                pisteet ++;
            }
            if (k2aRB.Checked)
            {
                pisteet++;
            }
            if (k3dRB.Checked)
            {
                pisteet++;
            }
            if (k4bRB.Checked)
            {
                pisteet++;
            }
            if (k5dRB.Checked)
            {
                pisteet++;
            }

            VastausLB.Text = "Sait " + pisteet + " pistettä oikein.";
            VastausLB.Visible = true;
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }








}

