using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_22_TesztelésiAlapok
{

    /// <summary>
    /// Aosztályra vonatkozó információk megadása
    /// </summary>
    internal class Aosztaly
    {
        /// <summary>
        /// Általános függvény leírás
        /// </summary>
        /// <param name="a">A paraméterről információ</param>
        /// <returns>Mi lesz a visszatérési érték</returns>
        public double Metodus1(double a)
        {
            return Math.Asin(Math.Abs(a/10000));
        }

        /// <summary>
        /// Az adott osztály szöveges megjelenítése
        /// </summary>
        /// <returns>Szöveges visszatérés</returns>
        public override string ToString()
        {
            return "Adatok kiírása";
        }

    }
}
