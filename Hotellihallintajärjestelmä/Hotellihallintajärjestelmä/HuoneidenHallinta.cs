using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotellihallintajärjestelmä
{
    public partial class HuoneidenHallinta : Form
    {
        Huone huone = new Huone();
        public HuoneidenHallinta()
        {
            InitializeComponent();
        }

        private void HuoneidenHallinta_Load(object sender,   EventArgs e)
        {
            huoneetDG.DataSource = huone.haeHuoneet();
        }

        private void LisaaBT_Click(object sender, EventArgs e)
        {
            int huonetyyppi = HuoneTyyppiGB.SelectedIndex + 1;
            String vapaa; 
            int huonenro = int.Parse(HuoneNroTB.Text);
            
            if (KyllaRB.Checked)
            {
                vapaa = "Kyllä";
            }
            else
            {
                vapaa = "Ei";
            }
            String puhelin = PuhelinTB.Text;

                if (puhelin.Trim().Equals("") || HuoneTyyppiGB.SelectedIndex == -1)
                {
                    MessageBox.Show("VIRHE - Täytä kaikki kentät", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean lisaaHuone = huone.lisaaHuone(huonenro, huonetyyppi, puhelin,vapaa);
                    if (lisaaHuone)
                    {
                        MessageBox.Show("Uusi huone lisätty onnistuneesti", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        huoneetDG.DataSource = huone.haeHuoneet();
                        TyhjennaBT.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Uutta huonetta ei pystytty lisäämään", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
        }

        private void MuokkaaBT_Click(object sender, EventArgs e)
        {
            int tyyppi = HuoneTyyppiGB.SelectedIndex + 1;
            String puhelin = PuhelinTB.Text;
            String vapaa = "";
            try
            {
                int numero = Convert.ToInt32(HuoneNroTB.Text);
                if(KyllaRB.Checked)
                {
                    vapaa = "Kyllä";
                }
                else
                {
                    vapaa = "Ei";
                } 

                if (huone.muokkaaHuonetta(numero, tyyppi, puhelin, vapaa))
                {
                    MessageBox.Show("Huone muokattu onnistuneesti", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huonetta ei pystytty muokkaamaan", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message, "Huoneen numero virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            huoneetDG.DataSource = huone.haeHuoneet();
            TyhjennaBT.PerformClick();
        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            try
            {
                String huonenro = HuoneNroTB.Text;
                if (huone.poistaHuone(huonenro))
                {
                    huoneetDG.DataSource = huone.haeHuoneet();
                    MessageBox.Show("Huone poistettu onnistuneesti", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huonetta ei pystytty poistamaan", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                huoneetDG.DataSource = huone.haeHuoneet();
                TyhjennaBT.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message);
            }

        }

        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            HuoneNroTB.Text = "";
            PuhelinTB.Text = "";
            HuoneTyyppiGB.SelectedIndex = -1;
            KyllaRB.Checked = false;
            EiRB.Checked = false;
        }

        private void HuoneTyyppiTB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void huoneetDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void huoneetDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HuoneNroTB.Text = huoneetDG.CurrentRow.Cells[0].Value.ToString();

            // huonetyyppin merkkaus valitulla indeksillä
            HuoneTyyppiGB.SelectedIndex = Convert.ToInt32(huoneetDG.CurrentRow.Cells[1].Value) - 1;
            PuhelinTB.Text = huoneetDG.CurrentRow.Cells[2].Value.ToString();

            //tarkistetaan varauksen tilanne, ja laitetaan täppä oikeaan boksiin
            if (huoneetDG.CurrentRow.Cells[3].Value.ToString() == "Kyllä")
            {
                KyllaRB.Checked = true;
                EiRB.Checked = false;
            }
            else
            {
                EiRB.Checked = true;
                KyllaRB.Checked = false;
            }
        }
    }
}
