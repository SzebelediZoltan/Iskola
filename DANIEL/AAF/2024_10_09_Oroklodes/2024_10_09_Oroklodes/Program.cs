using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_09_Oroklodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ososztaly o = new Ososztaly();
            Utodosztaly u = new Utodosztaly();

            o.x = 123;
            u.b = 543;

            Console.WriteLine(o.ToString());
            Console.WriteLine(u.ToString());

            Console.ReadLine();
        }

        class Ososztaly
        {
            public int x;

            public void TobbszorozX(int a)
            {
                x *= a;
            }

            public override string ToString()
            {
                return "x=" + x;
            }
        }

        class Utodosztaly : Ososztaly
        {
            public int b;
            
            public void TobbszorozB(int k)
            {
                b *= k;
            }

            public override string ToString()
            {
                return "b=" + b + "\t" + "x=" + x;
            }
        }
    }
}
