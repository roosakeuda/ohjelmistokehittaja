using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {   double paino = Convert.ToDouble(PainoTB.Text);
            double pituus = Convert.ToDouble(PituusTB.Text) / 100;
            double indeksi = paino / (pituus * pituus);

            if (indeksi < 18.5)
            {
                VastausLB.ForeColor = Color.Cyan;
                bmiLB.ForeColor = Color.Cyan;

                VastausLB.Text = "Painoindeksisi on: " + Convert.ToString(indeksi);
                bmiLB.Text = "Alipaino";

                bmiLB.Visible = true;
                VastausLB.Visible = true;
            }
            else if (indeksi < 24.9)
            {
                VastausLB.ForeColor = Color.Green;
                bmiLB.ForeColor = Color.Green;

                VastausLB.Text = "Painoindeksisi on: " + Convert.ToString(indeksi);
                bmiLB.Text = "Normaalipaino";

                bmiLB.Visible = true;
                VastausLB.Visible = true;
            }
            else if (indeksi < 27.78)
            {
                VastausLB.ForeColor = Color.Yellow;
                bmiLB.ForeColor = Color.Yellow;

                VastausLB.Text = "Painoindeksisi on: " + Convert.ToString(indeksi);
                bmiLB.Text = "Ylipaino";

                bmiLB.Visible = true;
                VastausLB.Visible = true;
            }
            else
            {
                VastausLB.ForeColor = Color.Red;
                bmiLB.ForeColor = Color.Red;

                VastausLB.Text = "Painoindeksisi on: " + Convert.ToString(indeksi);
                bmiLB.Text = "Merkittävä lihavuus";

                bmiLB.Visible = true;
                VastausLB.Visible = true;
            }
        }
    }
}
