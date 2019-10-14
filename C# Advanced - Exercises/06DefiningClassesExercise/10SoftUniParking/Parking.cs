using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        private int capacity;

        public Parking(int capacity)
        {
            this.capacity = capacity;

            this.Cars = new List<Car>();
        }

        public List<Car> Cars { get; set; }

        public int Count { get; private set; }

        public string AddCar(Car car)
        {
            if (this.Cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if (capacity <= this.Count)
            {
                return "Parking is full!";
            }

            this.Count++;

            this.Cars.Add(car);

            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public Car GetCar(string registrationNumber)
        {
            var car = this.Cars
                 .FirstOrDefault(c => c.RegistrationNumber == registrationNumber);

            return car;
        }

        public string RemoveCar(string registrationNumber)
        {
            if (this.Cars.Any(c => c.RegistrationNumber == registrationNumber))
            {
                Clears(registrationNumber);

                return $"Successfullyremoved {registrationNumber}";
            }

            return "Car with that registration number, doesn't exist!";
        }

        private void Clears(string registrationNumber)
        {
            this.Count--;

            var forRemove = this.Cars
                .FirstOrDefault(c => c.RegistrationNumber == registrationNumber);

            this.Cars.Remove(forRemove);
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var registrationNumber in registrationNumbers)
            {
                if (this.Cars.Any(c => c.RegistrationNumber == registrationNumber))
                {
                    Clears(registrationNumber);
                }
            }
        }
    }
}
