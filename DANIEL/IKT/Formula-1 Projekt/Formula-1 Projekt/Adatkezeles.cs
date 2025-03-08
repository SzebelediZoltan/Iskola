using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Formula_1_Projekt
{
    public class Adatkezeles
    {
        public static List<Versenyzo> versenyzok = new List<Versenyzo>();
        public static List<Auto> autok = new List<Auto>();
        public static List<Csapat> csapatok = new List<Csapat>();
        public static List<Nagydij> nagydijak = new List<Nagydij>();

        public static List<Nagydij> szezon(List<Nagydij> nagydijak, int ev)
        {
            return nagydijak.Where(e => e.ev == ev).ToList();
        }

        public static List<int> evek(List<Nagydij> nagydijak)
        {
            return nagydijak.Select(e => e.ev).Distinct().ToList();
        }

        public static List<string> nagydijNevek(List<Nagydij> nagydijak, int ev)
        {
            return nagydijak.Where(f => f.ev == ev).Select(e => e.nev.Split(' ')[0]).Distinct().ToList();
        }

        public static List<Nagydij> palyaKivalasztas(List<Nagydij> nagydijak, string palyanev)
        {
            return nagydijak.Where(e => e.nev.Split(' ')[0] == palyanev).ToList();
        }

        public static List<Versenyzo> korKivalasztas(List<Versenyzo> versenyzok, int kor)
        {
            return versenyzok.Where(e => e.kor == kor).ToList();
        }

        public static void BeolvasasNagy(string path)
        {
            versenyzok.Clear();
            autok.Clear();
            csapatok.Clear();
            nagydijak.Clear();

            StreamReader fr = new StreamReader(path);

            BeolvasasKicsi(fr.ReadLine(), versenyzok);
            BeolvasasKicsi(fr.ReadLine(), autok);
            BeolvasasKicsi(fr.ReadLine(), csapatok);
            BeolvasasKicsi(fr.ReadLine(), nagydijak);

            fr.Close();
        }

        private static void BeolvasasKicsi<T>(string path, List<T> lista)
        {
            StreamReader file = new StreamReader(path);
            while (!file.EndOfStream)
            {
                object[] args = new object[] { file.ReadLine().Split(';') };
                T item = (T)Activator.CreateInstance(typeof(T), args);

                lista.Add(item);
            }
            file.Close();
        }

    }
}
