using System;
using System.Linq;

namespace _01DiagonalDifference
{
    class Program
    {
        static void Main()
        {
            int sizeMatrix = int.Parse(Console.ReadLine());

            int[,] matrix = new int[sizeMatrix, sizeMatrix];
            int sumPrimaryDagonal = 0;
            int sumSecondaryDiagonal = 0;

            for (int row = 0; row < sizeMatrix; row++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < sizeMatrix; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            for (int i = 0; i < sizeMatrix; i++)
            {
                sumPrimaryDagonal += matrix[i, i];
                sumSecondaryDiagonal += matrix[i, sizeMatrix - 1 - i];
            }
            Console.WriteLine(Math.Abs(sumPrimaryDagonal - sumSecondaryDiagonal));
        }
    }
}
