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
        public string nev; 
        public TimeSpan ido;
        public double maxsebesseg, atlagsebesseg;
        public int helyezes, ev;
        public Csapat csapatnev;
        public Versenyzo versenyzo;
        public bool befejezteE;

        public string Nagydij_Nev { get { return nev; } }
        public TimeSpan Legjobb_Kör { get { return ido; } }
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

            string[] idoSor = sor[8].Split(':');
            if (idoSor.Length == 1)
            {
                ido = new TimeSpan(0, 0, 0);
            } else
            {
                ido = new TimeSpan(Convert.ToInt32(idoSor[0]), Convert.ToInt32(idoSor[1]), Convert.ToInt32(idoSor[2]));
            }
        }

        /// <summary>
        /// Beállítj a paraméterben megadott időre az adott időt
        /// </summary>
        /// <param name="pontosIdo">Pontos ido</param>
        public bool idoKorrekcio(string pontosIdo)
        {
            string[] idoSor = pontosIdo.Split(':');
            if (Convert.ToInt32(idoSor[0]) < 0 || Convert.ToInt32(idoSor[1]) < 0 || Convert.ToInt32(idoSor[2]) < 0)
            {
                return false;
            }
            ido = new TimeSpan(Convert.ToInt32(idoSor[0]), Convert.ToInt32(idoSor[1]), Convert.ToInt32(idoSor[2]));
            return true;
        }
        
        /// <summary>
        /// DNF-elteti az adott versenyzőt
        /// </summary>
        public void DNF()
        {
            befejezteE = false;
        }
    }
}
