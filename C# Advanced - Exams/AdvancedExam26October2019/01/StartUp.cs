using System;
using System.Collections.Generic;
using System.Linq;

namespace _01
{
    public class StartUp
    {
        public static void Main()
        {
            int[] input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var males = new Stack<int>();
            foreach (var item in input1)
            {
                males.Push(item);
            }

            var females = new Queue<int>();
            foreach (var item in input2)
            {
                females.Enqueue(item);
            }

            int counter = 0;

            while (males.Any() && females.Any())
            {
                if (males.Peek() <= 0)
                {
                    males.Pop();

                    continue;
                }

                if (females.Peek() <= 0)
                {
                    females.Dequeue();

                    continue;
                }

                if (males.Peek() % 25 == 0)
                {
                    males.Pop();
                    males.Pop();

                    continue;
                }

                if (females.Peek() % 25 == 0)
                {
                    females.Dequeue();
                    females.Dequeue();

                    continue;
                }

                if (males.Peek() == females.Peek())
                {
                    males.Pop();
                    females.Dequeue();

                    counter++;
                }
                else
                {
                    males.Push(males.Pop() - 2);
                    females.Dequeue();
                }
            }

            Console.WriteLine($"Matches: {counter}");

            if (males.Any())
            {
                Console.WriteLine($"Males left: {string.Join(", ", males)}");
            }
            else
            {
                Console.WriteLine("Males left: none");
            }

            if (females.Any())
            {
                Console.WriteLine($"Females left: {string.Join(", ", females)}");
            }
            else
            {
                Console.WriteLine("Females left: none");
            }
        }
    }
}
