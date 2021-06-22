using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace NameSorter
{

    public class Registry
    {
        SortedList<string, string> sortedNames;
        public SortedList<string, string> readFileAndCreateSortedList(string fileName)
        {
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            sortedNames = new SortedList<string, string>();
            _filePath += fileName;
            Console.WriteLine("Hello World" + _filePath);
            string[] names = System.IO
            .File.ReadAllLines(_filePath);

            foreach (String name in names)
            {
                createPerson(name, sortedNames);
            }
            return sortedNames;
        }

        private void createPerson(string name, SortedList<string, string> sortedNames)
        {
            string[] nameArray = name.Split(' ');
            Person person = new Person(string.Join(' ', nameArray, 0, nameArray.Length - 1), nameArray[nameArray.Length - 1]);
            sortedNames.Add(person.getLastName() + " " + person.getFirstName(), person.getFirstName() + " " + person.getLastName());
        }

        public async void createAndWriteToFile(SortedList<string, string> sortedNames)
        {
            File.WriteAllLines("sorted-names-list.txt", sortedNames.Select(x => x.Value).ToArray());
            using (StreamWriter file = new StreamWriter("sorted-names-list.txt"))
                foreach (var name in sortedNames)
                {
                    Console.WriteLine(name.Value);
                    await file.WriteLineAsync(name.Value);
                }
        }
    }
}