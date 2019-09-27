using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> guests = Console.ReadLine().Split().ToList();
        string[] command = Console.ReadLine().Split();

        while (command[0] != "Party!")
        {
            for (int i = 0; i < guests.Count; i++)
            {
                if (command[0] == "Remove")
                {
                    if ((command[1] == "StartsWith"&& guests[i].StartsWith(command[2]))
                     || (command[1] == "EndsWith"&& guests[i].EndsWith(command[2]))
                     || (command[1] == "Length"&& guests[i].Count() == int.Parse(command[2])))
                    {
                        guests.RemoveAt(i);
                        i--;
                    }
                }
                else if (command[0] == "Double")
                {
                    if ((command[1] == "StartsWith" && guests[i].StartsWith(command[2]))
                     || (command[1] == "EndsWith" && guests[i].EndsWith(command[2]))
                     || (command[1] == "Length" && guests[i].Count() == int.Parse(command[2])))
                    {
                        guests.Insert(i + 1, guests[i]);
                        i++;
                    }
                }
            }
            command = Console.ReadLine().Split();
        }
        if (guests.Any())
        {
            Console.WriteLine(string.Join(", ",guests) + " are going to the party!");
        }
        else
        {
            Console.WriteLine("Nobody is going to the party!"); 
        }
    }
}
