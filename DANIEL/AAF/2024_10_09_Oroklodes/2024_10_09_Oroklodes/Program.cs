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
            Ososztaly o = new Ososztaly(10,20);
            Utodosztaly u = new Utodosztaly(12, 22, 32);

            Console.WriteLine(o.ToString());
            Console.WriteLine(u.ToString());

            Console.ReadLine();
        }

        class Ososztaly
        {
            public int x;
            protected int y;

            public Ososztaly(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public void TobbszorozX(int a)
            {
                x *= a;
            }

            public override string ToString()
            {
                return "x=" + x + "\ty=" + y;
            }
        }

        class Utodosztaly : Ososztaly
        {
            public int b;
            
            public Utodosztaly(int x, int y, int b) : base(x, y)
            {
                this.b = b;
            }

            public void TobbszorozB(int k)
            {
                b *= k;
            }

            public override string ToString()
            {
                return "x=" + x + "\ty=" + y + "\tb=" + b;
            }
        }
    }
}
