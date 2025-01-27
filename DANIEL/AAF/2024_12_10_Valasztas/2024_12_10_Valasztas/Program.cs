using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_10_Valasztas
{
    internal class Program
    {
        static List<Kepviselo> t = Kepviselo.kepviselok;
        static void Main(string[] args)
        {
            Kepviselo.Fajlbeolvasas("szavazatok.txt");

            int kepviselo = t.Count();

            //Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();

            Console.ReadLine();
        }

        private static void Feladat7()
        {
            var nyertesek = t
                .GroupBy(x => x.sorszam)
                .Select(g => new
                {
                    valasztokerulet = g.Key,
                    nyertes = g.First(c => c.szavazat == g.Max(f => f.szavazat))
                })
                .OrderBy(c => c.nyertes.sorszam);

            foreach (var n in nyertesek)
            {
                Kepviselo kepvisel = n.nyertes;
                Console.WriteLine(n.valasztokerulet + ": " + kepvisel.kernev + " " + kepvisel.veznev + " - " + (kepvisel.part == "-" ? "független" : kepvisel.part) + " " + kepvisel.szavazat);
            }
        }

        private static void Feladat6()
        {
            var legtobbSzavazat = t.Where(c => c.szavazat == t.Max(x => x.szavazat));

            foreach ( var item in legtobbSzavazat)
            {
                Console.WriteLine(item.kernev + " " + item.veznev + " " + (item.part == "-" ? "független" : item.part));
            }

        }

        private static void Feladat5()
        {
            //var csoportositas = from x in t
            //                    group x by x.part into g
            //                    select new
            //                    {
            //                        part = g.Key,
            //                        sum = g.Count()
            //                    };

            var csoportositas = t.
                GroupBy(x=>x.part).
                Select(g => new { 
                    part = g.Key,
                    sum = g.Count()
                });

            foreach (var item in csoportositas)
            {
                Console.WriteLine(item.part + " " + item.sum);
            }
        }

        private static void Feladat4()
        {
            int um = t.Sum(x => x.szavazat);
            Console.WriteLine($"A választáson {um} állampolgátszavazott, a jogosultak {Math.Round((double)um/123.45, 2)}%-a vett részt.");
        }

        static void Feladat3()
        {
            Console.Write("Adja meg a vezetéknevet: ");
            string vnev = Console.ReadLine();
            Console.Write("Adja meg a keresztnevet: ");
            string knev = Console.ReadLine();

            int index = t.FindIndex(x => x.veznev == vnev && x.kernev == knev);
            if (index >= 0)
                Console.WriteLine($"{t[index].veznev} {t[index].kernev}: {t[index].szavazat}");
            else
                Console.WriteLine("Nem létezik ilyen nevezetű képviselő a nyilvántartasban!");

        }
    }
}
