using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula_1_Projekt.Test
{
    [TestFixture]
    internal class Nagydij__Test
    {
        private Nagydij __Nagydij;

        [SetUp]
        public void SetUp()
        {
            Adatkezeles.BeolvasasNagy("fajlok.txt");

            string nagydij = "2022;Bahreini Nagydíj;Lewis Hamilton;Mercedes;335;210;1;Igen;1:32:15";


            __Nagydij = new Nagydij(nagydij.Split(';'));
        }

        [TestCase("1:-40:15", "1:32:15", false)]
        [TestCase("1:20:15", "1:20:15", true)]
        public void Test_idoKorrekcio(string ido, TimeSpan vart, bool vegzett)
        {
            string[] idoSor = ido.Split(':');
            TimeSpan time = new TimeSpan(Convert.ToInt32(idoSor[0]), Convert.ToInt32(idoSor[1]), Convert.ToInt32(idoSor[2]));

            bool valasz = __Nagydij.idoKorrekcio(ido);

            ClassicAssert.AreEqual(vart, __Nagydij.ido);
            ClassicAssert.AreEqual(vegzett, valasz);
        }

        [Test]
        public void Test_DNF()
        {
            __Nagydij.DNF();

            ClassicAssert.IsFalse(__Nagydij.befejezteE);
        }

        [TearDown]
        public void TearDown() 
        {
            __Nagydij = null;
        }
    }
}
