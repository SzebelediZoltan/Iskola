using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace _2024_10_22_TesztelésiAlapok
{
    internal class Aosztaly_Teszteles
    {

        [TestFixture]
        class AosztalyTeszt
        {
            [Test]
            public void Metodus1Teszt_a34()
            {
                //Arrange
                int a = 34;

                //Act
                Aosztaly a1 = new Aosztaly();
                double eredmeny = a1.Metodus1(a);

                //Assert
                Assert.Equals(10, eredmeny);
            }
        }

    }
}
