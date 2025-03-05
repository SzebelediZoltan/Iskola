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

        public Csapat(string nev, List<Auto> autok, List<Versenyzo> versenyzok)
        {
            this.nev = nev;
            this.autok = autok;
            this.versenyzok = versenyzok;
        }

        public void Nevvaltas(string nev)
        {
            versenyzok[0].csapatnev = nev;
            versenyzok[1].csapatnev = nev;
            this.nev = nev;
        }
    }
}
