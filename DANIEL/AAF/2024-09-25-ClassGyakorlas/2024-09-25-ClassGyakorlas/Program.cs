using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _2024_09_25_ClassGyakorlas
{
    internal class Program
    {

        static List<szoba> szobak = new List<szoba>();
        static List<honap> honapok = new List<honap>();
        static void Main(string[] args)
        {
            feladatok.BeolvasasPity();
            feladatok.BeolvasasHo();

            Console.ReadLine();
        }

        class feladatok
        {
            public static void BeolvasasHo()
            {
                StreamReader fr = new StreamReader("honapok.txt");
                fr.ReadLine();

                while (!fr.EndOfStream)
                {
                    string[] sor = fr.ReadLine().Split(' ');

                    honapok.Add(new honap(sor));
                }

                fr.Close();
            }

            public static void BeolvasasPity()
            {
                StreamReader fr = new StreamReader("pitypang.txt");
                fr.ReadLine();

                while (!fr.EndOfStream)
                {
                    string[] sor = fr.ReadLine().Split(' ');

                    szobak.Add(new szoba(sor));
                }

                fr.Close();
            }

            public static void Feladat2()
            {
                szoba maxsz = szobak[0];
                int mej = szobak[0].tartozkodas();

                for (int i = 1; i < szobak.Count; i++)
                {
                    if (szobak[i].tartozkodas() > mej)
                    {
                        mej = szobak[i].tartozkodas();
                        maxsz = szobak[i];
                    }
                }

                Console.WriteLine($"{maxsz.nev} ({maxsz.erk}) - {mej}");
            }

            public static void Feladat3()
            {
                for (int i = 0; i < szobak.Count; i++)
                {
                    Console.WriteLine($"{szobak[i].sorszam}:{szobak[i].fizetendo()}");
                }
            }

            public static void Feladat4()
            {
                List<int> tartozkodsok = new List<int>();
                for(int i = 0;i < honapok.Count; i++)
                {
                    int osszesen = 0;
                    for (int j = 0; j < szobak.Count; j++)
                    {
                        if (honapok[i].kezdo < szobak[j].erk && szobak[j].erk < honapok[i].vegso)
                        {
                            osszesen += (szobak[j].tav - szobak[j].erk) * szobak[j].ven;
                            if (szobak[j].tav > honapok[i].vegso)
                            {
                                osszesen += (honapok[i].vegso - szobak[j].tav) * szobak[j].ven;
                            }
                        }
                    }
                    tartozkodsok.Add(osszesen);
                }
            }

            public static void Feladat5()
            {
                int erk = Convert.ToInt32(Console.ReadLine());
                int tav = erk + Convert.ToInt32(Console.ReadLine());

                int db = 0;
                for (int i = 0; i < szobak.Count; i++)
                {
                    if (erk > szobak[i].tav && tav < szobak[i].erk)
                    {
                        db++;
                    }
                }
            }
        }

        class honap
        {
            public int kezdo, vegso;
            public string nev;

            public honap(string[] sor)
            {
                this.kezdo = Convert.ToInt32(sor[1]);
                this.vegso = Convert.ToInt32(sor[2]);
                this.nev = sor[0];
            }
        }

        class szoba
        {
            public int sorszam, szobaszam, erk, tav, ven, reggeli, napiar, potagy;
            public string nev;

            public szoba(string[] sor)
            {
                this.sorszam = Convert.ToInt32(sor[0]);
                this.szobaszam = Convert.ToInt32(sor[1]);
                this.erk = Convert.ToInt32(sor[2]);
                this.tav = Convert.ToInt32(sor[3]);
                this.ven = Convert.ToInt32(sor[4]);
                this.reggeli = Convert.ToInt32(sor[5]);
                this.nev = sor[6];
                if (erk <= 120)
                {
                    napiar = 9000;
                }
                else if (erk <= 213)
                {
                    napiar = 10000;
                }
                else
                {
                    napiar = 8000;
                }
                if (ven == 3)
                {
                    potagy = 1;
                }
                else
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
