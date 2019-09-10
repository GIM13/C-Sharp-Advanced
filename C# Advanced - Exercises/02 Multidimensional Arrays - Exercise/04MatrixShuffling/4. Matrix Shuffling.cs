using System;
using System.Linq;

namespace _04MatrixShuffling
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
            var matrix = new string[rows,columns];

            for (int row = 0; row < rows; row++)
            {
                string[] matrixRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = matrixRow[col];
                }
            }
            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "END")
            {
                if (command.Length == 5
                    && command[0] == "swap")
                {
                    int row1 = int.Parse(command[1]);
                    int col1 = int.Parse(command[2]);
                    int row2 = int.Parse(command[3]);
                    int col2 = int.Parse(command[4]);

                    if (0 <= row1 && row1 < rows
                     && 0 <= col1 && col1 < columns
                     && 0 <= row2 && row2 < rows
                     && 0 <= col2 && col2 < columns)
                    {
                        string save = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = save;
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                Console.Write(matrix[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
