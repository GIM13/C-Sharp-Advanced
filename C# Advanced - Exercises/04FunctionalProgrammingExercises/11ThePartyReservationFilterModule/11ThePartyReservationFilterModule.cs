using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> guests = Console.ReadLine().Split().ToList();
        string[] command = Console.ReadLine().Split(";");

        var banished = new Dictionary<string, int>();

        while (command[0] != "Print")
        {
            if (command[0] == "Add filter")
            {
                for (int i = 0; i < guests.Count; i++)
                {
                    if ((command[1] == "Starts with" && guests[i].StartsWith(command[2]))
                     || (command[1] == "Ends with" && guests[i].EndsWith(command[2]))
                     || (command[1] == "Length" && guests[i].Count() == int.Parse(command[2]))
                     || (command[1] == "Contains" && guests[i].Contains(command[2])))
                    {
                        if (!banished.ContainsKey(guests[i]))
                        {
                            banished.Add(guests[i], i);
                        }
                        guests.RemoveAt(i);
                        i--;
                    }
                }
            }
            else if (command[0] == "Remove filter")
            {
                foreach (var name in banished)
                {
                    if ((command[1] == "Starts with" && name.Key.StartsWith(command[2]))
                     || (command[1] == "Ends with" && name.Key.EndsWith(command[2]))
                     || (command[1] == "Length" && name.Key.Count() == int.Parse(command[2]))
                     || (command[1] == "Contains" && name.Key.Contains(command[2])))
                    {
                        if (name.Value < guests.Count)
                        {
                            guests.Insert(name.Value, name.Key);
                        }
                        else
                        {
                            guests.Add(name.Key);
                        }
                    }
                }
            }
            command = Console.ReadLine().Split(";");
        }
        if (guests.Any())
        {
            Console.WriteLine(string.Join(" ", guests));
        }
    }
}


