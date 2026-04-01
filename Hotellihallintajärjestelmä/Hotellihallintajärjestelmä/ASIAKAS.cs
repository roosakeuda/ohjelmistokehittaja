using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Runtime.InteropServices.ComTypes;

namespace Hotellihallintajärjestelmä
{
    internal class ASIAKAS
    {

        Yhdista yhteys = new Yhdista();

        public bool lisaaAsiakas(String enimi, String snimi, String  osoite, String postin, String ppaikka, String ktunnus, String ssana)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO asiakkaat " +
               "(ktunnus, Etunimi, Sukunimi, Lähiosoite, Postinumero, Postitoimipaikka, Salasana) " +
               "VALUES (@ktu, @enm, @snm, @oso, @pno, @ptp, @ssa); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.OtaYhteys();

            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = postin;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ppaikka;

            //käyttäjätunnuksen luonti jos ei ole itse määritetty
            if (ktunnus != "")
            {
                komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = ktunnus.ToLower();
            }
            else
            { 
                komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = enimi.Substring(0, 3).ToLower() + snimi.Substring(0, 3).ToLower() + snimi.Substring(1,1).ToUpper();
            }
            
            //salasanan luonti jos ei ole itse määritetty
            if (ssana != "")
            {
                komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = ssana;
            }
            else
            {
                komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = luoSalasana();
            }

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

        public DataTable haeAsiakkaat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT Etunimi, Sukunimi, Lähiosoite, Postinumero, Postitoimipaikka, ktunnus FROM asiakkaat");
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            komento.Connection = yhteys.OtaYhteys();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;

        }

        public bool muokkaaAsiakasta(String enimi, String snimi, String osoite, String postin, String ppaikka, String ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `asiakkaat` SET `Etunimi` = @enm," +
                "`Sukunimi` = @snm, `Lähiosoite` = @oso, `Postinumero` = @pno, `Postitoimipaikka` = @ptp" +
                " WHERE ktunnus = @ktu";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.OtaYhteys();

            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = postin;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ppaikka;
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = ktunnus;

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

        public bool poistaAsiakas(String ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM asiakkaat WHERE ktunnus = @ktu";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.OtaYhteys();

            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value=ktunnus;

            yhteys.AvaaYhteys();
            if (komento.ExecuteNonQuery()==1)
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

        public DataTable asiakaslista()
        {   
            MySqlCommand komento = new MySqlCommand(
                "SELECT ktunnus, CONCAT(Etunimi, ' ', Sukunimi) AS Kokonimi FROM asiakkaat",
                yhteys.OtaYhteys());

            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }


        public String luoSalasana()
        {
            char[] alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#€?0123456789".ToCharArray();
            Random satunnaisluku = new Random();
            String salasana = "";
            for (int i = 0; i < 12; i++)
            {
                int indeksi = satunnaisluku.Next(alpha.Length);
                salasana += alpha[indeksi];
            }
            return salasana;
        }
    }
    
}
