using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaszinoProjekt
{
    public interface IJatekos
    {
        double Egyenleg { get; set; }
        string Id { get; set; }
        bool Jatekban { get; set; }
    }
}
