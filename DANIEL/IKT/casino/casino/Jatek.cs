using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casino
{
    internal abstract class Jatek: IJatek
    {
        public int MaxJatekos { get; set; }
        public string Nev { get; set; }
        protected abstract string Jatekszabaly { get; set; }
    }
}
