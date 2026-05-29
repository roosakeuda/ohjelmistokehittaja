using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class TILAUS
    {
        public List<TILAUSRIVI> Rivit = new List<TILAUSRIVI>();

        public void LisaaRivi(TILAUSRIVI uusi)
        {
            var loytyi = Rivit.FirstOrDefault(x => x.Avain == uusi.Avain); //tarkistaa löytyykö samanlainen tilausrivi
            if (loytyi != null)
            {
                loytyi.Maara++;
            }
            else //jos ei niin tekee uuden
            {
                Rivit.Add(uusi);

            }
        }

        public decimal LaskeVälisumma()
        {
            return Rivit.Sum(r => r.Yhteensa);
        }

        public decimal LaskeVero()
        {
            return LaskeVälisumma() * 0.13m; 
        }

        public decimal LaskeLoppusumma()
        {
            return LaskeVälisumma() + LaskeVero();
        }

    }
}
