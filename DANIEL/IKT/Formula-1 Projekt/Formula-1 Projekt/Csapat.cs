﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula_1_Projekt
{
    public class Csapat
    {
        public string nev;
        public List<Auto> autok;
        public List<Versenyzo> versenyzok;

        public string Nev { get { return nev; } }
        public string Auto_1 { get { return autok[0].nev; } }
        public string Auto_2 { get { return autok[1].nev; } }
        public string Pilota_1 { get { return versenyzok[0].nev; } }
        public string Pilota_2 { get { return versenyzok[1].nev; } }
        public int Gyozelmek { get { return GyozelmekSzama(Adatkezeles.nagydijak); } }

        public Csapat(string[] sor)
        {
            nev = sor[0];
            autok = Adatkezeles.autok.Where(x => x.csapatnev.Trim() == nev).ToList();
            versenyzok = Adatkezeles.versenyzok.Where(x => x.csapatnev == nev).ToList();
        }

        /// <summary>
        /// Megváltoztatja a csapat nevét mindenhol az adatbázisban
        /// </summary>
        /// <param name="nev"></param>
        public bool Nevvaltas(string nev)
        {
            if(nev.Length == 0)
            {
                return false;
            }
            versenyzok[0].csapatnev = nev;
            versenyzok[1].csapatnev = nev;
            this.nev = nev;
            return true;
        }

        /// <summary>
        /// Visszaadja a csapat általi győzelmeket
        /// </summary>
        /// <param name="nagydijak"></param>
        /// <returns></returns>
        public int GyozelmekSzama(List<Nagydij> nagydijak)
        {
            return nagydijak.Where(e => e.versenyzo.csapatnev == nev && e.helyezes == 1).Count();
        }
    }
}
