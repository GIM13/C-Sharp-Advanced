using System;
using System.Linq;
using System.Collections.Generic;

namespace _06Wardrobe
{
    class Program
    {
        static void Main()
        {
            int numInput = int.Parse(Console.ReadLine());

            var colorClothing = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numInput; i++)
            {
                string[] splitsInto = { " -> ", "," };

                string[] input = Console.ReadLine()
                    .Split(splitsInto, StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                string[] clothings = input.TakeLast(input.Length - 1).ToArray();
                var dictionary = new Dictionary<string, int>();

                if (!colorClothing.ContainsKey(color))
                {
                    colorClothing.Add(color, dictionary);
                }
                for (int j = 0; j < clothings.Length; j++)
                {
                    if (!colorClothing[color].ContainsKey(clothings[j]))
                    {
                        colorClothing[color].Add(clothings[j], 0);
                    }
                    colorClothing[color][clothings[j]]++;
                }
            }
            string[] lookFor = Console.ReadLine().Split();

            foreach (var color in colorClothing)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var garment in color.Value)
                {
                    if (color.Key == lookFor[0] && garment.Key == lookFor[1])
                    {
                        Console.WriteLine($"* {garment.Key} - {garment.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {garment.Key} - {garment.Value}");
                    }
                }
            }
        }
    }
}
