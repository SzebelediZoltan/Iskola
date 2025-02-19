using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaszinoProjekt
{
    public class Jatekos : IJatekos
    {
        public double Egyenleg { get; set; }
        public string Id { get; set; }
        public bool Jatekban { get; set; }
        public bool Asztalnal { get; set; }
        public List<(int,bool)> jatekok = new List<(int,bool)> ();
        private Random rnd = new Random();


        public Jatekos()
        {
            Id = ""+ rnd.Next();
            Egyenleg = 100;
        }

        public Jatekos(double egyenleg, string id, bool asztalnal = false)
        {
            Egyenleg = egyenleg;
            Id = id;
            Asztalnal = asztalnal;
        }

        public void Befizetes(double ertek)
        {
            Egyenleg += ertek;
        }

        public Jatekos Copy() {
            return new Jatekos(Egyenleg, Id, Jatekban);
        }

        public override string ToString()
        {
            return $"id: {Id} Egyenleg: {Egyenleg} Játékban vane: {Jatekban}";
        }

    }
}
