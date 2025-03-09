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

        public string Nev { get { return nev; } }
        public string Csapat { get { return csapatnev; } }
        public int Kor { get { return kor; } }
        public int Magassag { get { return magassag; } }

        public int GyozelmekSzama { get { return gyozelmekSzama(Adatkezeles.nagydijak); } }

        /// <summary>
        /// Átigazoltatja a játékost egyik létező csapatból a másikba
        /// </summary>
        /// <param name="honnan">A csapat honnan igazol</param>
        /// <param name="hova">A csapat ahova igazol</param>
        public void Atigazolas(Csapat honnan, Csapat hova)
        { 
            honnan.versenyzok.Remove(this);
            hova.versenyzok.Add(this);

            honnan.versenyzok.Add(hova.versenyzok[1]);
            hova.versenyzok.RemoveAt(1);

            csapatnev = hova.nev;
        }


        /// <summary>
        /// Megnöveli a versenyző korát 1-el
        /// </summary>
        public void Oregszik()
        {
            kor++;
        }

        /// <summary>
        /// Visszaadja a versenyző eddig győzelmeinek számát
        /// </summary>
        /// <param name="nagydijak"></param>
        /// <returns></returns>
        public int gyozelmekSzama(List<Nagydij> nagydijak)
        {
            return nagydijak.Where(e => e.versenyzo.nev == nev && e.helyezes == 1).Count();
        }
    }
}
