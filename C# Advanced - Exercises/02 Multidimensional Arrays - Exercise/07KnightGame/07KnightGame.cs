using System;
using System.Linq;
using System.Collections.Generic;

namespace _07KnightGame
{
    class Program
    {
        static void Main()
        {
            int sizeBoard = int.Parse(Console.ReadLine());
            char[,] board = new char[sizeBoard, sizeBoard];

            for (int i = 0; i < sizeBoard; i++)
            {
                string row = Console.ReadLine().Trim();
                for (int j = 0; j < row.Length; j++)
                {
                    board[i, j] = row[j];
                }
            }
            bool flag = true;
            int counter = 0;

            while (flag)
            {
                var attacks = new Dictionary<int, List<int[]>>();

                for (int row = 0; row < sizeBoard; row++)
                {
                    for (int col = 0; col < sizeBoard; col++)
                    {
                        if (board[row, col] == 'K')
                        {
                            int numAttacks = 0;
                            for (int i = -2; i <= 2; i++)
                            {
                                for (int j = 2; j >= -2; j--)
                                {
                                    if (Math.Abs(i) != Math.Abs(j)
                                          && i != 0 && j != 0)
                                    {
                                        if (0 <= row + i && row + i < sizeBoard
                                         && 0 <= col + j && col + j < sizeBoard
                                         && board[row + i, col + j] == 'K')
                                        {
                                            numAttacks++;
                                        }
                                    }
                                }
                            }
                            if (numAttacks > 0)
                            {
                                int[] coordinates = { row, col };
                                var listCoordinates = new List<int[]>();

                                if (!attacks.ContainsKey(numAttacks))
                                {
                                    attacks.Add(numAttacks, listCoordinates);
                                }
                                attacks[numAttacks].Add(coordinates);
                            }
                        }
                    }
                }
                if (attacks.Count > 0)
                {
                    int forRemov = attacks.Keys.Max();
                    int rowRemov = attacks[forRemov][0][0];
                    int colRemov = attacks[forRemov][0][1];

                    board[rowRemov, colRemov] = 'O';
                    attacks[forRemov].RemoveAt(0);

                    if (attacks[forRemov].Count == 0)
                    {
                        attacks.Remove(forRemov);
                    }
                    counter++;
                }
                if (attacks.Count == 0)
                {
                    flag = false;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
