using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotellihallintajärjestelmä
{
    public partial class VaraustenHallinta : Form
    {
        bool ladataan = false;
        Huone huone = new Huone();
        ASIAKAS asiakas = new ASIAKAS();
        VARAUKSET varaus = new VARAUKSET();
        public VaraustenHallinta()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VaraustenHallinta_Load(object sender, EventArgs e)
        {
            //haetaan huonetyypit
            HuoneTyyppiCB.DataSource = huone.huonetyyppilista();
            HuoneTyyppiCB.DisplayMember = "Huonetyyppi";
            HuoneTyyppiCB.ValueMember = "TyyppiId";  

            //haetaan asiakkaat asiakaslistaan
            AsiakasNroCB.DataSource = asiakas.asiakaslista();
            AsiakasNroCB.DisplayMember = "Kokonimi";
            AsiakasNroCB.ValueMember = "ktunnus";
            VarauksetDG.DataSource = varaus.haeVaraukset();

            //haetaan huoneet huonetyypin mukaan
            HuoneNroCB.DataSource = huone.kaikkiHuoneetLista();
            HuoneNroCB.DisplayMember = "HuoneNro";
            HuoneNroCB.ValueMember = "HuoneNro";

            HuoneNroCB.SelectedIndex = -1;
            HuoneTyyppiCB.SelectedIndex = -1;
            AsiakasNroCB.SelectedIndex = -1;

        }

        private void VarauksetDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VarauksetDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            ladataan = true; // varmistetaan että myöhemmin ei aktivoidu metodi, että varauksen tiedot saa oikein näkyviin
            VarausNroTB.Text = VarauksetDG.CurrentRow.Cells[0].Value.ToString();
            AsiakasNroCB.SelectedValue = VarauksetDG.CurrentRow.Cells[2].Value.ToString();
            SisäänDTP.Value = Convert.ToDateTime(VarauksetDG.CurrentRow.Cells[3].Value);
            UlosDTP.Value = Convert.ToDateTime(VarauksetDG.CurrentRow.Cells[4].Value);

            int huonenro = Convert.ToInt32(VarauksetDG.CurrentRow.Cells[1].Value);
            int eka = huonenro / 100;
            HuoneTyyppiCB.SelectedIndex = eka - 1;

            HuoneNroCB.DataSource = huone.tyypillisetHuoneet(eka, huonenro); //haetaan oikea huonenumero, niin että listalla näkyy nykyinen huone ja muut vapaana olevat huoneet.
            HuoneNroCB.DisplayMember = "HuoneNro";
            HuoneNroCB.ValueMember = "HuoneNro";


            HuoneNroCB.SelectedValue = huonenro.ToString();


            ladataan = false;
        }



        private void LisaaBT_Click(object sender, EventArgs e)
        {
            string asiakas = Convert.ToString(AsiakasNroCB.SelectedValue);
            int huonenro = Convert.ToInt32(HuoneNroCB.SelectedValue.ToString());
            DateTime sisaankirjautuminen = Convert.ToDateTime(SisäänDTP.Value);
            DateTime uloskirjautuminen = Convert.ToDateTime(UlosDTP.Value);
            if (varaus.lisaaVaraus(huonenro, asiakas, sisaankirjautuminen, uloskirjautuminen))
            {
                MessageBox.Show("Varaus lisätty onnistuneesti", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (huone.vaihdaHuoneenVapaus("Kyllä", huonenro))
                {
                  
                    MessageBox.Show("huoneen varaustilanne vaihdettu onnistuneesti");
                }
                else
                {
                    MessageBox.Show("Huoneen varaustilannetta ei saatu vaihdettua");
                }
            }
            else
            {
                MessageBox.Show("Varausta ei pystytty lisäämään", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VarauksetDG.DataSource = varaus.haeVaraukset();
            TyhjennaBT.PerformClick();
        }

        private void MuokkaaBT_Click(object sender, EventArgs e)
        {
            int huonenro = Convert.ToInt32(HuoneNroCB.SelectedValue.ToString());
            string asiakas = Convert.ToString(AsiakasNroCB.SelectedValue);
            DateTime sisaan = Convert.ToDateTime(SisäänDTP.Value);
            DateTime ulos = Convert.ToDateTime(UlosDTP.Value);
            try
            {
                int vara = Convert.ToInt32(VarausNroTB.Text);
                int vanhaHuone = huone.haeHuoneVarausIdlla(vara);


                if (varaus.muokkaaVarausta(huonenro, asiakas, sisaan, ulos, vara))
                {
                    MessageBox.Show("Varaus muokattu onnistuneesti", "Varauksen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (vanhaHuone != huonenro) //varmistetaan että jos huoneen numero on vaihtunut, että huoneiden varaukset merkitään oikein
                    {
                        huone.vaihdaHuoneenVapaus("Ei", vanhaHuone);
                        huone.vaihdaHuoneenVapaus("Kyllä", huonenro);
                        MessageBox.Show("Huoneen varaustilanne vaihdettu onnistuneesti");
                    }
                }
                else
                {
                    MessageBox.Show("Varausta ei pystytty muokkaamaan", "Varauksen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message, "Varauksen muokkaus virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            VarauksetDG.DataSource = varaus.haeVaraukset();
            TyhjennaBT.PerformClick();
        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            try
            {
                String varausnro = VarausNroTB.Text;
                int huonenro = Convert.ToInt32(HuoneNroCB.SelectedValue);
                if (varaus.poistaVaraus(varausnro))
                {
                    VarauksetDG.DataSource = varaus.haeVaraukset();
                    
                    MessageBox.Show("Varaus poistettu onnistuneesti", "Varauksen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    huone.vaihdaHuoneenVapaus("Ei", huonenro);

                }
                
                else
                {
                    MessageBox.Show("Varausta ei pystytty poistamaan", "Varauksen poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                TyhjennaBT.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
            VarauksetDG.DataSource = varaus.haeVaraukset();
        }

        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            HuoneNroCB.SelectedIndex = -1;
            VarausNroTB.Text = "";
            AsiakasNroCB.SelectedIndex = -1;
            HuoneTyyppiCB.SelectedIndex = -1;
            SisäänDTP.Value = DateTime.Now;
            UlosDTP.Value = DateTime.Now;

            
       
        }

        private void HuoneTyyppiCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ladataan) return; // ei aktivoida tätä kun klikataan taulusta tiedot lomakkeelle
            int huonetyyppi = HuoneTyyppiCB.SelectedIndex + 1;
            int nykyinen = Convert.ToInt32(HuoneNroCB.SelectedValue);
            HuoneNroCB.DataSource = huone.tyypillisetHuoneet(huonetyyppi, nykyinen); //päivitetään oikeat huonenumerot kun huonetyyppiä vaihdetaan
            HuoneNroCB.DisplayMember = "HuoneNro";
            HuoneNroCB.ValueMember = "HuoneNro";
            HuoneNroCB.SelectedValue = nykyinen;
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
