using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.IO;

namespace Formula_1_Projekt.Test
{
    [TestFixture]
    internal class Versenyzo__Test
    {
        private Versenyzo __versenyzo;



        [SetUp]
        public void Setup()
        {
            Adatkezeles.BeolvasasNagy("fajlok.txt");


            string Versenyzo_sor = "Lewis Hamilton; Mercedes; 39; 174";

            __versenyzo = new Versenyzo(Versenyzo_sor.Split(';'));
        }

        [Test]
        public void Test_Oregszik()
        {
            __versenyzo.Oregszik();


            ClassicAssert.AreEqual(__versenyzo.kor, 40);
        }

        [Test]
        public void Test_gyozelmekSzama()
        {
            int gyozelmek = __versenyzo.gyozelmekSzama(Adatkezeles.nagydijak);

            ClassicAssert.AreEqual(gyozelmek, 3);
        }

        [Test]
        public void Test_Atigazolas()
        {
            __versenyzo.Atigazolas(Adatkezeles.csapatok[0], Adatkezeles.csapatok[2]);

            ClassicAssert.AreEqual(__versenyzo.csapatnev , "Ferrari");
        }

        [TearDown]
        public void TearDown()
        {
            __versenyzo = null;
        }

    }
        
}
    

