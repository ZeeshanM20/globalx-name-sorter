using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace NameSorter
{

    public class Utils
    {

        // Reads names from file, creates Person objects for the names and adds them to a SortedList.
        public static SortedList<string, string> readAndCreatePersonFromList(string fileName)
        {
            if(String.IsNullOrEmpty(fileName)) {
                throw new ArgumentException("File name is empty");
            }
            string[] names;
            SortedList<string, string> sortedNames;
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            _filePath += fileName;
            sortedNames = new SortedList<string, string>();
            try
            {
                names = System.IO.File.ReadAllLines(_filePath);
            } catch (IOException)
            {
                throw new ArgumentException("File to read, does not exist");
            }

            foreach (String name in names)
            {
                string[] nameArray = name.Split(' ');
                Person person = new Person(nameArray);
                sortedNames.Add($"{person.getLastName()} {person.getFirstName()}", $"{person.getFirstName()} {person.getLastName()}");
            }
            return sortedNames;
        }

        // Writes to file "sorted-names-list.txt" from sortedNames list or creates it if not present.
        public static async void createAndWriteToFile(SortedList<string, string> sortedNames, string writeFileName)
        {
            using (StreamWriter file = new StreamWriter(writeFileName))
                foreach (var name in sortedNames)
                {
                    Console.WriteLine(name.Value);
                    await file.WriteLineAsync(name.Value);
                }
        }
    }
}