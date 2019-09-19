using System;
using System.Linq;

namespace _10Miner
{
    class Program
    {
        static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            string[] commandsMove = Console.ReadLine().Split();
            string[,] field = new string[fieldSize, fieldSize];

            int coal = 0;
            int positionRow = -1;
            int positionCol = -1;

            for (int row = 0; row < fieldSize; row++)
            {
                string[] inputField = Console.ReadLine().Split().ToArray();

                for (int col = 0; col < fieldSize; col++)
                {
                    field[row, col] = inputField[col];

                    if (inputField[col] == "c")
                    {
                        coal++;
                    }
                    if (inputField[col] == "s")
                    {
                        positionRow = row;
                        positionCol = col;
                    }
                }
            }
            bool flag = true;

            foreach (var command in commandsMove)
            {
                if (command == "up" && positionRow - 1 >= 0)
                {
                    positionRow--;
                }
                else if (command == "down" && positionRow + 1 < fieldSize)
                {
                    positionRow++;
                }
                else if (command == "right" && positionCol + 1 < fieldSize)
                {
                    positionCol++;
                }
                else if (command == "left" && positionCol - 1 >= 0)
                {
                    positionCol--;
                }
                else
                {
                    continue;
                }

                if (field[positionRow, positionCol] == "c")
                {
                    field[positionRow, positionCol] = "*";
                    coal--;
                    if (coal == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({positionRow}, {positionCol})");
                        flag = false;
                        break;
                    }
                }
                else if (field[positionRow, positionCol] == "e")
                {
                    Console.WriteLine($"Game over! ({positionRow}, {positionCol})");
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine($"{coal} coals left. ({positionRow}, {positionCol})");
            }
        }
    }
}
