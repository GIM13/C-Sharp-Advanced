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

        Predicate<string> addCom = x => x == "add";
        Predicate<string> multiplyCom = x => x == "multiply";
        Predicate<string> subtractCom = x => x == "subtract";
        Predicate<string> printCom = x => x == "print";
        Predicate<string> end = x => x == "end";

        Func<int[], int[]> add1 = arr => arr.Select(x => ++x).ToArray();
        Func<int[], int[]> multiplyTo2 = arr => arr.Select(x => x *= 2).ToArray();
        Func<int[], int[]> subtract1 = arr => arr.Select(x => --x).ToArray();
        Action<int[]> print = x => Console.WriteLine(string.Join(" ", x));

        string command;
        while (!end(command = Console.ReadLine()))
        {
            if (addCom(command))
            {
                numbers = add1(numbers);
            }
            else if (multiplyCom(command))
            {
                numbers = multiplyTo2(numbers);
            }
            else if (subtractCom(command))
            {
                numbers = subtract1(numbers);
            }
            else if (printCom(command))
            {
                print(numbers);
            }
        }
    }
}

