using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus7
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void KilometritCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double luku1 = Convert.ToDouble(TB1.Text);
            double luku2 = Convert.ToDouble(TB2.Text);
            double luku3 = Convert.ToDouble(TB3.Text);
            double luku4 = Convert.ToDouble(TB4.Text);
            double luku5 = Convert.ToDouble(TB5.Text);
            double luku6 = Convert.ToDouble(TB6.Text);
            double luku7 = Convert.ToDouble(TB7.Text);
            double luku8 = Convert.ToDouble(TB8.Text);
            double jako = Convert.ToDouble(KilometritCB.Text);

            
            double vastaus = (luku1 + luku2 + luku3 + luku4 + luku5 + luku6 + luku7 + luku8)/jako;
            VastausLB.Text = Convert.ToString(vastaus) + "€/km";
            VastausLB.Visible = true;
        }
    }
}
