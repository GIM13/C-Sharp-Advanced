using System;
using System.Linq;

namespace _04Froggy
{
    public class StartUp
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            var lake = new Lake(input);

            Console.Write(string.Join(", ", lake));
        }
    }
}
