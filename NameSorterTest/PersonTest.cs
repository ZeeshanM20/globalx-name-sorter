using NUnit.Framework;
using NameSorter;
using System;

namespace NameSorterTest
{
    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void Person_Get_Name_Test()
        {
            string firstName = "Janet";
            string lastName = "Parsons";

            Person person = new Person(firstName, lastName);

            Assert.AreEqual(firstName, person.getFirstName());
            Assert.AreEqual(lastName, person.getLastName());
        }

        [Test]
        public void Person_Incorrect_Number_Of_Names()
        {
            // Throws with no name
            Assert.Throws<ArgumentException>(() => { new Person(); });
            // Throws with only one name
            Assert.Throws<ArgumentException>(() => { new Person("Lauchie"); });
            // Throws with more than four names
            Assert.Throws<ArgumentException>(() => { new Person("Hunter", "Uriah", "Mathew", "Clarke", "Lauchie"); });
        }
    }
}
