using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mukori
{
    internal class Versenyzo
    {
        public static List<Versenyzo> rovidprogram, donto;
        public string nev, orszag;
        public double tpont, kpont;
        public int hibap;

        public Versenyzo(string[] sor)
        {
            this.nev = sor[0];
            this.orszag = sor[1];
            this.tpont = Convert.ToDouble(sor[2].Replace(".",","));
            this.kpont = Convert.ToDouble(sor[3].Replace(".", ","));
            this.hibap = Convert.ToInt32(sor[4]);
        }

        public static List<Versenyzo> FajlBeolvasas(string path)
        {
            List<Versenyzo> versenyzok = new List<Versenyzo>();

            StreamReader sr = new StreamReader(path);
            sr.ReadLine();
            while(!sr.EndOfStream)
            {
                versenyzok.Add(new Versenyzo(sr.ReadLine().Split(';')));
            }

            return versenyzok;
        }

        public static void GetVersenyzok()
        {
            rovidprogram = FajlBeolvasas("rovidprogram.csv");
            donto = FajlBeolvasas("donto.csv");
        }

    }
}
