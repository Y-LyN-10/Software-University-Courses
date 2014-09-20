using System;
using Persons;

namespace PersonTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void CreatingPersonWithValidDataShouldSetAllPropertiesCorrectly()
        {
            var person = new Person("Gosho", 30, "gosho@gmail.com");

            Assert.AreEqual("Gosho", person.Name, "Name is not set");
            Assert.AreEqual(30, person.Age, "Age is not set");
            Assert.AreEqual("gosho@gmail.com", person.Email, "Email is not set");
        }

        [TestMethod]
        public void CreatingPersonWithNoEmailShouldSetNameAndAgeCorrectly()
        {
            var person = new Person("Gosho", 30);

            Assert.AreEqual("Gosho", person.Name, "Name is not set");
            Assert.AreEqual(30, person.Age, "Age is not set");
        }

        [TestMethod]
        public void CreatingPersonWithNoEmailShouldEmailAsNull()
        {
            var person = new Person("Gosho", 30);

            Assert.IsNull(person.Email);
        }

        //TODO: exceptions - age [1..100], Name - null, empty or less than 2 letters
    }
}