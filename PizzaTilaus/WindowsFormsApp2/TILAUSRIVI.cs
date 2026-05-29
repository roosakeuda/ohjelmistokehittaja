using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class TILAUSRIVI
    {

        public string Nimi { get; set; }
        public int Maara { get; set; }
        public decimal Yksikkohinta { get; set; }

        public List<string> Taytteet
            = new List<string>();

        public decimal Yhteensa
        {
            get { return Maara * Yksikkohinta; }
        }

        public string Avain //tarkistamaan onko tilauksessa jo samanlainen tilausrivi
        {
            get
            {
                return Nimi + "|" +
                       string.Join(",", Taytteet);
            }
        }
    }

}

