using System;
using System.Linq;

namespace _03MaximalSum
{
    class Program
    {
        static void Main()
        {
            int[] matrixDimensions = Console.ReadLine()
                 .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            if (matrixDimensions[0] > 2 && matrixDimensions[1] > 2)
            {
                var matrix = new long[matrixDimensions[0], matrixDimensions[1]];

                for (int row = 0; row < matrixDimensions[0]; row++)
                {
                    long[] matrixRow = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(long.Parse)
                        .ToArray();
                    for (int col = 0; col < matrixDimensions[1]; col++)
                    {
                        matrix[row, col] = matrixRow[col];
                    }
                }
                long maxSum3x3Squares = long.MinValue;
                int saveIndexsRow = -1;
                int saveIndexsCol = -1;

                for (int row = 0; row < matrix.GetLength(0) - 2; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                    {
                        long sum3x3Squares = matrix[row, col]
                                           + matrix[row, col + 1]
                                           + matrix[row, col + 2]
                                           + matrix[row + 1, col]
                                           + matrix[row + 1, col + 1]
                                           + matrix[row + 1, col + 2]
                                           + matrix[row + 2, col]
                                           + matrix[row + 2, col + 1]
                                           + matrix[row + 2, col + 2];
                        if (maxSum3x3Squares < sum3x3Squares)
                        {
                            maxSum3x3Squares = sum3x3Squares;
                            saveIndexsRow = row;
                            saveIndexsCol = col;
                        }
                    }
                }
                Console.WriteLine($"Sum = {maxSum3x3Squares}");

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(matrix[saveIndexsRow + i, saveIndexsCol] + " "
                                    + matrix[saveIndexsRow + i, saveIndexsCol  + 1] + " "
                                    + matrix[saveIndexsRow + i, saveIndexsCol  + 2]);
                }
            }
        }
    }
}
