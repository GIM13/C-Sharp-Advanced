using System;
using System.Linq;

namespace _06GenericCountMethodDouble
{
    public class StartUp
    {
        public static void Main()
        {
            int numInput = int.Parse(Console.ReadLine());

            var input = new double[numInput];

            for (int i = 0; i < numInput; i++)
            {
                input[i] = double.Parse(Console.ReadLine());
            }

            var standard = double.Parse(Console.ReadLine());

            Console.WriteLine(BiggerOnes(input, standard));
        }

        private static int BiggerOnes<T>(T[] input, T standard)
            where T : IComparable<T>
        {
            int result = input
                .Where(x => x.CompareTo(standard) > 0)
                .ToArray()
                .Length;

            return result;
        }
    }
}
