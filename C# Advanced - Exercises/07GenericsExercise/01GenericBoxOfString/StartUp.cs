using System;

namespace _01GenericBox
{
    public class StartUp
    {
        public static void Main()
        {
            int numInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < numInput; i++)
            {
                string input = Console.ReadLine();

                var result = new Box<string>(input);

                Console.WriteLine(result);
            }
        }
    }
}
