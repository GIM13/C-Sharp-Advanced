namespace _01ActionPrint
{
    using System;
    using System.Linq;

    internal class Program
    {
        private static void Main()
        {
            Action<string[]> printArr = arr => arr
                .ToList()

                .ForEach(text => Console.WriteLine(text));

            string[] collectionStrings = Console.ReadLine().Split();

            printArr(collectionStrings);
        }
    }
}
