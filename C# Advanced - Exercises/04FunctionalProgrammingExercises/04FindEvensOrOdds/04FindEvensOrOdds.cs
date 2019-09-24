using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] range = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int start = range[0];
        int end = range[1];

        string command = Console.ReadLine();

        Predicate<string> oddCom = x => x == "odd";
        Predicate<int> oddNum = x => x % 2 != 0;
        Predicate<string> evenCom = x => x == "even";
        Predicate<int> evenNum = x => x % 2 == 0;

        for (int i = start; i <= end; i++)
        {
            if (oddCom(command) && oddNum(i))
            {
                Console.Write(i + " ");
            }
            if (evenCom(command) && evenNum(i))
            {
                Console.Write(i + " ");
            }
        }
    }
}

