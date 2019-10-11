using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            int countFamily = int.Parse(Console.ReadLine());

            var family = new Family(new List<Person>());

            for (int i = 0; i < countFamily; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                double age = double.Parse(input[1]);

                if (age >= 0 && name != string.Empty)
                {
                    family.AddMember(new Person(age, name));
                }
            }

            var oldestMember = family.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
