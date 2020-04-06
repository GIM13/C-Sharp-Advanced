using System;

namespace _02BookWorm
{
    public class StartUp
    {
        public static void Main()
        {
            var initialString = Console.ReadLine();
            int sizeMatrix = int.Parse(Console.ReadLine());

            var matrix = new string[sizeMatrix, sizeMatrix];

            int row = 0;
            int col = 0;

            for (int i = 0; i < sizeMatrix; i++)
            {
                string input = Console.ReadLine();

                for (int j = 0; j < sizeMatrix; j++)
                {
                    matrix[i, j] = input[j].ToString();

                    if (input[j].ToString() == "P")
                    {
                        row = i;
                        col = j;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "up")
                {
                    if (row - 1 < 0)
                    {
                        initialString = initialString.Substring(0, initialString.Length - 1);
                    }
                    else
                    {
                        if (matrix[row - 1, col] != "-")
                        {
                            initialString = initialString + $"{matrix[row - 1, col]}";

                            matrix[row - 1, col] = "P";
                            matrix[row, col] = "-";
                            row--;
                        }
                        else
                        {
                            matrix[row - 1, col] = "P";
                            matrix[row, col] = "-";
                            row--;
                        }
                    }
                }
                else if (command == "down")
                {
                    if (row + 1 > sizeMatrix - 1)
                    {
                        initialString = initialString.Substring(0, initialString.Length - 1);
                    }
                    else
                    {
                        if (matrix[row + 1, col] != "-")
                        {
                            initialString = initialString + $"{matrix[row + 1, col]}";

                            matrix[row + 1, col] = "P";
                            matrix[row, col] = "-";
                            row++;
                        }
                        else
                        {
                            matrix[row + 1, col] = "P";
                            matrix[row, col] = "-";
                            row++;
                        }
                    }
                }
                else if (command == "left")
                {
                    if (col - 1 < 0)
                    {
                        initialString = initialString.Substring(0, initialString.Length - 1);
                    }
                    else
                    {
                        if (matrix[row , col - 1] != "-")
                        {
                            initialString = initialString + $"{matrix[row, col - 1]}";

                            matrix[row , col - 1] = "P";
                            matrix[row, col] = "-";
                            col--;
                        }
                        else
                        {
                            matrix[row, col - 1] = "P";
                            matrix[row, col] = "-";
                            col--;
                        }
                    }
                }
                else if (command == "right")
                {
                    if (col + 1 > sizeMatrix - 1)
                    {
                        initialString = initialString.Substring(0, initialString.Length -1);
                    }
                    else
                    {
                        if (matrix[row, col + 1] != "-")
                        {
                            initialString = initialString + $"{matrix[row, col + 1]}";

                            matrix[row, col + 1] = "P";
                            matrix[row, col] = "-";
                            col++;
                        }
                        else
                        {
                            matrix[row, col + 1] = "P";
                            matrix[row, col] = "-";
                            col++;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(initialString);

            for (int i = 0; i < sizeMatrix; i++)
            {
                for (int j = 0; j < sizeMatrix; j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
