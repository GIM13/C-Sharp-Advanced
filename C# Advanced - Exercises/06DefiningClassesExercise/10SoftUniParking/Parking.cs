using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        public int capacity;

        public Parking(int capacity)
        {
            this.capacity = capacity;

            this.Cars = new List<Car>();
        }

        public List<Car> Cars { get; set; }

        public int Count { get; private set; } 

        public string AddCar(Car car)
        {
            if (Cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if (capacity <= Count)
            {
                return "Parking is full!";
            }

            Count++;

            Cars.Add(car);

            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public Car GetCar(string registrationNumber)
        {
            var car = new Car(string.Empty, string.Empty, 0, string.Empty);

            if (Cars.Any(c => c.RegistrationNumber == registrationNumber))
            {
                car = Cars
                    .Where(c => c.RegistrationNumber == registrationNumber)
                    .ToArray()[0];
            }

            return car;
        }

        public string RemoveCar(string registrationNumber)
        {
            if (Cars.Any(c => c.RegistrationNumber == registrationNumber))
            {
                Clears(registrationNumber);

                return $"Successfullyremoved {registrationNumber}";
            }

            return "Car with that registration number, doesn't exist!";
        }

        private void Clears(string registrationNumber)
        {
            Count--;

            var forRemove = Cars
                .Where(c => c.RegistrationNumber == registrationNumber)
                .ToArray()[0];

            Cars.Remove(forRemove);
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var registrationNumber in registrationNumbers)
            {
                if (Cars.Any(c => c.RegistrationNumber == registrationNumber))
                {
                    Clears(registrationNumber);
                }
            }
        }
    }
}
