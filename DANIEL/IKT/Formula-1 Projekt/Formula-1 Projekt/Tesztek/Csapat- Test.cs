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

        /// <summary>
        /// Ellenörzi hogy a függvény helyesen váltja-e át a csapat és hozzá tartozó versenyzők csapat neveit
        /// </summary>
        [TestCase("kicsike", "kicsike" , true)]
        [TestCase("", "Mercedes", false)]
        public void Test_Nevvaltas(string nev, string vart, bool vegzette)
        {
            bool valasz = __csapat.Nevvaltas(nev);


            ClassicAssert.AreEqual(__csapat.nev, vart);
            ClassicAssert.AreEqual(__csapat.versenyzok[0].csapatnev, vart);
            ClassicAssert.AreEqual(__csapat.versenyzok[1].csapatnev, vart);
            ClassicAssert.AreEqual(vegzette, valasz);

        }

        /// <summary>
        /// Ellenörzi hogy a csapatnak helyesen adja-e vissza a győzelmeinek számát
        /// </summary>
        /// <param name="nagydijak"></param>
        [TestCaseSource(nameof(getTestCases))]
        public void Test_Gyozelmek(List<Nagydij> nagydijak)
        {
            int gyozelmek = __csapat.GyozelmekSzama(nagydijak);

            ClassicAssert.AreEqual(gyozelmek, 3);
        }

        /// <summary>
        /// Visszaadja a teszteléshez szükséges listát
        /// </summary>
        /// <returns></returns>
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
