using System;
using System.Linq;

namespace _05GenericCountMethodString
{
    public class StartUp
    {
        public static void Main()
        {
            int numInput = int.Parse(Console.ReadLine());

            var input = new Box<string>[numInput];

            for (int i = 0; i < numInput; i++)
            {
                input[i] = new Box<string>(Console.ReadLine());
            }

            var standard = new Box<string>(Console.ReadLine());

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
