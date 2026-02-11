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

namespace Tehtävä14
{
    public partial class PaivakirjaFM : Form
    {
        public PaivakirjaFM()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:/Temp/paivakirja.txt");
            PaivakirjaTB.Text = teksti;
               
        }

        private void LisaaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += PaivakirjaTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yy HH.mm") + "\n";
            TextWriter text = new StreamWriter("C:/Temp/paivakirja.txt");
            text.WriteLine(teksti);
            text.Close();
            Application.Exit();

        }
    }
}
