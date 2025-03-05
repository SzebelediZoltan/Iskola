using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula_1_Projekt
{
    public interface IVersenyzo
    {
        void Atigazolas(Csapat honnan, Csapat hova);
        void Oregszik();
        int gyozelmekSzama(List<Nagydij> nagydijak);

    }
}
