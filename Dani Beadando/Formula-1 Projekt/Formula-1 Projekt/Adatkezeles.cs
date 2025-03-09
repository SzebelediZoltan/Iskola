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
        public static List<Versenyzo> versenyzok;
        public static List<Auto> autok;
        public static List<Csapat> csapatok;
        public static List<Nagydij> nagydijak;

        /// <summary>
        /// Visszaadja az adott évbe tartozó futamok végeredményét
        /// </summary>
        /// <param name="nagydijak"></param>
        /// <param name="ev"></param>
        /// <returns></returns>
        public static List<Nagydij> szezon(List<Nagydij> nagydijak, int ev)
        {
            return nagydijak.Where(e => e.ev == ev).ToList();
        }

        /// <summary>
        /// Visszaadja az adatbázisban lévő éveket
        /// </summary>
        /// <param name="nagydijak"></param>
        /// <returns></returns>
        public static List<int> evek(List<Nagydij> nagydijak)
        {
            return nagydijak.Select(e => e.ev).Distinct().ToList();
        }

        /// <summary>
        /// Visszaadja a nagydíjak nevét az adott évben
        /// </summary>
        /// <param name="nagydijak"></param>
        /// <param name="ev"></param>
        /// <returns></returns>
        public static List<string> nagydijNevek(List<Nagydij> nagydijak, int ev)
        {
            return nagydijak.Where(f => f.ev == ev).Select(e => e.nev.Split(' ')[0]).Distinct().ToList();
        }

        /// <summary>
        /// Visszaadja az adott pályanévvel rendelkező futamokat
        /// </summary>
        /// <param name="nagydijak"></param>
        /// <param name="palyanev"></param>
        /// <returns></returns>
        public static List<Nagydij> palyaKivalasztas(List<Nagydij> nagydijak, string palyanev)
        {
            return nagydijak.Where(e => e.nev.Split(' ')[0] == palyanev).ToList();
        }

        /// <summary>
        /// Egy versenyzőkből álló listát szűr adott kor szerint
        /// </summary>
        /// <param name="versenyzok"></param>
        /// <param name="kor"></param>
        /// <returns></returns>
        public static List<Versenyzo> korKivalasztas(List<Versenyzo> versenyzok, int kor)
        {
            return versenyzok.Where(e => e.kor == kor).ToList();
        }

        /// <summary>
        /// Beolvasas :)
        /// </summary>
        /// <param name="path"></param>
        public static bool BeolvasasNagy(string path)
        {
            try
            {
                versenyzok = new List<Versenyzo>();
                autok = new List<Auto>();
                csapatok = new List<Csapat>();
                nagydijak = new List<Nagydij>();


                StreamReader fr = new StreamReader(path);

                BeolvasasKicsi(fr.ReadLine(), versenyzok);
                BeolvasasKicsi(fr.ReadLine(), autok);
                BeolvasasKicsi(fr.ReadLine(), csapatok);
                BeolvasasKicsi(fr.ReadLine(), nagydijak);

                fr.Close();

                return true;
            } catch {
                return false;
            }
        }

        private static void BeolvasasKicsi<T>(string path, List<T> lista)
        {

            try
            {
                StreamReader file = new StreamReader(path);
                while (!file.EndOfStream)
                {
                    object[] args = new object[] { file.ReadLine().Split(';') };
                    T item = (T)Activator.CreateInstance(typeof(T), args);

                    lista.Add(item);
                }
                file.Close();
            } catch 
            {
                throw new Exception();
            }
        }

    }
}
