using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gepjarmu_Feladat
{
    internal class Orszagut
    {
        static public List<Jarmu> jarmuvek;
        
        public static void jarmuvekJonnek(string path)
        {
            StreamReader f = new StreamReader(path);

            while (!f.EndOfStream)
            {
                string[] st = f.ReadLine().Split(';');

                if (st[0] == "robogo")
                {
                    jarmuvek.Add(new Robogo(Convert.ToInt32(st[2]), st[1], Convert.ToInt32(st[3])));
                } else
                {
                    jarmuvek.Add(new AudiS8(Convert.ToInt32(st[2]), st[1], Convert.ToBoolean(st[3])));
                }
            }

            f.Close();
        }

        public static void kiketMertunkBe()
        {
            StreamWriter fr = new StreamWriter("buntetes.txt");

            for (int i = 0; i < jarmuvek.Count; i++)
            {
                if (jarmuvek.GetType() == typeof(AudiS8))
                {
                    AudiS8 p = (AudiS8)jarmuvek[i];
                    fr.WriteLine($"{p.ToString()} + {(p.gyorshajtottE(90) ? "Gyorshajtott" : "Nem hajtott gyorsan")}");
                } else
                {
                    Robogo p = (Robogo)jarmuvek[i];
                    fr.WriteLine($"{p.ToString()} + {(p.haladhatItt(90) ? "Gyorshajtott" : "Nem hajtott gyorsan")}");
                }
            }

            fr.Close();
        }

    }
}
