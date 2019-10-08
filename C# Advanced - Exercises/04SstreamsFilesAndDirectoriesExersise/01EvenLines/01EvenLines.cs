using System;
using System.Linq;
using System.IO;

namespace _01EvenLines
{
    class Program
    {
        static void Main()
        {
            char[] forReplacement = { '-', ',', '.', '!', '?' };

            using (var reader = new StreamReader("text.txt"))
            {
                int counter = 0;

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (counter % 2 == 0)
                    {
                        foreach (var simbol in forReplacement)
                        {
                            if (line.Contains(simbol))
                            {
                                line = line.Replace(simbol, '@');
                            }
                        }

                        string[] result = line.Split();

                        Console.WriteLine(string.Join(" ", result.Reverse()));
                    }

                    ++counter;
                }
            }
        }
    }
}