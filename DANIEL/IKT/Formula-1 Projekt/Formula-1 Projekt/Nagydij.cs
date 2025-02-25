using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        public Nagydij(string[] sor)
        {
            nev = sor[0];
            maxsebesseg = Convert.ToDouble(sor[1]);
            atlagsebesserg = Convert.ToDouble(sor[2]);
            helyezes = Convert.ToInt32(sor[3]);
            ev = Convert.ToInt32(sor[4]);
            csapatnev = Adatkezeles.csapatok.First(e => e.nev == sor[5]);
            versenyzo = Adatkezeles.versenyzok.First(e => e.nev == sor[6]);
            _ = sor[7] == "Igen" ? befejezteE = true : befejezteE = false;
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
