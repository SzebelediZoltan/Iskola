using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Oroklodes
{
    internal class Pekseg
    {

        public static List<IArlap> termekek = new List<IArlap>();


        public static void Vasarlok(string path)
        {
            StreamReader f = new StreamReader(path);

            while (!f.EndOfStream)
            {
                string[] st = f.ReadLine().Split(' ');
                if (st.Length == 3)
                {
                    termekek.Add(new Pogacsa(Convert.ToDouble(st[1]), Convert.ToDouble(st[2])));
                } else
                {
                    termekek.Add(new Kave(st[1] == "habos"));
                }
            }
        }
    }
}
