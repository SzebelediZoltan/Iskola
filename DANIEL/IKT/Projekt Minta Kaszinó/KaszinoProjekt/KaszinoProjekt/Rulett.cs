using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaszinoProjekt
{
    internal class Rulett : Jatek
    {

        static List<int> piros = new List<int>() { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
        static List<int> fekete = new List<int>(){2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35};

        public Rulett()
        {
            Maxjatekos = 5;
            Nev = "Rulett";
            Jatekszabaly = "0-36 közötti szám kiválasztása vagy szín (fekete, piros, zöld) megadása. Nyer ha eltalálja.";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>0, zöld, 1, fekete, 2 piros</returns>
        public (int, int) KiporgetettErtek()
        { 
            Random rnd = new Random();
            int r = rnd.Next(0, 37);
            int szin = piros.Contains(r) ? 2 : fekete.Contains(r) ? 1 : 0;
            return (r, szin);
        }
    }
}
