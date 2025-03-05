using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula_1_Projekt
{
    internal class Versenyzo : IVersenyzo
    {
        public string nev, csapatnev;
        public int kor, magassag;

        public void Atigazolas(Csapat honnan, Csapat hova)
        {
            honnan.versenyzok.Remove(this);
            hova.versenyzok.Add(this);

            honnan.versenyzok.Add(hova.versenyzok[1]);
            hova.versenyzok.RemoveAt(1);

            csapatnev = hova.nev;
        }

        public void Oregszik()
        {
            kor++;
        }
    }
}
