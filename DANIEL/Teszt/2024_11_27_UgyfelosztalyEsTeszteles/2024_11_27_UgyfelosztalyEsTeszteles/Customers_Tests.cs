using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace _2024_11_27_UgyfelosztalyEsTeszteles
{
    [TestFixture]
    internal class Customers_Tests
    {
        List<Customer> customers;

        [SetUp]
        public void SetUp()
        {
            customers = new List<Customer>()
            {
                new Customer("Jane", "Smith", new DateTime(1985, 8, 22), "janesmith@example.com"),
                new Customer("Alice", "Johnson", new DateTime(1992, 11, 3), "alicejohnson@example.com"),
                new Customer("Bob", "Brown", new DateTime(1980, 2, 10), "bobbrown@example.com"),
                new Customer("Charlie", "Davis", new DateTime(1995, 7, 25), "charliedavis@example.com"),
                new Customer("Emily", "Miller", new DateTime(1988, 12, 12), "emilymiller@example.com")
            };
        }

        [TestCase(39, 0)]
        [TestCase(32, 1)]
        [TestCase(44, 2)]
        [TestCase(29, 3)]
        [TestCase(35, 4)]
        public void GetAge_ReturnsCorrectAges(int expectedAge, int index)
        {
            int age = customers[index].GetAge();
            ClassicAssert.AreEqual(expectedAge, age);
        }

        [Test]
        public void AllEmailsAreValidTest()
        {
            bool answer = customers.Any(c => c.IsEmailValid());
            ClassicAssert.IsTrue(answer);
        }

        [TestCaseSource (nameof(GetAdditionTestCases))]
        public void GetAges_ReturnsCorrectAges(int expectedAge, int index)
        {
            int age = customers[index].GetAge();
            ClassicAssert.AreEqual (expectedAge, age);
        }

        public static IEnumerable<TestCaseData> GetAdditionTestCases()
        {
            [TestCase(39, 0)]
            [TestCase(32, 1)]
            [TestCase(44, 2)]
            [TestCase(29, 3)]
            [TestCase(35, 4)]

            yield return new TestCaseData(39, 0);
            yield return new TestCaseData(32, 1);
            yield return new TestCaseData(44, 2);
            yield return new TestCaseData(29, 3);
            yield return new TestCaseData(35, 4);
        }

    }
}
