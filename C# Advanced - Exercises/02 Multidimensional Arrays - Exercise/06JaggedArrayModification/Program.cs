using System;
using System.Linq;

namespace _06JaggedArrayModification
{
    class Program
    {
        static void Main()
        {
            int numRow = int.Parse(Console.ReadLine());
            int[][] rowCol = new int[numRow][];

            for (int i = 0; i < numRow; i++)
            {
                rowCol[i] = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
                if (i > 0)
                {
                    if (rowCol[i].Count() == rowCol[i - 1].Count())
                    {
                        for (int j = 0; j < rowCol[i].Count(); j++)
                        {
                            rowCol[i][j] *= 2;
                            rowCol[i - 1][j] *= 2;
                        }
                    }
                    else
                    {
                        for (int j = 0; j < rowCol[i].Count(); j++)
                        {
                            rowCol[i][j] /= 2;
                        }
                        for (int j = 0; j < rowCol[i - 1].Count(); j++)
                        {
                            rowCol[i - 1][j] /= 2;
                        }
                    }
                }
            }
            string[] command = Console.ReadLine().Split();

            while (command[0].ToLower() != "end")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (0 <= row && row < rowCol.Length
                 && 0 <= col && col < rowCol[row].Length)
                {
                    if (command[0] == "Add")
                    {
                        rowCol[row][col] += value;
                    }
                    else if (command[0] == "Subtract")
                    {
                        rowCol[row][col] -= value;
                    }
                }
                command = Console.ReadLine().Split();
            }
            Array.ForEach(rowCol, x => Console.WriteLine(string.Join(" ", x)));
        }
    }
}
