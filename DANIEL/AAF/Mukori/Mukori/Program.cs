using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mukori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Versenyzo.GetVersenyzok();
            Feladat2();
            Feladat3();
            Feladat4();

            Console.ReadLine();
        }

        private static void Feladat4()
        {
            Console.WriteLine();
        }

        private static void Feladat3()
        {
            Console.WriteLine(Versenyzo.donto.Any(c=>c.orszag == "HUN"));
        }

        private static void Feladat2()
        {
            Console.WriteLine(Versenyzo.rovidprogram.Count());
        }
    }
}
