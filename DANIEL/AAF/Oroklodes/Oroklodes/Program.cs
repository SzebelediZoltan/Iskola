﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pekseg.Vasarlok("adatok.txt");
            List<IArlap> t = Pekseg.termekek;
        }
    }
}
