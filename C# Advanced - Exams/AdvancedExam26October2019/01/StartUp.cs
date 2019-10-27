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

                for (int i = 0; i < males.Count; i++)
                {
                    if (males.Any() && males.Peek() <= 0)
                    {
                        males.Pop();
                        i--;
                    }
                }

                for (int i = 0; i < females.Count; i++)
                {
                    if (females.Any() && females.Peek() <= 0)
                    {
                        females.Dequeue();
                        i--;
                    }
                }

                for (int i = 0; i < males.Count; i++)
                {
                    if(males.Any() && males.Peek() % 25 == 0)
                    {
                        males.Pop();
                        males.Pop();
                        i -= 2;
                    }
                }

                for (int i = 0; i < females.Count; i++)
                {
                    if (females.Any() && females.Peek() % 25 == 0)
                    {
                        females.Dequeue();
                        females.Dequeue();
                        i -= 2;
                    }
                }
            }

            Console.WriteLine($"Matches: {counter}");

            if (males.Any())
            {

                Console.WriteLine($"Males left: {string.Join(", ",males)}");
            }
            else
            {
                Console.WriteLine("Males left: none");
            }

            if (females.Any())
            {

                Console.WriteLine($"Females left: {string.Join(", ",females)}");
            }
            else
            {
                Console.WriteLine("Females left: none");
            }
        }
    }
}
