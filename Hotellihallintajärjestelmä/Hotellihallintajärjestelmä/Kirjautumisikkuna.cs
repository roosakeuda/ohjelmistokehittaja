using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotellihallintajärjestelmä
{
    public partial class KirjautumisikkunaFM : Form
    {
        public KirjautumisikkunaFM()
        {
            InitializeComponent();
        }

        private void KirjauduBT_Click(object sender, EventArgs e)
        {
            Yhdista tietokantaan = new Yhdista();

            DataTable taulu = new DataTable();
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            MySqlCommand komento = new MySqlCommand();


            String kysely = "SELECT ktunnus, Salasana FROM asiakkaat WHERE ktunnus = @kt AND Salasana = @ss";

            komento.CommandText = kysely;
            komento.Connection = tietokantaan.OtaYhteys();

            komento.Parameters.Add("@kt", MySqlDbType.VarChar).Value = kayttajaTB.Text;
            komento.Parameters.Add("@ss", MySqlDbType.VarChar).Value = SalasanaTB.Text;

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            if (taulu.Rows.Count > 0)
            {
                this.Hide();
                Paaikkuna plomake = new Paaikkuna();
                plomake.Show();
            }
            else
            {
                if (kayttajaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä käyttäjänimesi kirjautuaksesi","Käyttäjänimi on tyhjä", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (SalasanaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä salasana kirjautuaksesi", "Salasana on tyhjä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Käyttäjänimeä tai salasanaa ei löydy", "Tietoja ei löydy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SalasanaTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
