using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaszinoProjekt
{
    internal class Asztal
    {
        Dictionary<Jatekos, int[]> jatekosok = new Dictionary<Jatekos, int[]>();

        
        void JatekosBehivasa(Jatekos jatekos)
        {
            jatekosok.Add(jatekos, new int[] {0, -1});
        }

        void TetekBekerese(Jatekos jatekos, int szam, int tet)
        {
            jatekosok[jatekos][0] = szam;
            jatekosok[jatekos][1] = tet;
        }

        void JatekMenete()
        {
            Rulett rulett = new Rulett();
            JatekosBehivasa(new Jatekos());
            foreach (var item in jatekosok)
            {
                TetekBekerese(item.Key, 2, 10);
            }
            Vegeredmeny();

        }

        void Vegeredmeny()
        {

        }

    }
}
