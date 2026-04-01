using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotellihallintajärjestelmä
{
    internal class VARAUKSET
    {
        Yhdista yhteys = new Yhdista();

        public DataTable varaustyyppilista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM varaukset", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }


        public bool lisaaVaraus(int hnro, string anro, DateTime sisaan, DateTime ulos)
        {
           
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO `varaukset` " +
               "(HuoneenNro, AsiakasID, Sisaan, Ulos) " +
               "VALUES (@hno, @aid, @sis, @ulo); ";

            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.OtaYhteys();


            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnro;
            komento.Parameters.Add("@aid", MySqlDbType.VarChar).Value = anro;
            komento.Parameters.Add("@sis", MySqlDbType.DateTime).Value = sisaan;
            komento.Parameters.Add("@ulo", MySqlDbType.DateTime).Value = ulos;


            yhteys.AvaaYhteys();

            try
            {
                if (komento.ExecuteNonQuery() == 1)
                {
                    yhteys.SuljeYhteys();
                    return true;
                }

                else
                {
                    yhteys.SuljeYhteys();
                    return false;
                }
            }
            catch (Exception ex)
            {
                yhteys.SuljeYhteys();
                MessageBox.Show("Virhe: " + ex);
                return false;
            }


        }

        public DataTable haeVaraukset()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM varaukset", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();

            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;

        }

        public bool muokkaaVarausta(int hnro, string asid, DateTime sisaan, DateTime ulos, int vara)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `varaukset` SET `HuoneenNro` = @hno," +
                "`AsiakasId` = @aid, `Sisaan` = @sis, `Ulos` = @ulo" +
                " WHERE VarausId = @vid";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.OtaYhteys();

            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnro;
            komento.Parameters.Add("@aid", MySqlDbType.VarChar).Value = asid;
            komento.Parameters.Add("@sis", MySqlDbType.DateTime).Value = sisaan;
            komento.Parameters.Add("@ulo", MySqlDbType.DateTime).Value = ulos;
            komento.Parameters.Add("@vid", MySqlDbType.Int32).Value = vara;


            yhteys.AvaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.SuljeYhteys();
                return true;
            }
            else
            {
                yhteys.SuljeYhteys();
                return false;
            }
        }

        public bool poistaVaraus(String varausnro)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM varaukset WHERE VarausId = @vid";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.OtaYhteys();

            komento.Parameters.Add("@vid", MySqlDbType.VarChar).Value = varausnro;

            yhteys.AvaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.SuljeYhteys();
                return true;
            }
            else
            {
                yhteys.SuljeYhteys();
                return false;
            }
        }

    }
}


