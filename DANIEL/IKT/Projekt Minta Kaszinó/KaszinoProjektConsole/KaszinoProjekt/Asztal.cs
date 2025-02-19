using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace KaszinoProjekt
{
    public class Asztal
    {
        public double Kassza { get; private set; }
        public int Maxjatekos { get; private set; }
        public Dictionary<Jatekos, int[]> jatekosok = new Dictionary<Jatekos, int[]>();
        List<Dictionary<Jatekos, int[]>> korok = new List<Dictionary<Jatekos, int[]>>();
        Rulett rulett;
        Random r = new Random();


        public Asztal(int maxJatekos, IJatek jatek) {
            Maxjatekos = maxJatekos;
            rulett = (Rulett)jatek;
            Kassza = 1000;
        }

        public bool JatekosBehivasa(Jatekos jatekos) {
            if (Maxjatekos > jatekosok.Count+1)
            {
                jatekos.Asztalnal = true;
                jatekosok.Add(jatekos, new int[] { -3, 0 });
                return true;
            }
            return false;
        }

        void TetekBekerese(Jatekos jatekos, int szam, int tet)
        {
            jatekosok[jatekos][0] = szam;
            jatekosok[jatekos][1] = tet;
        }

        public void JatekMenete()
        {
            JatekosokTetMegadasa();
            (int szam, int szin) = rulett.KiporgetettErtek(); 
            Vegeredmeny(szam,szin);
            korok.Add(JatekosokCopy());
        }

        private void JatekosokTetMegadasa()
        {
            foreach (var item in jatekosok)
            {
                if (r.Next(2) == 0)
                {
                    (int tet, int szam) = TetekMegadasas(item);
                    item.Key.Jatekban = true;                    
                    TetekBekerese(item.Key, szam, tet);
                }
                else
                {
                    item.Key.Jatekban = true;
                    Console.WriteLine($"A {item.Key.Id} játékos ezt a kört kihagyja.");
                }
            }
        }

        private (int tet, int szam) TetekMegadasas( KeyValuePair<Jatekos, int[]> item)
        {
            int szam = Szam(item.Key.Id);
            int tet = Tet(item.Key.Egyenleg);   
            return (tet, szam);
        }

        int Szam(string id)
        {
            int szam;
            do
            {
                Console.Write($"id: {id} Adja meg a számot: ");
                szam = Convert.ToInt16(Console.ReadLine());
            } while (szam > 36 || szam < -2);
            return szam;
        }

        int Tet(double egyenleg)
        {
            int tet;
            do
            {
                Console.Write($"Adja meg a tétet: ");
                tet = Convert.ToInt16(Console.ReadLine());
            } while (tet > egyenleg || tet < 1);
            return tet;
        }

        void Vegeredmeny(int szam, int szin)
        {
            int osszeg = 0;
            foreach (var jatekos in jatekosok)
            {
                int tet = jatekos.Value[1];
                jatekos.Key.Egyenleg -= tet;
                Kassza += tet;

                if (jatekos.Value[0] == szam) osszeg = tet * 36;
                if (jatekos.Value[0] == szin) osszeg = tet * 2;

                jatekos.Key.Egyenleg += osszeg;
                Kassza -= osszeg;
                jatekos.Key.jatekok.Add((osszeg > 0? osszeg : -tet, osszeg>0));
            }
            korok.Add(JatekosokCopy());
            jatekosok.Clear();
        }

        private Dictionary<Jatekos, int[]> JatekosokCopy()
        {
            Dictionary<Jatekos, int[]> masolatok = new Dictionary<Jatekos, int[]>();

            foreach (var jatekos in jatekosok)
            {
                masolatok.Add(jatekos.Key.Copy(), new int[] { jatekos.Value[0], jatekos.Value[1] });
            }
            return masolatok;
        }

        public void AsztalElhagyasa(Jatekos jatekos)
        {
            jatekos.Asztalnal = false;
        }

        public List<Jatekos> NyertesJatekosokAddottKorben(int kor)
        {
            return korok[kor].Where(x => x.Key.jatekok.Any(c => c.Item2)).Select(x => x.Key).ToList();
        }

        public bool NyertEJatekos(Jatekos jatekos)
        {
            return jatekos.jatekok.Any(x => x.Item2);
        }

        public int JatekosProfit(Jatekos jatekos)
        {
            return jatekos.jatekok.Sum(x => x.Item1);
        }

        public bool VaneCsakNyertes()
        {
            return jatekosok.Any(x => x.Key.jatekok.All(c => c.Item2));
        }

        public bool JohetEJatekos()
        {
            return Maxjatekos > jatekosok.Count;
        }

    }
}
