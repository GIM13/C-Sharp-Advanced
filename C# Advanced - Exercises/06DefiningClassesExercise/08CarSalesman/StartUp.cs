using System;
using System.Collections.Generic;

namespace _08CarSalesman
{
    public class StartUp
    {
        public static void Main()
        {
            int numEngines = int.Parse(Console.ReadLine());

            var listEngines = new List<Engine>();

            for (int i = 0; i < numEngines; i++)
            {
                string[] infoEngine = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (infoEngine.Length == 2)
                {
                    string model = infoEngine[0];
                    string power = infoEngine[1];

                    listEngines.Add(new Engine(model, power));
                }
                else if (infoEngine.Length == 3)
                {
                    string model = infoEngine[0];
                    string power = infoEngine[1];

                    if (int.TryParse(infoEngine[2], out int displacement))
                    {
                        listEngines.Add(new Engine(model, power, displacement));
                    }
                    else
                    {
                        string efficiency = infoEngine[2];
                        listEngines.Add(new Engine(model, power, efficiency));
                    }
                }
                else if (infoEngine.Length == 4)
                {
                    string model = infoEngine[0];
                    string power = infoEngine[1];
                    int displacement = int.Parse(infoEngine[2]);
                    string efficiency = infoEngine[3];

                    listEngines.Add(new Engine(model, power, displacement, efficiency));
                }
            }

            int numCars = int.Parse(Console.ReadLine());

            var listCar = new List<Car>();

            for (int i = 0; i < numCars; i++)
            {
                string[] infoCars = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);

                foreach (var engine in listEngines)
                {
                    if (engine.Model == infoCars[1])
                    {
                        if (infoCars.Length == 2)
                        {
                            string model = infoCars[0];

                            listCar.Add(new Car(model, engine));
                        }
                        else if (infoCars.Length == 3)
                        {
                            string model = infoCars[0];

                            if (int.TryParse(infoCars[2], out int weight))
                            {
                                listCar.Add(new Car(model, engine, weight));
                            }
                            else
                            {
                                string color = infoCars[2];
                                listCar.Add(new Car(model, engine, color));
                            }
                        }
                        else if (infoCars.Length == 4)
                        {
                            string model = infoCars[0];
                            int weight = int.Parse(infoCars[2]);
                            string color = infoCars[3];

                            listCar.Add(new Car(model, engine, weight, color));
                        }
                    }
                }
            }

            foreach (var car in listCar)
            {
                Console.WriteLine(car);
            }
        }
    }
}
