using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int numberEnqueue = input[0];
            int numberDequeue = input[1];
            int wantedElement = input[2];

            int[] integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var queue = new Queue<int>();

            for (int i = 0; i < numberEnqueue; i++)
            {
                queue.Enqueue(integers[i]);
            }
            for (int i = 0; i < numberDequeue; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(wantedElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                int minElement = 0;

                if (queue.Count() > 0)
                {
                    minElement = queue.ToArray().Min();
                }
                Console.WriteLine(minElement);
            }
        }
    }
}
