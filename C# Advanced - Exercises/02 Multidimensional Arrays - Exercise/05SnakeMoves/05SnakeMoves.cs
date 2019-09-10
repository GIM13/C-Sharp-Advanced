using System;
using System.Collections.Generic;
using System.Linq;

namespace _05SnakeMoves
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
            var matrix = new char[rows, columns];

            char[] text = Console.ReadLine().ToCharArray();
            var snake = new Queue<char>();
            Array.ForEach(text, x => snake.Enqueue(x));

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = snake.Peek();
                    snake.Enqueue(snake.Dequeue());
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
