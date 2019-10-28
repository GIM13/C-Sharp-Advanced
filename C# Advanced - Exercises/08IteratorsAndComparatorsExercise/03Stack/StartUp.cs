using System;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        public static void Main()
        {
            string command = Console.ReadLine();

            var stack = new Stack<int>();

            while (command != "END")
            {
                if (command.StartsWith("Push"))
                {
                    var push = command.Substring(5)
                        .Split(", ")
                        .Select(int.Parse)
                        .ToArray();

                    foreach (var item in push)
                    {
                        stack.Push(item);
                    }
                }
                else if (command.StartsWith("Pop"))
                {
                    if (stack.Any())
                    {
                        stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("No elements");
                    }
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
