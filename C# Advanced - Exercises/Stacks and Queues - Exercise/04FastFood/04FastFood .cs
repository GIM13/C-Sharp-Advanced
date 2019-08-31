using System;
using System.Collections.Generic;
using System.Linq;

namespace _04FastFood
{
    class Program
    {
        static void Main()
        {
            int quantityFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var queueOrders = new Queue<int>();

            foreach (var order in orders)
            {
                queueOrders.Enqueue(order);
            }
            Console.WriteLine(queueOrders.Max());

            int counter = queueOrders.Count();

            for (int i = 0; i < counter; i++)
            {
                if (quantityFood >= queueOrders.Peek())
                {
                    quantityFood -= queueOrders.Peek();
                    queueOrders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ",queueOrders)}");
                    break;
                }
            }
            if (queueOrders.Count() == 0)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
