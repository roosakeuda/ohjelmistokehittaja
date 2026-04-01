using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Hotellihallintajärjestelmä
{
    internal class Huone
    {
        Yhdista yhteys = new Yhdista();


        public DataTable huonetyyppilista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM huonetyypit", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }

        public bool lisaaHuone(int hnro, int htyyppi, String puh, String vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO huoneet " +
               "(HuoneNro, Huonetyyppi, Puhelin, Vapaa) " +
               "VALUES (@hno, @hty, @puh, @vap); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.OtaYhteys();

            komento.Parameters.Add("@hno", MySqlDbType.VarChar).Value = hnro;
            komento.Parameters.Add("@hty", MySqlDbType.VarChar).Value = htyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vapaa;


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
            catch(Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
                return true;
            }


        }

        public DataTable haeHuoneet()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM huoneet", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
      
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;

        }

        public bool muokkaaHuonetta(int hnro, int htyyppi, String puh, String vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `huoneet` SET `Huonetyyppi` = @hty," +
                "`Puhelin` = @puh, `Vapaa` = @vap" +
                " WHERE HuoneNro = @hno";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.OtaYhteys();

            komento.Parameters.Add("@hno", MySqlDbType.VarChar).Value = hnro;
            komento.Parameters.Add("@hty", MySqlDbType.VarChar).Value = htyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vapaa;


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

        public bool poistaHuone(String hnro)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM huoneet WHERE HuoneNro = @hno";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.OtaYhteys();

            komento.Parameters.Add("@hno", MySqlDbType.VarChar).Value = hnro;

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


        public DataTable tyypillisetHuoneet(int htype, int nykyinen)
        {
            MySqlCommand komento = new MySqlCommand();

            //valitsee huoneet jotka ovat haluttua huonetyyppiä, ja jotka ovat vapaita / nykyinen valinta.
            string lisayskysely = "SELECT * from huoneet WHERE Huonetyyppi = @htype AND (Vapaa = 'Kyllä' OR HuoneNro = @nykyinen)";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.OtaYhteys();

            komento.Parameters.Add("@htype", MySqlDbType.Int32).Value = htype;
            komento.Parameters.Add("@nykyinen", MySqlDbType.Int32).Value = nykyinen;
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;  
        }

        public DataTable kaikkiHuoneetLista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM huoneet", yhteys.OtaYhteys());

            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }


        public bool vaihdaHuoneenVapaus(string vapaus, int huone)
        {

            //vaihtaa huoneen varauksen päikseen, jos vapaa nyt vaihtaa varatuksi ja toisinpäin
            if (vapaus == "Kyllä")
            {
                vapaus = "Ei";
            }
            else
            {
                vapaus = "Kyllä";
            }
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `huoneet` SET `Vapaa`= @vap WHERE HuoneNro = @hno";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = huone;
            komento.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vapaus;

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

        public int haeHuoneVarausIdlla(int varausId)
        {

            //etsii huoneen numeron varausid llä
            MySqlCommand komento = new MySqlCommand(
                "SELECT HuoneenNro FROM varaukset WHERE VarausId = @vid",
                yhteys.OtaYhteys()
            );

            komento.Parameters.Add("@vid", MySqlDbType.Int32).Value = varausId;

            yhteys.AvaaYhteys();
            int huone = Convert.ToInt32(komento.ExecuteScalar());
            yhteys.SuljeYhteys();

            return huone;
        }
    }
}
