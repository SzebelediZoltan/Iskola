using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Formula_1_Projekt
{
    public class Nagydij
    {
        public string nev, ido;
        public double maxsebesseg, atlagsebesseg;
        public int helyezes, ev;
        public Csapat csapatnev;
        public Versenyzo versenyzo;
        public bool befejezteE;

        public string Nev { get { return nev; } }
        public string Ido { get { return ido; } }
        public double Maxsebesseg { get { return maxsebesseg; } }
        public double Atlagsebesseg { get { return atlagsebesseg; } }
        public int Helyezes { get { return helyezes; } }
        public int Ev { get { return ev; } }
        public string Csapatnev { get { return csapatnev.nev; } }
        public string Versenyzo { get { return versenyzo.nev; } }
        public bool BefejezteE { get { return befejezteE; } }

        public Nagydij(string[] sor)
        {
            nev = sor[1];
            maxsebesseg = Convert.ToDouble(sor[4]);
            atlagsebesseg = Convert.ToDouble(sor[5]);
            helyezes = Convert.ToInt32(sor[6]);
            ev = Convert.ToInt32(sor[0]);
            csapatnev = Adatkezeles.csapatok.First(e => e.nev == sor[3]);
            versenyzo = Adatkezeles.versenyzok.First(e => e.nev == sor[2]);
            _ = sor[7] == "Igen" ? befejezteE = true : befejezteE = false;
            ido = sor[8];
        }

        public void idoKorrekcio(string pontosIdo)
        {
            ido = pontosIdo;
        }

        public void DNF()
        {
            befejezteE = false;
        }
    }
}
