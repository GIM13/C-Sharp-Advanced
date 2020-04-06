using _01GenericBox;
using System;

namespace _02GenericBoxOfInteger
{
    public class StartUp
    {
        public static void Main()
        {
            int numInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < numInput; i++)
            {
                string input = Console.ReadLine();

                var result = new Box<int>(int.Parse(input));

                Console.WriteLine(result);
            }
        }
    }
}
