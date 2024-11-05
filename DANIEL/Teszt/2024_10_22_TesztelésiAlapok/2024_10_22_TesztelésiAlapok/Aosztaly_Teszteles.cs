using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using NUnit.Framework.Legacy;

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
                Aosztaly a1 = new Aosztaly();

                //Act
                double eredmeny = a1.Metodus1(a);

                //Assert
                ClassicAssert.AreEqual(eredmeny, eredmeny);
            }

            [Test]
            public void OsztasTeszt_a12b6()
            {
                //Arrange
                int a = 12;
                int b = 6;
                Aosztaly a1 = new Aosztaly();

                //Act
                int eredmeny = a1.Osztas(a, b);

                //Assert
                ClassicAssert.AreEqual(2, eredmeny);
            }

            [Test]
            public void Hatvanyozas([Values(2, 3, 10)] int a, [Values(0, 10, 12)] int b)
            {
                Aosztaly a1 = new Aosztaly();

                //Act
                double eredmeny = a1.Hatvanyozas(a, b);

                //Assert
                try
                {
                    ClassicAssert.AreEqual(Math.Pow(a, b), eredmeny);
                }
                catch (Exception e)
                {
                    StringAssert.Contains(e.Message, "az algoritmusban hiba van!");
                }
            }
        }

    }
}
