using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    internal class Pogacsa : Peksutemeny
    {

        public Pogacsa(double alapar, double mennyiseg) : base(mennyiseg, alapar)
        {

        }


        public override void Megkostol()
        {
            mennyiseg /= 2;
        }

        public override string ToString()
        {
            return "Pogácsa" + base.ToString();
        }
    }
}
