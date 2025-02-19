using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula_1_Projekt
{
    internal class Adatkezeles
    {
        public static List<Nagydij> szezon(List<Nagydij> nagydijak, int ev)
        {
            return nagydijak.Where(e => e.ev == ev).ToList();
        }

        public static List<int> evek(List<Nagydij> nagydijak)
        {
            return nagydijak.Select(e => e.ev).Distinct().ToList();
        }

        public static List<string> nagydijNevek(List<Nagydij> nagydijak)
        {
            return nagydijak.Select(e => e.nev.Split(' ')[0]).Distinct().ToList();
        }

        public static List<Nagydij> palyaKivalasztas(List<Nagydij> nagydijak, string palyanev)
        {
            return nagydijak.Where(e => e.nev.Split(' ')[0] == palyanev).ToList();
        }

    }
}
