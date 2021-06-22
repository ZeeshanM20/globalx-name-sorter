using System;

namespace NameSorter
{

    public class Person
    {
        private string[] names;

        public Person(params string[] names)
        {
            if (names.Length < 2 || names.Length > 4) {
                Console.WriteLine(names.Length);
                throw new ArgumentException("Name must contain between 2 and 4 names");
            }
            this.names = names;
        }

        public string getFirstName()
        {
            return string.Join(' ', names, 0, names.Length - 1);
        }

        public string getLastName()
        {
            return names[names.Length - 1];
        }
    }
}