using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaszinoProjekt
{
    public class Jatek: IJatek
    {
        public string Nev { get; set; }
        protected string Jatekszabaly { get; set; }
    }
}
