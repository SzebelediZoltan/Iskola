using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Formula_1_Projekt.Test
{
    [TestFixture]
    internal class Adatkezeles__Test
    {
        

        [SetUp]
        public void SetUp()
        {
            Adatkezeles.BeolvasasNagy("fajlok_test2.txt");
        }

        /// <summary>
        /// Adott teszt esetekkel ellenőrzi a beovasas helyes vagy hibás esteit
        /// </summary>
        /// <param name="path"></param>
        /// <param name="vegzett"></param>
        [TestCase("fajlok.txt", true)]
        [TestCase("asd", false)]
        [TestCase("fajlok_test.txt", false)]

        public void Test_BeolvasasNagy(string path, bool vegzett)
        {
            bool valasz = Adatkezeles.BeolvasasNagy(path);

            ClassicAssert.AreEqual(vegzett, valasz);
        }

        /// <summary>
        /// Ellenörzi hogy a függvény helyes futamokat ad-e vissza
        /// </summary>
        [Test]
        public void Test_szezon()
        {
            List<Nagydij> expected = Adatkezeles.szezon(Adatkezeles.nagydijak, 2023);


            ClassicAssert.IsTrue(expected.All(x => x.ev == 2023));
        }

        /// <summary>
        /// Teszteli a függvény helyes működését beégetett adatokkal
        /// </summary>
        [Test]
        public void Test_evek()
        {
            List<int> expected = Adatkezeles.evek(Adatkezeles.nagydijak);

            List<int> actual = new List<int>() { 2022 , 2023 , 2024 };

            Assert.That(actual, Is.EqualTo(expected));
        }

        /// <summary>
        /// Ellenörzi a függvény helyes működését beégetett 2023-as évvel
        /// </summary>
        [Test]
        public void Test_nagydijNevek()
        {
            int ev = 2023;

            List<string> expected = Adatkezeles.nagydijNevek(Adatkezeles.nagydijak, ev);

            List<string> actual = new List<string>() { "Bahreini" };

            Assert.That(actual, Is.EqualTo(expected));
        }

        /// <summary>
        /// Ellenőrzi hogy a függvény pontosan csak az Ausztrál nagydíjakat adja-e vissza
        /// </summary>
        [Test]
        public void Test_palyaKivalasztas()
        {
            string palyanev = "Ausztrál";

            List<Nagydij> expected = Adatkezeles.palyaKivalasztas(Adatkezeles.nagydijak, palyanev);

            ClassicAssert.IsTrue(expected.All(x => x.nev.Split(' ')[0] == "Ausztrál"));
        }
         
        /// <summary>
        /// Ellenörzi hogy a függvény csak a 39 éves versenyzőket adja-e vissza
        /// </summary>
        [Test]
        public void Test_korKivalasztas()
        {
            int kor = 39;

            List<Versenyzo> expected = Adatkezeles.korKivalasztas(Adatkezeles.versenyzok, kor);

            ClassicAssert.IsTrue(expected.All(x => x.kor == kor));
        }

        [TearDown]
        public void TearDown()
        {

        }

    }
    }

