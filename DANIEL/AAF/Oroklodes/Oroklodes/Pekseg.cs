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

        static List<IArlap> termekek = new List<IArlap>();


        public static void Vasarlok(string path)
        {
            StreamReader f = new StreamReader(path);

            while (!f.EndOfStream)
            {
                string[] st = f.ReadLine().Split(' ');
                if (st.Length == 2)
                {
                    
                }
                termekek.Add();
            }
        }
    }
}
