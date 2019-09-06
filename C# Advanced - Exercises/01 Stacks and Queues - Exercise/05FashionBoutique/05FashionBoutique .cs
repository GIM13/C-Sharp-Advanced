using System;
using System.Collections.Generic;
using System.Linq;

namespace _05FashionBoutique
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            int numberRack = 1;

            var boxWithClothes = new Stack<int>();
            Array.ForEach(input,x => boxWithClothes.Push(x));

            int capacity = rackCapacity;

            foreach (var garment in boxWithClothes)
            {
                if (capacity >= garment)
                {
                    capacity -= garment;
                }
                else
                {
                    capacity = rackCapacity;
                    capacity -= garment;
                    numberRack++;
                }
            }
            Console.WriteLine(numberRack);
        }
    }
}
