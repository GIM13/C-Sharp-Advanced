using System;
using System.Linq;

namespace _02SquaresInMatrix
{
    class Program
    {
        static void Main()
        {
            int[] matrixDimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var matrix = new string[matrixDimensions[0], matrixDimensions[1]];

            for (int row = 0; row < matrixDimensions[0]; row++)
            {
                string[] matrixRow = Console.ReadLine().Split();

                for (int col = 0; col < matrixDimensions[1]; col++)
                {
                    matrix[row, col] = matrixRow[col];
                }
            }
            int counter2x2Squares = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1]
                     && matrix[row, col] == matrix[row + 1, col]
                     && matrix[row, col] == matrix[row + 1, col + 1]
                     )
                    {
                        counter2x2Squares++;
                    }
                }
            }
            Console.WriteLine(counter2x2Squares);
        }
    }
}
