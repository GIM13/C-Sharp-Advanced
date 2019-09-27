using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int endRange = int.Parse(Console.ReadLine());
        int[] dividers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Func<int, int, bool> isItDivisive = (x, y) => x % y == 0;

        for (int i = 1; i <= endRange; i++)
        {
            bool flag = true;
            foreach (var divider in dividers)
            {
                if (!isItDivisive(i, divider))
                {
                    flag = false;
                }
            }
            if (flag)
            {
                Console.Write(i + " ");
            }
        }
    }
}

