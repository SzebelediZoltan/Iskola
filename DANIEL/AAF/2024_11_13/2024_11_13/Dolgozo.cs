using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_13
{
    internal class Dolgozo
    {
        private string nev;
        private int evek;
        public bool aktiv;

        public Dolgozo(string nev, int evek = 0, bool aktiv = false)
        {
            this.nev = nev;
            this.evek = evek;
            this.aktiv = aktiv;
        }

        public void ModositAktivitas()
        {
            aktiv =  Convert.ToBoolean(Convert.ToInt32(aktiv) * -1);
        }

        public void UjEv()
        {
            evek++;
        }

        public string Nev
        {
            get { return nev; }
        }

        public int Evek
        {
            get { return evek; }
        }

        public override string ToString()
        {
            return $"{Nev} - Ev: {evek}, Aktiv: {aktiv}";
        }
    }
}
