using System;
using System.Collections.Generic;
using System.Linq;

namespace _07TruckTour
{
    class Program
    {
        static void Main()
        {
            int numberPetrolPumps = int.Parse(Console.ReadLine());

            var totalDistancePetrolPumps = new Queue<long>();
            var totalAmountPetrol = new Queue<long>();

            for (int i = 0; i < numberPetrolPumps; i++)
            {
                long[] input = Console.ReadLine()
                    .Split()
                    .Select(long.Parse)
                    .ToArray();
                totalAmountPetrol.Enqueue(input[0]);
                totalDistancePetrolPumps.Enqueue(input[1]);
            }
            for (int i = 0; i < numberPetrolPumps; i++)
            {
                long availableAmountPetrol = totalAmountPetrol.Peek() - totalDistancePetrolPumps.Peek();
                int indexPetrolPump = i;
                int counter = 1;

                while (availableAmountPetrol >= 0 && counter < numberPetrolPumps)
                {
                    totalAmountPetrol.Enqueue(totalAmountPetrol.Dequeue());
                    totalDistancePetrolPumps.Enqueue(totalDistancePetrolPumps.Dequeue());

                    availableAmountPetrol += totalAmountPetrol.Peek() - totalDistancePetrolPumps.Peek();
                    counter++;
                }
                if (counter == numberPetrolPumps)
                {
                    Console.WriteLine(indexPetrolPump);
                    break;
                }
                else
                {
                    for (int j = 0; j < numberPetrolPumps - counter + 2; j++)
                    {
                        totalAmountPetrol.Enqueue(totalAmountPetrol.Dequeue());
                        totalDistancePetrolPumps.Enqueue(totalDistancePetrolPumps.Dequeue());
                    }
                }
            }
        }
    }
}
