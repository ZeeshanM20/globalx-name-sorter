using NUnit.Framework;
using NameSorter;
using System.Collections.Generic;

namespace NameSorterTest
{
    [TestFixture]
    public class RegistryTests
    {
        [Test]
        public void Person_Get_Name_Test()
        {
            SortedList<string, string> sortedNames;
            string fileName = "/unsorted-names-test-list.txt";

            List<string> sortedNamesList = new()
            {
                "Adonis Julius Archer",
                "London Lindsey",
                "Jaanet Parsons",
                "Janet Parsons"
            };

            Registry registry = new Registry();

            sortedNames = registry.readFileAndCreateSortedList(fileName);

            Assert.AreEqual(sortedNamesList, sortedNames.Values);
        }
    }
}
