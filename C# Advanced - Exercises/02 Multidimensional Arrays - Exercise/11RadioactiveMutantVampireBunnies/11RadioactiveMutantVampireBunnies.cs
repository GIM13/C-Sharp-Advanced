using System;
using System.Linq;

namespace _11RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main()
        {
            int[] sizes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            char[,] lair = new char[sizes[0], sizes[1]];

            int rowIndexPlayer = -1;
            int colIndexPlayer = -1;

            for (int row = 0; row < lair.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    lair[row, col] = input[col];
                    if (input[col] == 'P')
                    {
                        rowIndexPlayer = row;
                        colIndexPlayer = col;
                    }
                }
            }
            string moves = Console.ReadLine();
            string result = string.Empty;

            foreach (var move in moves)
            {
                lair[rowIndexPlayer, colIndexPlayer] = '.';

                if (move == 'R' && colIndexPlayer + 1 < lair.GetLength(1))
                {
                    colIndexPlayer++;
                }
                else if (move == 'L' && colIndexPlayer - 1 >= 0)
                {
                    colIndexPlayer--;
                }
                else if (move == 'U' && rowIndexPlayer - 1 >= 0)
                {
                    rowIndexPlayer--;
                }
                else if (move == 'D' && rowIndexPlayer + 1 < lair.GetLength(0))
                {
                    rowIndexPlayer++;
                }
                else
                {
                    result = "won";
                }

                if (lair[rowIndexPlayer, colIndexPlayer] == 'B')
                {
                    result = "dead";
                }

                for (int row = 0; row < lair.GetLength(0); row++)
                {
                    for (int col = 0; col < lair.GetLength(1); col++)
                    {
                        if (lair[row,col] == 'B')
                        {
                            if (row + 1 < lair.GetLength(0)
                             && lair[row + 1, col] != 'B')
                            {
                                lair[row + 1, col] = 'b';
                            }
                            if (0 <= row - 1
                             && lair[row - 1, col] != 'B')
                            {
                                lair[row - 1, col] = 'b';
                            }
                            if (col + 1 < lair.GetLength(1)
                             && lair[row , col + 1] != 'B')
                            {
                                lair[row, col + 1] = 'b';
                            }
                            if (0 <= col - 1
                             && lair[row , col - 1] != 'B')
                            {
                                lair[row, col - 1] = 'b';
                            }
                        }
                    }
                }
                for (int row = 0; row < lair.GetLength(0); row++)
                {
                    for (int col = 0; col < lair.GetLength(1); col++)
                    {
                        if (lair[row, col] == 'b')
                        {
                            lair[row, col] = 'B';
                        }
                    }
                }
                if (lair[rowIndexPlayer, colIndexPlayer] == 'B'
                    && result != "won")
                {
                    result = "dead";
                }
                if (result != string.Empty)
                {
                    break;
                }
            }
            for (int row = 0; row < lair.GetLength(0); row++)
            {
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    Console.Write(lair[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"{result}: {rowIndexPlayer} {colIndexPlayer}");
        }
    }
}
