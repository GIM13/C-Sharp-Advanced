using System;
using System.Collections.Generic;

namespace _10Crossroads
{
    class Program
    {
        static void Main()
        {
            int timeGreenLight = int.Parse(Console.ReadLine());
            int freeTime = int.Parse(Console.ReadLine());

            var cars = new Queue<string>();
            int passedCars = 0;

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "green")
                {
                    string car = string.Empty;
                    int movement = timeGreenLight;
                    while (movement > 0)
                    {
                        if (cars.Count > 0)
                        {
                            movement -= cars.Peek().Length;
                            car = cars.Dequeue();
                            passedCars++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    freeTime += movement;
                    if (freeTime < 0)
                    {
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{car} was hit at {car[car.Length + freeTime]}.");
                        break;
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
            }
            if (command == "END")
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{passedCars} total cars passed the crossroads.");
            }
        }
    }
}
