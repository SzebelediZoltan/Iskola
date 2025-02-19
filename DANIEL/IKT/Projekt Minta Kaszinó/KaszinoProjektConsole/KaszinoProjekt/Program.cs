using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KaszinoProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asztal asztal = new Asztal(5, new Rulett());
            Ellenorzes(asztal);


            /* Házi feladat
             * Teszteld az 
             * - Asztal osztály: JatekosBehivasa és TetBekerese eljrásáokat több példány (legalább 3) segítségével Jatekban és egyeneleg változók ellenőrzésével!
             * - Rulett osztály KiporgetettErtek függvényét! */



            Console.ReadLine();
        }


        private static void Ellenorzes(Asztal asztal)
        {
            List<Jatekos> jatekosok = new List<Jatekos>();
            bool telthaz = false;
            do
            {
                jatekosok.Add(new Jatekos());
                Console.WriteLine(jatekosok.Last().ToString());
                telthaz = !asztal.JatekosBehivasa(jatekosok.Last());
                if (telthaz) Console.WriteLine("Több ember nem fér el ennél az asztalnál!");

            } while (!telthaz);
            asztal.JatekMenete();
            foreach (var item in jatekosok)
            {
                Console.WriteLine(item);
            }
            //Jatekos j2 = jatekos1.Copy();
            //j2.Egyenleg = 3333;
            //Console.WriteLine(j2.ToString());
            //Console.WriteLine(jatekos1.ToString());
        }
    }
}
