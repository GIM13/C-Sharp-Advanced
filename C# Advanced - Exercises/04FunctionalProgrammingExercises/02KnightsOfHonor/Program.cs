using System;
using System.Linq;

namespace _02KnightsOfHonor
{
    class Program
    {
        static void Main()
        {
            Action<string[]> printAddSir = arr => arr
                             .ToList()
                             .ForEach(x => Console.WriteLine($"Sir {x}"));

            string[] text = Console.ReadLine().Split();

            printAddSir(text);
        }
    }
}
