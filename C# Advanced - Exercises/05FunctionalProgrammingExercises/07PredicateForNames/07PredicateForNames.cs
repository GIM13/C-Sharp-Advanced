using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int nameLength = int.Parse(Console.ReadLine());
        string[] names = Console.ReadLine().Split();

        Action<string[]> lessThanOrEqual = arr => arr
                         .Where(x => x.Length <= nameLength)
                         .ToList()
                         .ForEach(x => Console.WriteLine(x));
        lessThanOrEqual(names);
    }
}

