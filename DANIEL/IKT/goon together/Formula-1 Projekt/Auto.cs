using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula_1_Projekt
{
    internal class Auto : IAuto
    {
        public string nev, motor;
        public int le, maxSebesseg;
        public bool javitasAlatt;

        public Auto(string nev, string motor, int le, int maxSebesseg, bool javitasAlatt)
        {
            this.nev = nev;
            this.motor = motor;
            this.le = le;
            this.maxSebesseg = maxSebesseg;
            this.javitasAlatt = javitasAlatt;
        }

        public void Autofejlesztes(int le)
        {
            this.le += le;
            maxSebesseg += le / 3;
        }

        public void Javitas()
        {
            javitasAlatt = !javitasAlatt;
        }
    }
}
