using System.Collections.Generic;
using System.IO;

namespace _02LineNumbers
{
    class Program
    {
        static void Main()
        {
            var reader = File.ReadAllLines("text.txt");

            int lineCounter = 1;

            List<string> newText = new List<string>();

            foreach (var line in reader)
            {
                int simbolCounter = 0;
                int punctuationCounter = 0;

                foreach (var charr in line)
                {
                    if (char.IsPunctuation(charr))
                    {
                        punctuationCounter++;
                    }
                    else if (char.IsLetter(charr))
                    {
                        simbolCounter++;
                    }
                }

                string newLine = $"Line {lineCounter}: {line}({simbolCounter})({punctuationCounter})";

                newText.Add(newLine);

                lineCounter++;
            }

            File.WriteAllLines("output.txt", newText);
        }
    }
}
