using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace _2024_11_27_UgyfelosztalyEsTeszteles
{
    [TestFixture]
    internal class Cutomer_tests
    {
        Customer customer;
        [SetUp]
        public void SetUp() {
            customer = new Customer("John", "Doe", new DateTime(1990,05,15), "JohnDoe@htx.du");
        }
        [Test]
        public void GetAge_ReturnsCorrectAge()
        {
            int expectedAge = 34;
            int age = customer.GetAge();
            ClassicAssert.AreEqual(expectedAge, age);
        }

        [Test]
        public void IsEmailValid_ValidEmail_ReturnsTrue()
        {
            bool isValid = customer.IsEmailValid();
            //ClassicAssert.AreEqual(true, isValid);
            ClassicAssert.IsTrue(isValid);
        }

        [Test]
        public void IsEmailValid_InvalidEmail_ReturnsFalse()
        {
            customer.email = "KisPista.hu";
            //ClassicAssert.AreEqual(false, customer.IsEmailValid());
            ClassicAssert.IsFalse(customer.IsEmailValid());
        }

        [Test]
        public void GetFullName_ReturnsCorrectFullName()
        {
            string expectedName = "Doe John";
            ClassicAssert.AreEqual(expectedName, customer.GetFullName());
        }

        [Test]
        public void Customer_Constructor_SetsPropertiesCorrectly()
        {
            customer = new Customer("Jane", "Smith", new DateTime(1985, 12, 20), "jane.smith@example.com");
            ClassicAssert.AreEqual("Jane", customer.firstName);
            ClassicAssert.AreEqual("Smith", customer.lastName);
            ClassicAssert.AreEqual(new DateTime(1985,12,20), customer.birthDate);
            ClassicAssert.AreEqual("jane.smith@example.com", customer.email);
        }

        [TearDown]
        public void TearDown()
        {
            customer = null;
        }
    }
}
