using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Gyakorlas_12_10
{
    [TestFixture]
    internal class DatumIdo_Test
    {
        DatumIdo datum = new DatumIdo(1, 2, 3); 
        DatumIdo ido = new DatumIdo(1, 2, 3); 

        [SetUp]
        public void SetUp()
        {
            datum = new DatumIdo("2024 12 10");
            ido = new DatumIdo(10, 20, 30);
        }

        [Test]
        public void DatumKulonbsegEv_Teszt1()
        {
            string a = "2022 12 10";
            int eredmeny = datum.DatumKulonbsegEv(a);

            ClassicAssert.AreEqual(2, eredmeny);
        }

        [Test]
        public void DatumKulonbsegEv_Teszt2()
        {
            string a = "2026 12 10";
            int eredmeny = datum.DatumKulonbsegEv(a);

            ClassicAssert.AreEqual(4, eredmeny);
        }

        [Test]
        public void KorabbanvanE_Teszt1()
        {
            int o = 9;
            int p = 10;
            int m = 50;

            bool eredmeny = ido.KorabbanvanE(o, p, m);

            ClassicAssert.AreEqual(false, eredmeny);
        }

        [Test]
        public void KorabbanvanE_Teszt2()
        {
            int o = 11;
            int p = 30;
            int m = 4;

            bool eredmeny = ido.KorabbanvanE(o, p, m);

            ClassicAssert.AreEqual(true, eredmeny);
        }

        [TearDown]
        public void TearDown()
        {
            datum = null;
            ido = null;
        }
    }
}
