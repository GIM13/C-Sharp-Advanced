using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Func<int[], int> minValue =  arr => arr.Min();

        int[] input = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Console.WriteLine(minValue(input)); 
    }
}

