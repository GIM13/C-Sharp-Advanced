using System;
using System.Collections.Generic;

namespace _03PeriodicTable
{
    class Program
    {
        static void Main()
        {
            int numInput = int.Parse(Console.ReadLine());
            var chemicalCompounds = new SortedSet<string>();

            for (int i = 0; i < numInput; i++)
            {
                string[] input = Console.ReadLine().Split();

                foreach (var element in input)
                {
                    chemicalCompounds.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ", chemicalCompounds));
        }
    }
}
