using System;
using System.Linq;
using System.Collections.Generic;

namespace _06SongsQueue
{
    class Program
    {
        static void Main()
        {
            string[] songsInput = Console.ReadLine().Split(", ");

            var songsQueue = new Queue<string>();
            Array.ForEach(songsInput, x => songsQueue.Enqueue(x));

            while (songsQueue.Count > 0)
            {
                string command = Console.ReadLine();

                if (command == "Play")
                {
                    songsQueue.Dequeue();
                }
                else if (command.StartsWith("Add"))
                {
                    string song = command.Substring(4);

                    if (songsQueue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songsQueue.Enqueue(song);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue.ToArray()));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
