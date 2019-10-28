using System;

namespace _05Comparing_Objects
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public string  Name { get; set; }

        public int  Age { get; set; }

        public string  Town { get; set; }

        public int CompareTo(Person other)
        {
            if (Name != other.Name)
            {
                return 1;
            }

            if (Age != other.Age)
            {
                return 1;
            }

            if (Town != other.Town)
            {
                return 1;
            }

            return 0;
        }
    }
}
