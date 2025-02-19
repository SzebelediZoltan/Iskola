using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula_1_Projekt
{
    internal class Nagydij
    {
        public string nev;
        public double maxsebesseg, atlagsebesserg;
        public int helyezes, ev;
        public Csapat csapatnev;
        public Versenyzo versenyzo;
        public bool befejezteE;
        public TimeSpan ido;

        public Nagydij(string nev, double maxsebesseg, double atlagsebesserg, int helyezes, int ev, Csapat csapatnev, Versenyzo versenyzo, bool befejezteE, TimeSpan ido)
        {
            this.nev = nev;
            this.maxsebesseg = maxsebesseg;
            this.atlagsebesserg = atlagsebesserg;
            this.helyezes = helyezes;
            this.ev = ev;
            this.csapatnev = csapatnev;
            this.versenyzo = versenyzo;
            this.befejezteE = befejezteE;
            this.ido = ido;
        }

        public void idoKorrekcio(TimeSpan pontosIdo)
        {
            ido = pontosIdo;
        }

        public void DNF()
        {
            befejezteE = false;
        }
    }
}
