using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main()
        {
            int numberTimes = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            for (int i = 0; i < numberTimes; i++)
            {
                int[] command = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if (command[0] == 1)
                {
                    stack.Push(command[1]);
                }
                else if (command[0] == 2 && stack.Count() > 0)
                {
                    stack.Pop();
                }
                else if (command[0] == 3 && stack.Count() > 0)
                {
                    int maxElement = stack.ToArray().Max();

                    Console.WriteLine(maxElement);
                }
                else if (command[0] == 4 && stack.Count() > 0)
                {
                    int minElement = stack.ToArray().Min();

                    Console.WriteLine(minElement);
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
