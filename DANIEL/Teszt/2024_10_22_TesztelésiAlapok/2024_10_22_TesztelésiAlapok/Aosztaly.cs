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
            return Math.Asin(Math.Abs(a / 10000));
        }
         /// <summary>
         /// Eloszt egy számot egy másikkal
         /// </summary>
         /// <param name="osztando">Osztandó szám</param>
         /// <param name="oszto">Osztó szám</param>
         /// <returns>Visszatér a hányadossal egészként</returns>
        public int Osztas(int osztando, int oszto)
        {
            return osztando / oszto;
        }
         /// <summary>
         /// Egy számot egy másik szám hatványára hoz
         /// </summary>
         /// <param name="szam">Hatványozandó szám</param>
         /// <param name="hatvanykitevo">Hanyadik hatványra emelje</param>
         /// <returns>Visszatér a megadott szám megadott hatványával</returns>
        public double Hatvanyozas(int szam, int hatvanykitevo)
        {
            double eredmeny = szam;
            if (hatvanykitevo == 0)
            {
                return 1;
            }
            for (int i = 0; i < hatvanykitevo-1; i++)
            {
                eredmeny *= szam;
            }

            return eredmeny;
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
