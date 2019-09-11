using System;
using System.Collections.Generic;

namespace _01UniqueUsernames
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            var names = new HashSet<string>();
            for (int i = 0; i < num; i++)
            {
                names.Add(Console.ReadLine());
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
