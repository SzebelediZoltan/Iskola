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
    internal class Auto__Test
    {
        private Auto __auto;

        [SetUp]
        public void SetUp()
        {
            string auto = "W14-01; 1,6; Mercedes; 1050; 365";
            __auto = new Auto(auto.Split(';'));
        }

        [TestCase(10, 1060, 368, true)]
        [TestCase(-10, 1050, 365, false)]
        public void Test_Autofejlesztes(int n, int le, int maxSebesseg, bool vegzett)
        {
            bool valasz = __auto.Autofejlesztes(n);

            ClassicAssert.AreEqual(__auto.le, le);
            ClassicAssert.AreEqual(__auto.maxSebesseg, maxSebesseg);
            ClassicAssert.AreEqual(vegzett, valasz);
        }

        [Test]
        public void Test_Javitas()
        {
            __auto.Javitas();

            ClassicAssert.IsTrue(__auto.javitasAlatt);
        }

        [TearDown]
        public void TearDown()
        {
            __auto = null;
        }

    }
}
