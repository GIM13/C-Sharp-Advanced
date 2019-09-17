using System;
using System.Linq;

namespace _08Bombs
{
    class Program
    {
        static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                int[] row = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < row.Length; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            string[] coordinatesBombs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var coordinatesBomb in coordinatesBombs)
            {
                int[] rowCol = coordinatesBomb
                    .Split(",")
                    .Select(int.Parse)
                    .ToArray();
                int rowBomb = rowCol[0];
                int colBomb = rowCol[1];
                int valueBomb = matrix[rowBomb, colBomb];

                if (valueBomb > 0)
                {
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            if (0 <= rowBomb + i && rowBomb + i < matrixSize
                             && 0 <= colBomb + j && colBomb + j < matrixSize
                             && matrix[rowBomb + i, colBomb + j] > 0)
                            {
                                matrix[rowBomb + i, colBomb + j] -= valueBomb;
                            }
                        }
                    }
                }
            }
            int aliveCells = 0;
            long aliveCellsSum = 0;

            foreach (var valueCells in matrix)
            {
                if (valueCells > 0)
                {
                    aliveCells++;
                    aliveCellsSum += valueCells;
                }
            }
            Console.WriteLine($"Alive cells: { aliveCells}");
            Console.WriteLine($"Sum: {aliveCellsSum}");

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
