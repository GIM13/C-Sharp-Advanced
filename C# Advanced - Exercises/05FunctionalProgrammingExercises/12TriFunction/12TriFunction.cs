using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int criteria = int.Parse(Console.ReadLine());
        string[] names = Console.ReadLine().Split();

        Func<string, int, bool> isItBiggerStringSum = (x, y) => x.ToCharArray()
                                                       .Select(c => (int)c)
                                                       .Sum() >= y;
        Func<string[], Func<string, int, bool>, string[]> accordingCriterion = (name, func) =>
                                                   name.Where(z => func(z, criteria))
                                                       .ToArray();
        string[] result = accordingCriterion(names, isItBiggerStringSum);

        if (result.Any())
        {
            Console.WriteLine(result[0]);
        }
    }
}

