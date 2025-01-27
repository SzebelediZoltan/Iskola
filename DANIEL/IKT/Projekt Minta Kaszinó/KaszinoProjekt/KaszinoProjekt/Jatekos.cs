using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaszinoProjekt
{
    internal class Jatekos : IJatekos
    {
        public double Egyenleg { get; set; }
        public int Id { get; set; }
        public bool Jatekban { get; set; }

        public void Befizetes(double ertek)
        {
            Egyenleg += ertek;
        }

    }
}
