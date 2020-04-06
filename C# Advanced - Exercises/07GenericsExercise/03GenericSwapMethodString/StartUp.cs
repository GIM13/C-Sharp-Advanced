using _01GenericBox;
using System;

namespace _03GenericSwapMethodString
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

            string indexes = Console.ReadLine();
            int index1 = int.Parse(indexes[0].ToString());
            int index2 = int.Parse(indexes[2].ToString());

            Swap(input, index1, index2);

            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }

        private static void Swap<T>(T[] input, int index1, int index2)
        {
            T save = input[index1];

            input[index1] = input[index2];

            input[index2] = save;
        }
    }
}
