using System;
using System.Collections.Generic;
using System.Linq;
using DefiningClasses;

namespace _04OpinionPoll
{
    public class StartUp
    {
        public static void Main()
        {
            int numInfo = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            for (int i = 0; i < numInfo; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                double age = double.Parse(input[1]);

                if (age > 30)
                {
                    people.Add(new Person(age, name));
                }
            }

            people = people.OrderBy(x => x.Name).ToList();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
