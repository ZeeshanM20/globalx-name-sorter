using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace NameSorter
{

    public class Registry
    {
        SortedList<string, string> sortedNames;

        // Reads names from file, creates Person objects for the names and adds them to a SortedList.
        public SortedList<string, string> readFileAndCreateSortedList(string fileName)
        {
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            sortedNames = new SortedList<string, string>();
            _filePath += fileName;
            string[] names = System.IO
            .File.ReadAllLines(_filePath);

            foreach (String name in names)
            {
                string[] nameArray = name.Split(' ');
                Person person = new Person(nameArray);
                sortedNames.Add($"{person.getLastName()} {person.getFirstName()}", $"{person.getFirstName()} {person.getLastName()}");
            }
            return sortedNames;
        }

        // Writes to file "sorted-names-list.txt" from sortedNames list or creates it if not present.
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