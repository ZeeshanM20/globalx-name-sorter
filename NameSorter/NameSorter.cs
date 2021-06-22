using System;
using System.Collections.Generic;
using NameSorter;

namespace NameSorter
{
    public class NameSorter
    {
        public static void Main(string[] args)
        {
            SortedList<string, string> sortedNames;
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            Registry registry = new Registry();

            sortedNames = registry.readFileAndCreateSortedList(args[0]);
            registry.createAndWriteToFile(sortedNames);

        }
    }
}