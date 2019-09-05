using System;
using System.Collections.Generic;

namespace _09SimpleTextEditor
{
    class Program
    {
        static void Main()
        {
            int numOperations = int.Parse(Console.ReadLine());
            var texts = new Stack<string>();
            texts.Push(string.Empty);

            for (int i = 0; i < numOperations; i++)
            {
                string[] operation = Console.ReadLine().Split();
                string command = operation[0];
                
                if (command == "1")
                {
                    string valueCommand1 = operation[1];
                    texts.Push(texts.Peek() + valueCommand1);
                }
                else if (command == "2")
                {
                    int valueCommand2 = int.Parse(operation[1]);
                    string save = texts.Peek();
                    int index = save.Length - valueCommand2;
                    texts.Push(save.Remove(index));
                }
                else if (command == "3")
                {
                    int valueCommand3 = int.Parse(operation[1]);
                    Console.WriteLine(texts.Peek()[valueCommand3 - 1]);
                }
                else if (command == "4")
                {
                    texts.Pop();
                }
            }
        }
    }
}
