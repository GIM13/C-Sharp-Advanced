using System;

namespace _06SpeedRacing
{
    public class Car
    {
        public  Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; } = 0;

        public  void Moving(double distanceTraveled, Car car)
        {
            double fuelNeeded = distanceTraveled * car.FuelConsumptionPerKilometer;

            if (car.FuelAmount < fuelNeeded)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                car.TravelledDistance += distanceTraveled;
                car.FuelAmount -= fuelNeeded;
            }
        }
    }
}
