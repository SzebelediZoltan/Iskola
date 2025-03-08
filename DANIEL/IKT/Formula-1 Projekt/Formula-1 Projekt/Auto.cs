﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula_1_Projekt
{
    public class Auto : IAuto
    {
        public string nev, motor, csapatnev;
        public int le, maxSebesseg;
        public bool javitasAlatt;

        public string Nev { get { return nev; } }
        public string Henger_Urtartalom { get { return motor; } }
        public string Csapat { get { return csapatnev.Trim(); } }
        public int Lo_Ero { get { return le; } }
        public int Max_Sebesseg { get { return maxSebesseg; } }
        public bool Javits_Alatt { get { return javitasAlatt; } }

        public Auto(string[] sor)
        {
            nev = sor[0];
            motor = sor[1];
            csapatnev = sor[2];
            le = Convert.ToInt32(sor[3]);
            maxSebesseg = Convert.ToInt32(sor[4]);
            javitasAlatt = false;
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
