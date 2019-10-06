using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Func<int[], int[]> even = e => e = numbers
                                          .Where(x => x % 2 == 0)
                                          .OrderBy(x => x)
                                          .ToArray();

        Func<int[], int[]> odd = o => o = numbers
                                          .Where(x => x % 2 != 0)
                                          .OrderBy(x => x)
                                          .ToArray();

        Func<int[], Dictionary<int, int[]>> firstEven = x =>
                                        new Dictionary<int, int[]>
                                        { { 1, even(x) }, { 2, odd(x) } };

        Dictionary<int, int[]> result = firstEven(numbers);

        Array.Sort(result.Keys.ToArray());

        foreach (var arr in result)
        {
            Console.Write(string.Join(" ", arr.Value) + " ");
        }
    }
}

