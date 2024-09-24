using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Dynamic;

namespace pitypipang
{
    internal class Program
    {

        static List<szoba> szobak = new List<szoba>();
        static void Main(string[] args)
        {
            Beolvasas();

        }

        static void Beolvasas()
        {
            BeSzoba();
        }

        static void BeSzoba()
        {
            StreamReader fr = new StreamReader("pitypang.txt");
            fr.ReadLine();

            while (!fr.EndOfStream)
            {
                string[] sor = fr.ReadLine().Split(' ');

                szobak.Add(new szoba(Convert.ToInt32(sor[0]), Convert.ToInt32(sor[1]), Convert.ToInt32(sor[2]), Convert.ToInt32(sor[3]), Convert.ToInt32(sor[4]), Convert.ToInt32(sor[5]), sor[6]));
            }

            fr.Close();
        }

        struct szoba
        {
            public int sorszam, szobaszam, erk, tav, ven, reggeli, napiar, potagy;
            public string nev;

            public szoba(int sorszam, int szobaszam, int erk, int tav, int ven, int reggeli, string nev)
            {
                this.sorszam  = sorszam;
                this.tav = tav;
                this.ven = ven;
                this.reggeli = reggeli;
                this.nev = nev;
                this.erk = erk;
                this.szobaszam = szobaszam;
                if (erk <= 120)
                {
                    napiar = 9000;
                } else if (erk <= 213){
                    napiar = 10000;
                } else
                {
                    napiar = 8000;
                }
                if (ven == 3)
                {
                    potagy = 1;
                } else
                {
                    potagy = 0;
                }
            }

            public int tartozkodas()
            {
                return tav - erk;
            }

            public int fizetendo()
            {
                return tartozkodas() * ven * reggeli * 1100 + tartozkodas() * potagy * 2000 + tartozkodas() * napiar;
            }
        }
    }
}
