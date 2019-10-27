using System;

namespace _02Collection
{
    public class StartUp
    {
        public static void Main()
        {
            string command = Console.ReadLine();

            var collection = new ListyIterator<string>();

            while (!command.StartsWith("END"))
            {
                if (command.StartsWith("Create") && command.Length > 7)
                {
                    var input = command.Substring(7).Split();

                    collection = new ListyIterator<string>(input);
                }
                else if (command.StartsWith("Move"))
                {
                    Console.WriteLine(collection.Move());
                }
                else if (command.EndsWith("Print"))
                {
                    collection.Print();
                }
                else if (command.EndsWith("PrintAll"))
                {
                    collection.PrintAll();
                    Console.WriteLine();
                }
                else if (command.StartsWith("HasNext"))
                {
                    Console.WriteLine(collection.HasNext());
                }

                command = Console.ReadLine();
            }
        }
    }
}
