using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_27_UgyfelosztalyEsTeszteles
{
    internal class Customer_MoreTests
    {
        List<Customer> customers;
        [SetUp]
        public void Setup() {
            customers = new List<Customer>() {
                new Customer("John", "Doe", new DateTime(1990, 5, 15), "john.doe@example.com"),
                new Customer("Jane", "Smith", new DateTime(1985, 8, 22), "jane.smith@example.com"),
                new Customer("Alice", "Johnson", new DateTime(1992, 11, 3), "alice.johnson@example.com"),
                new Customer("Bob", "Brown", new DateTime(1980, 2, 10), "bob.brown@example.com"),
                new Customer("Charlie", "Davis", new DateTime(1995, 7, 25), "charlie.davis@example.com"),
                new Customer("Emily", "Miller", new DateTime(1988, 12, 12), "emily.miller@example.com")
            };
        }

        [TestCase (34, 0)]
        [TestCase (39, 1)]
        [TestCase (32, 2)]
        [TestCase (44, 3)]
        [TestCase (29, 4)]
        [TestCase (35, 5)]
        public void GetAge_ReturnsCorrectAges(int expectedAge, int index)
        {
            int age = customers[index].GetAge();
            ClassicAssert.AreEqual(expectedAge, age);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void IsEmailValid_ValidEmails_ReturnsTrue( int index)
        {
            ClassicAssert.IsTrue(customers[index].IsEmailValid());
        }

        [Test]
        public void IsEmailValid_ValidEmails_ReturnsTrue2()
        {
            ClassicAssert.IsTrue(!customers.Select(x=>x.IsEmailValid()).Contains(false));
        }

        [TestCase()]
        public void IsEmailValid_InvalidEmail_ReturnsFalse()
        {
            _customer.Email = "invalid-email";
            var isValid = _customer.IsEmailValid();
            ClassicAssert.IsFalse(isValid);  // Ellenőrizzük, hogy érvénytelen email esetén false-t ad vissza
        }

    }
}
