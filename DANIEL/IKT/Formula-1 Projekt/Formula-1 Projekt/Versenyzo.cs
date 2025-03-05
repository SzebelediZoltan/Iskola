using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Formula_1_Projekt
{
    public class Versenyzo : IVersenyzo
    {
        public string nev, csapatnev;
        public int kor, magassag;

        public Versenyzo(string[] sor)
        {
            nev = sor[0];
            csapatnev = sor[1];
            kor = Convert.ToInt32(sor[2]);
            magassag = Convert.ToInt32(sor[3]);
        }

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

        public int gyozelmekSzama(List<Nagydij> nagydijak)
        {
            return nagydijak.Where(e => e.versenyzo.nev == nev && e.helyezes == 1).Count();
        }
    }
}
