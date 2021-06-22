using System;

namespace NameSorter
{

    public class Person
    {
        private string[] names;

        public Person(params string[] names)
        {
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