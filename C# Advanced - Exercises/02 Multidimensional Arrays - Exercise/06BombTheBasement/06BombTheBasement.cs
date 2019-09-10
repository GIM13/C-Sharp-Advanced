using System;
using System.Linq;

namespace _06BombTheBasement
{
    class Program
    {
        static void Main()
        {
            int[] matrixDimensions = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();
            int rows = matrixDimensions[0];
            int columns = matrixDimensions[1];
            var matrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < opaaa; col++)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
