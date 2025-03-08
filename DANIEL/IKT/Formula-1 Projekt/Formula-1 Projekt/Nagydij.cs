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

        public string Nagydij_Nev { get { return nev; } }
        public string Legjobb_Kör { get { return ido; } }
        public double Max_Sebesseg { get { return maxsebesseg; } }
        public double Atlag_Sebesseg { get { return atlagsebesseg; } }
        public int Helyezes { get { return helyezes; } }
        public int Szezon { get { return ev; } }
        public string Csapat { get { return csapatnev.nev; } }
        public string Pilota { get { return versenyzo.nev; } }
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
