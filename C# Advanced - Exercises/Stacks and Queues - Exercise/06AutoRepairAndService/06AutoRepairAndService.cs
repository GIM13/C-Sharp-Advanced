using System;
using System.Collections.Generic;
using System.Linq;

namespace _06AutoRepairAndService
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            var carModels = new Queue<string>();
            Array.ForEach(input, x => carModels.Enqueue(x));
            var servicedCars = new Stack<string>();
            string command;
            while (!(command = Console.ReadLine()).StartsWith("End"))
            {
                if (command.StartsWith("Service") && carModels.Count() > 0)
                {
                    string vehicleName = carModels.Peek();
                    servicedCars.Push(carModels.Peek());
                    carModels.Dequeue();
                    Console.WriteLine($"Vehicle {vehicleName} got served.");
                }
                else if (command.StartsWith("CarInfo"))
                {
                    string car = command.Substring(8);
                    if (carModels.Contains(car))
                    {
                        Console.WriteLine($"Still waiting for service.");
                    }
                    else
                    {
                        Console.WriteLine($"Served.");
                    }
                }
                else if (command.StartsWith("History"))
                {
                    Console.WriteLine(string.Join(", ", servicedCars.ToArray()));
                }
            }
            if (carModels.Count() > 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", carModels.ToArray())}");
            }
            Console.WriteLine($"Served vehicles: {string.Join(", ", servicedCars.ToArray())}");
        }
    }
}
