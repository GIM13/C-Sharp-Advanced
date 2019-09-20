using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int numberPush = input[0];
            int numberPop = input[1];
            int wantedElement = input[2];

            int[] integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var stack = new Stack<int>();

            for (int i = 0; i < numberPush; i++)
            {
                stack.Push(integers[i]);
            }
            for (int i = 0; i < numberPop; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(wantedElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                int minElement = 0;

                if (stack.Count() > 0)
                {
                    minElement = stack.Min();
                }
                Console.WriteLine(minElement);
            }
        }
    }
}
