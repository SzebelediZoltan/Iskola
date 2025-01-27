using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaszinoProjekt
{
    internal abstract class Jatek: IJatek
    {
        public int Maxjatekos { get; set; }
        public string Nev { get; set; }
        protected string Jatekszabaly { get; set; }
    }
}
