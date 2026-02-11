using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace harjoitus5
{
    public partial class Form1 : Form
    {
        List<int> jono = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (uusiLukuTB.Text == "-999")
                {
                    VastausLB.Text = "";
                    uusiLukuTB.Text = "";
                    int[] taulu = jono.ToArray();
                    Array.Sort(taulu);
                    foreach(int luku in taulu)
                    {
                        VastausLB.Text += luku.ToString() + " ";

                    }
                    VastausLB.Visible = true;
                }
                else
                {
                    jono.Add(int.Parse(uusiLukuTB.Text));
                    uusiLukuTB.Text = "";

                }
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                TyhjaaLomake();
            }

        }
        private void TyhjaaLomake()
        {
            uusiLukuTB.Text = "";
        }

    }
}
