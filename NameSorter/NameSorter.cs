using System;
using System.Collections.Generic;
using NameSorter;

namespace NameSorter
{
    public class NameSorter
    {
        public static void Main(string[] args)
        {
            string writeFileName = "sorted-names-list.txt";
            SortedList<string, string> sortedNames;

            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            sortedNames = Utils.readAndCreatePersonFromList(args[0]);
            Utils.createAndWriteToFile(sortedNames, writeFileName);

        }
    }
}