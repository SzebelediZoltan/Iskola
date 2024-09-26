using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoStruct astruct = new AutoStruct(1600);
            AutoClass aclass = new AutoClass(1500);

            Console.WriteLine(astruct.hut);
            Console.WriteLine(aclass.hut);

            ValtoztatStruct(astruct);
            ValtoztatClass(aclass);

            Console.WriteLine(astruct.hut);
            Console.WriteLine(aclass.hut);

            Console.ReadLine();
        }

        static void ValtoztatStruct(AutoStruct astruct)
        {
            astruct.hut = 0;
        }

        static void ValtoztatClass(AutoClass aclass)
        {
            aclass.hut = 0;
        }

        struct AutoStruct
        {
            public int hut;

            public AutoStruct(int hut)
            {
                this.hut = hut;
            }
        }

        class AutoClass
        {
            public int hut;

            public AutoClass(int hut)
            {
                this.hut = hut;
            }
        }
    }
}
