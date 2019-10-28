using System;
using System.Collections.Generic;

namespace _05Comparing_Objects
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var people = new List<Person>(); 

            while (input != "END")
            {
                var info = input.Split();

                var name = info[0];
                var age = int.Parse(info[1]);
                var town = info[2];

                var person = new Person(name, age, town);

                people.Add(person);

                input = Console.ReadLine();
            }

            int num = int.Parse(Console.ReadLine());

            int matches = 0;

            foreach (var item in people)
            {
                if (people[num - 1].CompareTo(item) == 0)
                {
                    matches++;
                }
            }

            if (matches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matches} {people.Count - matches} {people.Count}");
            }
        }
    }
}
