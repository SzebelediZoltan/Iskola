using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_13
{
    internal class vezeto : Dolgozo, IElsodleges
    {
        private int csapat;

        public vezeto(string nev, int csapat, int evek = 5) : base(nev, evek)
        {
            this.csapat = csapat;
        }

        public int Csapat
        {
            get { return csapat; }
        }

        public override string ToString()
        {
            return $"(Vezeto )" + base.ToString() + $", Csapat: {csapat}";
        }
    }
}
