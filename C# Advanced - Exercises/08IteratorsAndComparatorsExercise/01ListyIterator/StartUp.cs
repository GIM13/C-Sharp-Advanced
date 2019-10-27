using System;

namespace _01ListyIterator
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
                else if (command.StartsWith("Print"))
                {
                    collection.Print();
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
