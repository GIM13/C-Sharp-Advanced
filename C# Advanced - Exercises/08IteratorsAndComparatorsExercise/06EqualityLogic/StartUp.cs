using System;
using System.Collections.Generic;

namespace _06EqualityLogic
{
    public class StartUp
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            var sortedSet = new SortedSet<Person>();
            var hashSet = new HashSet<Person>();

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                var person = new Person(name, age);

                sortedSet.Add(person);
                hashSet.Add(person);
            }

            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);
        }
    }
}
