using System;
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

            sortedNames = Utils.readAndCreatePersonFromList(fileName);

            Assert.AreEqual(sortedNamesList, sortedNames.Values);
        }

        [Test]
        public void Util_Read_Call_With_Invalid_File_Name()
        {
            string fileName = "/FileNotThere";
            Assert.Throws<ArgumentException>(() => { Utils.readAndCreatePersonFromList(fileName); ; });

        }

        [Test]
        public void Util_Read_Call_With_Empty_File_Name()
        {
            string fileName = "";
            Assert.Throws<ArgumentException>(() => { Utils.readAndCreatePersonFromList(fileName); ; });

        }
    }
}
