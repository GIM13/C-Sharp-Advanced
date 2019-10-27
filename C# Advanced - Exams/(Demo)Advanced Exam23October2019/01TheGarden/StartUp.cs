using System;

namespace _01TheGarden
{
    public class StartUp
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            var garden = new string[num][];

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split();

                garden[i] = input;
            }

            var carrots = 0;
            var potatos = 0;
            var lettuce = 0;
            var harmed = 0;

            var command = Console.ReadLine();

            while (command != "End of Harvest")
            {
                if (command.StartsWith("Harvest"))
                {
                    int row = int.Parse(command[8].ToString());
                    int col = int.Parse(command[10].ToString());

                    if (0 <= row && row < garden.GetLength(0)
                     && 0 <= col && col < garden[row].Length)
                    {
                        if (garden[row][col] != " ")
                        {
                            if (garden[row][col] == "L")
                            {
                                lettuce++;
                            }
                            else if (garden[row][col] == "P")
                            {
                                potatos++;
                            }
                            else if (garden[row][col] == "C")
                            {
                                carrots++;
                            }

                            garden[row][col] = " ";
                        }
                    }
                }
                else if (command.StartsWith("Mole"))
                {
                    int row = int.Parse(command[5].ToString());
                    int col = int.Parse(command[7].ToString());

                    if (0 <= row && row < garden.GetLength(0)
                     && 0 <= col && col < garden[row].Length)
                    {
                        if (command.EndsWith("up"))
                        {
                            for (int i = row; i >= 0; i -= 2)
                            {
                                if (garden[i][col] != " ")
                                {
                                    harmed++;

                                    garden[i][col] = " ";
                                }
                            }
                        }
                        else if (command.EndsWith("down"))
                        {
                            for (int i = row; i < garden.GetLength(0); i += 2)
                            {
                                if (garden[i][col] != " ")
                                {
                                    harmed++;

                                    garden[i][col] = " ";
                                }
                            }
                        }
                        else if (command.EndsWith("left"))
                        {
                            for (int i = col; i >= 0; i -= 2)
                            {
                                if (garden[row][i] != " ")
                                {
                                    harmed++;

                                    garden[row][i] = " ";
                                }
                            }
                        }
                        else if (command.EndsWith("right"))
                        {
                            for (int i = col; i < garden[row].Length; i += 2)
                            {
                                if (garden[row][i] != " ")
                                {
                                    harmed++;

                                    garden[row][i] = " ";
                                }
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < garden.GetLength(0); i++)
            {
                for (int j = 0; j < garden[i].Length; j++)
                {
                    Console.Write(garden[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Carrots: {carrots}");
            Console.WriteLine($"Potatoes: {potatos}");
            Console.WriteLine($"Lettuce: {lettuce}");
            Console.WriteLine($"Harmed vegetables: {harmed}");
        }
    }
}
