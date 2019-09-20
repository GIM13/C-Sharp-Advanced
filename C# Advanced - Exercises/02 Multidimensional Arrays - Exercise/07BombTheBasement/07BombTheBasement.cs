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

            int[] bombParameters = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();
            double rowsBomb = bombParameters[0];
            double columnsBomb = bombParameters[1];
            double radiusBomb = bombParameters[2];

            var finalBasement = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                finalBasement[row] = new int[columns];

                for (int col = 0; col < columns; col++)
                { 
                    double differenceRow = Math.Abs(row - rowsBomb);
                    double differenceCol = Math.Abs(col - columnsBomb);

                    if (Math.Pow(differenceRow,2) + Math.Pow(differenceCol,2) <= Math.Pow(radiusBomb,2))
                    {
                        finalBasement[row][col] = 1;
                    }
                    else
                    {
                        finalBasement[row][col] = 0;
                    }
                }
            }
            finalBasement = finalBasement
                .OrderByDescending(x => x.Sum())
                .ToArray();
            foreach (var row in finalBasement)
            {
                Console.WriteLine(string.Join("",row));
            }
        }
    }
}
