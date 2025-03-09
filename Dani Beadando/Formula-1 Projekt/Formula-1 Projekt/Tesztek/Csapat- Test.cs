using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula_1_Projekt.Test
{
    [TestFixture]
    internal class Csapat__Test
    {
        private Csapat __csapat;

        [SetUp]
        public void SetUp()
        {
            Adatkezeles.BeolvasasNagy("fajlok.txt");

            string[] csapat = new string[] { "Mercedes" };

            __csapat = new Csapat(csapat);
        }

        [Test]
        public void Test_Nevvaltas()
        {
            __csapat.Nevvaltas("kicsike");


            ClassicAssert.AreEqual(__csapat.nev, "kicsike");
            ClassicAssert.AreEqual(__csapat.versenyzok[0].csapatnev, "kicsike");
            ClassicAssert.AreEqual(__csapat.versenyzok[1].csapatnev, "kicsike");

        }

        [TestCaseSource(nameof(getTestCases))]
        public void Test_Gyozelmek(List<Nagydij> nagydijak)
        {
            int gyozelmek = __csapat.GyozelmekSzama(nagydijak);

            ClassicAssert.AreEqual(gyozelmek, 3);
        }

        public static IEnumerable<List<Nagydij>> getTestCases()
        {
            Adatkezeles.BeolvasasNagy("fajlok.txt");
            yield return Adatkezeles.nagydijak;
        }

        [TearDown]
        public void TearDown()
        {
            __csapat = null;
        }
        
            
    }
}
