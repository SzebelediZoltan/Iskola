using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    internal abstract class Peksutemeny : IArlap
    {
        //Adattagok
        protected double mennyiseg;
        private double alapar;

        //Konstruktor
        public Peksutemeny(double mennyiseg, double alapar)
        {
            this.mennyiseg = mennyiseg;
            this.alapar = alapar;
        }

        public abstract void Megkostol();

        public double MennyibeKerul()
        {
            return alapar * mennyiseg;
        }

        public override string ToString()
        {
            return $"{mennyiseg}db - {MennyibeKerul()}Ft";
        }
    }
}
