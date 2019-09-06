using System;
using System.Collections.Generic;
using System.Linq;

namespace _12CupsAndBottles
{
    class Program
    {
        static void Main()
        {
            var cups = new Queue<int>();
            int[] input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.ForEach(input1, x => cups.Enqueue(x));

            var bottles = new Stack<int>();
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.ForEach(input2, x => bottles.Push(x));

            int wastageWater = 0;

            while (bottles.Count > 0 && cups.Count > 0)
            {
                if (bottles.Peek() >= cups.Peek())
                {
                    wastageWater += bottles.Peek() - cups.Peek();
                    bottles.Pop();
                    cups.Dequeue();
                }
                else
                {
                    int copyCup = cups.Dequeue();

                    while (copyCup > 0)
                    {
                        if (bottles.Peek() >= copyCup)
                        {
                            wastageWater += bottles.Peek() - copyCup;
                        }
                        copyCup -= bottles.Pop();
                    }
                }
            }
            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ",bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastageWater}");
        }
    }
}
