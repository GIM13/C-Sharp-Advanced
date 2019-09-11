using System;
using System.Linq;
using System.Collections.Generic;

namespace _05CountSymbols
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            var charCounts = new Dictionary<char, int>();

            foreach (var charr in text)
            {
                if (!charCounts.ContainsKey(charr))
                {
                    charCounts.Add(charr,0);
                }
                charCounts[charr]++;
            }
            charCounts = charCounts
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);
            foreach (var charr in charCounts)
            {
                Console.WriteLine($"{charr.Key}: {charr.Value} time/s");
            }
        }
    }
}
