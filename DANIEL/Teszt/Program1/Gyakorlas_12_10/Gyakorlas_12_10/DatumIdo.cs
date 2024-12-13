using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas_12_10
{
    internal class DatumIdo
    {
        public int ev, honap, nap, óra, perc, masodperc;

        public DatumIdo(string sor)
        {
            char elvalszto = '1';

            for (int i = 0; i < sor.Length; i++)
            {
                if (!Char.IsLetterOrDigit(sor[i]))
                {
                    elvalszto = sor[i];
                    break;
                }
            }


            string[] tomb = sor.Split(' ');

            ev = Convert.ToInt32(tomb[0]);
            honap = Convert.ToInt32(tomb[1]);
            nap = Convert.ToInt32(tomb[2]);
            óra = 40;
        }

        public DatumIdo(int óra, int perc, int masodperc)
        {
            this.óra = óra;
            this.perc = perc;
            this.masodperc = masodperc;
        }

        public int DatumKulonbsegEv(string datum)
        {
            string[] tomb = datum.Split(' ');

            int nev = 0;
            int nhonap = 0;
            int nnap = 0;

            int kev = 0;
            int khonap = 0;
            int knap = 0;

            if (Convert.ToInt32(tomb[0]) > ev)
            {
                nev = Convert.ToInt32(tomb[0]);
                nhonap = Convert.ToInt32(tomb[1]);
                nnap = Convert.ToInt32(tomb[2]);

                kev = ev;
                khonap = honap;
                knap = nap;
            }
            else
            {
                kev = Convert.ToInt32(tomb[0]);
                khonap = Convert.ToInt32(tomb[1]);
                knap = Convert.ToInt32(tomb[2]);

                nev = ev;
                nhonap = honap;
                nnap = nap;
            }

            int kulonbseg = nev - kev;

            if (nhonap < khonap || (nhonap==khonap && nnap < knap))
            {
                kulonbseg--;
            }

            return kulonbseg;
        }

        public bool KorabbanvanE(int o, int p, int m)
        {
            if (óra < o || (óra == o && perc < p) || (óra == o && perc == p && masodperc < m))
            {
                return true;
            }

            return false;
        }
    }
}
