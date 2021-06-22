using NUnit.Framework;
using NameSorter;

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
    }
}
