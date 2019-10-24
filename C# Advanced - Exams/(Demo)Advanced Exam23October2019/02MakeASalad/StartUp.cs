using System;
using System.Collections.Generic;
using System.Linq;

namespace _02MakeASalad
{
    public class StartUp
    {
        public static void Main()
        {
            const int tomato = 80;
            const int carrot = 136;
            const int lettuce = 109;
            const int potato = 215;

            string[] input1 = Console.ReadLine().Split();
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var vegetables = new Queue<string>();

            foreach (var item in input1)
            {
                vegetables.Enqueue(item);
            }

            var salads = new Stack<int>();

            foreach (var item in input2)
            {
                salads.Push(item);
            }

            var readySalads = new List<int>();

            while (vegetables.Any() && salads.Any())
            {
                var salad = salads.Peek();

                while (salad > 0 && vegetables.Any())
                {
                    switch (vegetables.Dequeue())
                    {
                        case "tomato": salad -= tomato; break;

                        case "carrot": salad -= carrot; break;

                        case "lettuce": salad -= lettuce; break;

                        case "potato": salad -= potato; break;
                    }
                }

                readySalads.Add(salads.Pop());
            }

            Console.WriteLine(string.Join(" ",readySalads));

            if (vegetables.Any())
            {
                Console.WriteLine(string.Join(" ", vegetables));
            }
            else if (salads.Any())
            {
                Console.WriteLine(string.Join(" ", salads));
            }
        }
    }
}
