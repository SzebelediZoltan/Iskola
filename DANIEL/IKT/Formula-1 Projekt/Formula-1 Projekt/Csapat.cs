using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula_1_Projekt
{
    internal class Csapat
    {
        public string nev;
        public List<Auto> autok;
        public List<Versenyzo> versenyzok;

        public Csapat(string[] sor)
        {
            nev = sor[0];
            autok = Adatkezeles.autok.Where(x => x.csapatnev == sor[1]).ToList();
            versenyzok = Adatkezeles.versenyzok.Where(x => x.csapatnev == sor[2]).ToList();
        }

        public void Nevvaltas(string nev)
        {
            versenyzok[0].csapatnev = nev;
            versenyzok[1].csapatnev = nev;
            this.nev = nev;
        }

        public int Gyozelmek(List<Nagydij> nagydijak)
        {
            return nagydijak.Where(e => e.versenyzo.csapatnev == nev && e.helyezes == 1).Count();
        }
    }
}
