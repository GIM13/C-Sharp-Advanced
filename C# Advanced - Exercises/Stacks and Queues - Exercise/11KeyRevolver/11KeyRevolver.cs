using System;
using System.Collections.Generic;
using System.Linq;

namespace _11KeyRevolver
{
    class Program
    {
        static void Main()
        {
            int priceBullet = int.Parse(Console.ReadLine());
            int sizeGunBarrel = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] locks = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int valueIntelligence = int.Parse(Console.ReadLine());

            var bulletsStak = new Stack<int>();
            Array.ForEach(bullets, x => bulletsStak.Push(x));
            var locksQueue = new Queue<int>();
            Array.ForEach(locks, x => locksQueue.Enqueue(x));

            int counterBarrel = sizeGunBarrel;

            while (locksQueue.Count > 0 && bulletsStak.Count > 0)
            {
                while (counterBarrel > 0 
                    && locksQueue.Count > 0 
                    && bulletsStak.Count > 0)
                {
                    if (bulletsStak.Peek() <= locksQueue.Peek())
                    {
                        bulletsStak.Pop();
                        locksQueue.Dequeue();
                        Console.WriteLine("Bang!");
                    }
                    else
                    {
                        bulletsStak.Pop();
                        Console.WriteLine("Ping!");
                    }
                    counterBarrel--;
                    valueIntelligence -= priceBullet;
                }
                if (bulletsStak.Count > 0 && counterBarrel == 0)
                {
                    counterBarrel = bulletsStak.Count;
                    if (counterBarrel > sizeGunBarrel)
                    {
                        counterBarrel = sizeGunBarrel;
                    }
                    Console.WriteLine("Reloading!");
                }
            }
            if (bulletsStak.Count > 0 
             || (bulletsStak.Count == 0 && locksQueue.Count == 0))
            {
                Console.WriteLine($"{bulletsStak.Count} bullets left. Earned ${valueIntelligence}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }
        }
    }
}
