using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace harjoitus6
{
    public partial class SalasananTarkastusFM : Form
    {
        public SalasananTarkastusFM()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if(KayttajaTB.Text == "Roosa" && SalasanaTB.Text == "JaakkoKulta")
            {
                SalasanaPL.Visible = false;
                SalasanaOikeinPL.Visible = true;
            }
            else
            {
                VirheviestiLB.Text = "Käyttäjätunnus tai salasana virheellinen";
                VirheviestiLB.Visible = true;
            }
        }
    }
}
