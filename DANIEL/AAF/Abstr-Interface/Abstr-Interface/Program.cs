using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Abstr_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {



        }
    }

    abstract class A
    {
        public int x;
        public string sz;

        public A(string sz, int x)
        {
            this.sz = sz;
            this.x = x;
        }

        public string Ismetel()
        {
            string er = "";
            for (int i = 0; i < x; i++)
            {
                er += sz;
            }
            return er;
        }
        public abstract void Szamol();
    }

    class B : A
    {
        public B() : base("alma", 5)
        {
            
        }
        public override void Szamol()
        {
            x = x * 10;
        }
    }
}
