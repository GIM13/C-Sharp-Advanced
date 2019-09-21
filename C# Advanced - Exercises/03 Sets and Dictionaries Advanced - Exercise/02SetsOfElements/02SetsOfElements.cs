using System;
using System.Collections.Generic;
using System.Linq;

namespace _02SetsOfElements
{
    class Program
    {
        static void Main()
        {
            int[] numInouts = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int numInput1 = numInouts[0];
            int numInput2 = numInouts[1];

            var uniqueElementsForBothInputs = new HashSet<string>();
            var uniqueElementsForInput1 = new HashSet<string>();
            var uniqueElementsForInput2 = new HashSet<string>();

            for (int i = 0; i < numInput1; i++)
            {
                uniqueElementsForInput1.Add(Console.ReadLine());
            }
            for (int i = 0; i < numInput2; i++)
            {
                uniqueElementsForInput2.Add(Console.ReadLine());
            }
            foreach (var element in uniqueElementsForInput1)
            {
                if (uniqueElementsForInput2.Contains(element))
                {
                    uniqueElementsForBothInputs.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ", uniqueElementsForBothInputs));
        }
    }
}
