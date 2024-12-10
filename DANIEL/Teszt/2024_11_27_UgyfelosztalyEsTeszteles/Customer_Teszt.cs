using System;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace _2024_11_27_UgyfelosztalyEsTeszteles
{
    [TestFixture]
    public class Customer_Teszt
    {
        private Customer _customer;

        [SetUp]
        public void Setup()
        {
            // Létrehozzuk az ügyfelet, például egy 1990-es születési dátummal
            _customer = new Customer("John", "Doe", new DateTime(1990, 5, 15), "john.doe@example.com");
        }

        [Test]
        public void GetAge_ReturnsCorrectAge()
        {
            // A mai dátum (például: 2024. november 18.)
            int expectedAge = 34; // 2024-ből kivonva 1990-et, életkor 34 lesz
            var age = _customer.GetAge();
            ClassicAssert.AreEqual(expectedAge, age);
        }

        [Test]
        public void IsEmailValid_ValidEmail_ReturnsTrue()
        {
            var isValid = _customer.IsEmailValid();
            ClassicAssert.IsTrue(isValid);  // Ellenőrizzük, hogy az email érvényes
        }

        [Test]
        public void IsEmailValid_InvalidEmail_ReturnsFalse()
        {
            _customer.Email = "invalid-email";
            var isValid = _customer.IsEmailValid();
            ClassicAssert.IsFalse(isValid);  // Ellenőrizzük, hogy érvénytelen email esetén false-t ad vissza
        }

        [Test]
        public void GetFullName_ReturnsCorrectFullName()
        {
            var fullName = _customer.GetFullName();
            ClassicAssert.AreEqual("John Doe", fullName);  // Ellenőrizzük, hogy a teljes név helyes
        }

        [Test]
        public void Customer_Constructor_SetsPropertiesCorrectly()
        {
            var customer = new Customer("Jane", "Smith", new DateTime(1985, 12, 20), "jane.smith@example.com");

            ClassicAssert.AreEqual("Jane", customer.FirstName);
            ClassicAssert.AreEqual("Smith", customer.LastName);
            ClassicAssert.AreEqual(new DateTime(1985, 12, 20), customer.BirthDate);
            ClassicAssert.AreEqual("jane.smith@example.com", customer.Email);
        }

     
    }
}