using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepjarmu_Feladat
{
    internal class AudiS8 : Jarmu
    {
        bool lezerblokkolo;

        public AudiS8(int aktSebesseg, string rendszam, bool lezerblokkolo) : base(aktSebesseg, rendszam)
        {
            this.lezerblokkolo = lezerblokkolo;
        }


        public override bool gyorshajtottE(int sebessegkorlat)
        {
            if (lezerblokkolo)
            {
                return false;
            }

            if (aktSebesseg > sebessegkorlat)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "Audi: " + base.ToString(); 
        }
    }
}
