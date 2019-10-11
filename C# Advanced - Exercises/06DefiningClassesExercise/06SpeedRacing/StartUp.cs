using System;
using System.Collections.Generic;

namespace _06SpeedRacing
{
    public class StartUp
    {
        public static void Main()
        {
            int numCars = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < numCars; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuelAmount = int.Parse(input[1]);
                double fuelConsumptionPerKilometer = double
                    .Parse(input[2]);

                var newCar = new Car(model, fuelAmount, fuelConsumptionPerKilometer);

                cars.Add(newCar);
            }

            var command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                string model = command[1];
                double distanceTraveled = double.Parse(command[2]);

                foreach (var car in cars)
                {
                    if (car.Model == model)
                    {
                        car.Moving(distanceTraveled, car);
                    }
                }

                command = Console.ReadLine().Split();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
