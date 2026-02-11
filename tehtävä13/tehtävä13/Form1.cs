using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tehtävä13
{
    public partial class SuosikitFM : Form
    {
        public SuosikitFM()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:/Temp/pojat.txt");
            string[] tytot = File.ReadAllLines("C:/Temp/tytot.txt");
            string nimi = NimiTB.Text;
            int laskurip = 0;
            int laskurit = 0;


            foreach(string poika in pojat)
            {
                if (nimi == poika)
                {
                    VastausLB.Text = "Nimesi on " + laskurip + ". suosituin pojan nimi vuonna ";
                    VastausLB.Visible = true;
                }
                laskurip++;
            }
            foreach (string tytto in tytot)
            {
                if (nimi == tytto)
                {
                    VastausLB.Text = "Nimesi on " + laskurip + ". suosituin tytön nimi vuonna ";
                    VastausLB.Visible = true;
                }
                laskurit++;
            }
            if (VastausLB.Visible = false)
            {
                VastausLB.Text = "Nimesi ei löytynyt suosituimpien nimien joukosta";
                VastausLB.Visible = true;
            }
        }
    }
}
