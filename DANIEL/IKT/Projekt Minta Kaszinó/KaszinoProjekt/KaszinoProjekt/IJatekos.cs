using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaszinoProjekt
{
    internal interface IJatekos
    {
        double Egyenleg { get; set; }
        int Id { get; set; }
        bool Jatekban { get; set; }
    }
}
