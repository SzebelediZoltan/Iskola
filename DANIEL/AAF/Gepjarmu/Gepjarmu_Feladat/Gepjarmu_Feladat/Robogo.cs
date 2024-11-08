using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepjarmu_Feladat
{
    internal class Robogo : Jarmu, KisGepjarmu
    {
        int maximalisSeb;

        public Robogo(int aktSebesseg, string rendszam, int maximalisSeb) : base(aktSebesseg, rendszam)
        {
            this.maximalisSeb = maximalisSeb;
        }

        public override bool gyorshajtottE(int sebessegkorlat)
        {
            return sebessegkorlat < aktSebesseg;
        }

        public bool haladhatItt(int sebesseg)
        {
            return sebesseg > maximalisSeb;
        }

        public override string ToString()
        {
            return "Robogo - " + base.ToString();
        }
    }
}
