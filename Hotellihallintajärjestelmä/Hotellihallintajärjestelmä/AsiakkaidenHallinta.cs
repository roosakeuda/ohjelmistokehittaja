using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotellihallintajärjestelmä
{
    public partial class AsiakkaidenHallinta : Form
    {
        ASIAKAS asiakas = new ASIAKAS();
        public AsiakkaidenHallinta()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AsiakkaidenHallinta_Load(object sender, EventArgs e)
        {
            asiakkaatDG.DataSource = asiakas.haeAsiakkaat();
        }

        private void MuokkaaBT_Click(object sender, EventArgs e)
        {
            String enimi = enimiTB.Text;
            String snimi = snimiTB.Text;
            String osoite = OsoiteTB.Text;
            String postin = postinTB.Text;
            String ppaikka = ppaikkaTB.Text;
            String ktunnus = KtunnusTB.Text;

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || osoite.Trim().Equals("") || postin.Trim().Equals("") || ppaikka.Trim().Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, Osoite, Postinumero ja Postitoimipaikka", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean muokkaaAsiakas = asiakas.muokkaaAsiakasta(enimi, snimi, osoite, postin, ppaikka, ktunnus);
                if (muokkaaAsiakas)
                {
                    MessageBox.Show("Uusi asiakas päivitetty onnistuneesti", "Asiakkaan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta asiakasta ei pystytty päivittämään", "Asiakkaan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            asiakkaatDG.DataSource = asiakas.haeAsiakkaat();
            TyhjennaBT.PerformClick();
        }

        private void LisaaBT_Click(object sender, EventArgs e)
        {
            String enimi = enimiTB.Text;
            String snimi = snimiTB.Text;
            String osoite = OsoiteTB.Text;
            String postin = postinTB.Text;
            String ppaikka = ppaikkaTB.Text;
            String ktunnus = KtunnusTB.Text;
            String ssana = ssanaTB.Text;

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || osoite.Trim().Equals("") || postin.Trim().Equals("") || ppaikka.Trim().Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, Osoite, Postinumero ja Postitoimipaikka", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = asiakas.lisaaAsiakas(enimi, snimi, osoite, postin, ppaikka, ktunnus, ssana);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi asiakas lisätty onnistuneesti", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta asiakasta ei pystytty lisäämään", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            asiakkaatDG.DataSource = asiakas.haeAsiakkaat();
            TyhjennaBT.PerformClick();
        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            String ktunnus = KtunnusTB.Text;
            if (asiakas.poistaAsiakas(ktunnus))
            {
                asiakkaatDG.DataSource = asiakas.haeAsiakkaat();
                MessageBox.Show("Asiakas poistettu onnistuneesti", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Asiakasta ei pystytty poistamaan", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            asiakkaatDG.DataSource = asiakas.haeAsiakkaat();
            TyhjennaBT.PerformClick();
        }

        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            enimiTB.Text = "";
            snimiTB.Text = "";
            OsoiteTB.Text = "";
            postinTB.Text = "";
            ppaikkaTB.Text = "";
            KtunnusTB.Text = "";
            ssanaTB.Text = "";
        }

        private void asiakkaatDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            enimiTB.Text = asiakkaatDG.CurrentRow.Cells[0].Value.ToString();
            snimiTB.Text = asiakkaatDG.CurrentRow.Cells[1].Value.ToString();
            OsoiteTB.Text = asiakkaatDG.CurrentRow.Cells[2].Value.ToString();
            postinTB.Text = asiakkaatDG.CurrentRow.Cells[3].Value.ToString();
            ppaikkaTB.Text = asiakkaatDG.CurrentRow.Cells[4].Value.ToString();
            KtunnusTB.Text = asiakkaatDG.CurrentRow.Cells[5].Value.ToString();
        }

        private void asiakkaatDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            enimiTB.Text = asiakkaatDG.CurrentRow.Cells[0].Value.ToString();
            snimiTB.Text = asiakkaatDG.CurrentRow.Cells[1].Value.ToString();
            OsoiteTB.Text = asiakkaatDG.CurrentRow.Cells[2].Value.ToString();
            postinTB.Text = asiakkaatDG.CurrentRow.Cells[3].Value.ToString();
            ppaikkaTB.Text = asiakkaatDG.CurrentRow.Cells[4].Value.ToString();
            KtunnusTB.Text = asiakkaatDG.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
