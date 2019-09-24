using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int divider = int.Parse(Console.ReadLine());

        Predicate<int> divisibleToDivider = x => x % divider == 0;
        Func<int[],int[]> removeDivisibleToDivider = x => x
                                       .Where(z => !divisibleToDivider(z))
                                       .ToArray();
        Func<int[],int[]> revers = y => y.Reverse().ToArray();

        numbers = removeDivisibleToDivider(revers(numbers));
        Console.WriteLine(string.Join(" ",numbers));
    }
}

