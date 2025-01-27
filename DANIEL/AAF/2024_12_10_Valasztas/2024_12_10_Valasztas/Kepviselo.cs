using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_10_Valasztas
{
    internal class Kepviselo
    {
        public int sorszam, szavazat;
        public string veznev, kernev, part;

        public static List<Kepviselo> kepviselok = new List<Kepviselo>();


        public Kepviselo(string sor) {
            string[] st = sor.Split(' ');
            sorszam = Convert.ToInt32(st[0]);
            szavazat = Convert.ToInt32(st[1]);
            veznev = st[2];
            kernev = st[3];
            part = st[4];
            // part == "-" ? "Független" : st[4]
        }

        public static void Fajlbeolvasas(string path)
        {
            try
            {
                StreamReader f = new StreamReader(path);

                while (!f.EndOfStream)
                {
                    kepviselok.Add(new Kepviselo(f.ReadLine()));
                }

                f.Close();
            }
            catch(FileNotFoundException ex){
                Console.WriteLine("Rossz útvonalon van a fájl vagy rossz néven hivatkoznak rá!");
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Hiba a fájl beolvasása során!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
