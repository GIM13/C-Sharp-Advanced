using System;
using System.Linq;
using System.Collections.Generic;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();
            Stack<string> carsReverseStack = new Stack<string>();
            int carsCount = 0;

            string inputMessage;
            while ((inputMessage = Console.ReadLine()) != "END")
            {
                if (inputMessage != "green")
                {
                    cars.Enqueue(inputMessage);
                }
                else
                {
                    int copy = greenLightDuration;

                    while (cars.Any())
                    {
                        int carsSum = cars.Peek().Length;
                        carsReverseStack.Push(cars.Dequeue());

                        if (greenLightDuration + freeWindowDuration - carsSum >= 0)
                        {
                            greenLightDuration -= carsSum;
                            carsCount++;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("A crash happened!");
                            int indexLetter = carsSum - (greenLightDuration + freeWindowDuration);
                            string carHitLetter = carsReverseStack.Pop();
                            string hitLetter = carHitLetter.Substring(carHitLetter.Length - indexLetter, 1);
                            Console.WriteLine($"{carHitLetter} was hit at {hitLetter}.");
                            return;
                        }
                    }
                    greenLightDuration = copy;
                }
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carsCount} total cars passed the crossroads.");
        }
    }
}
