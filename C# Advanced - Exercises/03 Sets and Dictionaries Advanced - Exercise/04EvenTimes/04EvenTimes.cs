using System;
using System.Collections.Generic;

namespace _04EvenTimes
{
    class Program
    {
        static void Main()
        {
            int numInput = int.Parse(Console.ReadLine());

            var digits = new Dictionary<int, int>();

            for (int i = 0; i < numInput; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (!digits.ContainsKey(input))
                {
                    digits.Add(input,0);
                }
                digits[input]++;
            }
            foreach (var item in digits)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
