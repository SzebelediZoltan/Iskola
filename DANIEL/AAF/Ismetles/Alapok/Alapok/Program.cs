using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Alapok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Feladat1();

            Console.ReadLine();
        }

        static void Feladat1()
        {
            List<string> hex = new List<string>();
            List<List<int>> rgb = new List<List<int>>();

            f1_generalas(hex);
            f1_atvaltas(hex, rgb);
            f1_kiiratas(hex, rgb);
        }

        static void f1_kiiratas(List<string> hex, List<List<int>> rgb)
        {
            for (int i = 0; i < 20; i++)
            {

            }
        }

        static void f1_atvaltas(List<string> hex, List<List<int>> rgb)
        {
            for (int i = 0; i < hex.Count; i++)
            {
                rgb.Add(new List<int>());
                for (int j = 1; j < 6; j += 2)
                {
                    string hex_akt = "" + hex[i][j - 1] + hex[i][j];
                    rgb[i].Add(rgb_alakitas(hex_akt));
                }
            }

        }

        static int rgb_alakitas(string hex_akt)
        {
            double rgb_akt = 0;

            for (int i = 1; i < 3; i++)
            {
                if (Char.IsDigit(hex_akt[i - 1]))
                {
                    rgb_akt += Convert.ToInt32(hex_akt[i-1] - 48) * Math.Pow(16, i % 2);
                } else
                {
                    rgb_akt += (Convert.ToInt32(hex_akt[i-1]) - 55) * Math.Pow(16, i % 2);
                }
            }

            return Convert.ToInt32(rgb_akt);
        }

        static void f1_generalas(List<string> hex)
        {
            Random r = new Random(); 
            for (int i = 0; i < 20; i++)
            {
                string str = "";
                for (int j = 0; j < 6; j++)
                {
                    if(r.Next(1,3) == 1)
                    {
                        str += Convert.ToString(r.Next(0, 10));
                    } else
                    {
                        str += Convert.ToChar(r.Next(65, 71));
                    }
                }

                hex.Add(str);
            }
        }
    }
}
