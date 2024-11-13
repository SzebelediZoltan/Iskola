using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_13
{
    internal class Fonok : Dolgozo, IElsodleges
    {
        public Fonok(string nev) : base(nev, 10, true) { }

        public override string ToString()
        {
            return "(Fonok)" + base.ToString();
        }
    }
}
