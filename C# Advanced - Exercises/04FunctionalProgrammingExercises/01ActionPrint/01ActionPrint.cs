using System;
using System.Linq;

namespace _01ActionPrint
{
    class Program
    {
        static void Main()
        {
            Action<string[]> printArr = arr => arr
                .ToList()
                .ForEach(text => Console.WriteLine(text)); 

            string[] collectionStrings = Console.ReadLine().Split();

            printArr(collectionStrings);
        }
    }
}
