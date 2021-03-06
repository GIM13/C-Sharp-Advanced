﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03WordCount
{
    class Program
    {
        static void Main()
        {
            string[] listWords = File.ReadAllLines("words.txt");

            char[] separator = { '-', ',', '.', '!', '?', ' ' };
            string[] listText = File.ReadAllText("text.txt")
                .Split(separator)
                .ToArray();

            var countWords = new Dictionary<string, int>();

            foreach (var word in listWords)
            {
                int counter = 0;

                foreach (var item in listText)
                {
                    if (word.ToLower() == item.ToLower())
                    {
                        counter++;
                    }
                }

                countWords.Add(word, counter);
            }

            countWords = countWords
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, y => y.Value);

            File.WriteAllText("actualResults.txt","");

            int count = 1;
            foreach (var item in countWords)
            {
                if (count == countWords.Count)
                {
                    File.AppendAllText("actualResults.txt", $"{item.Key} - {item.Value}");
                }
                else
                {
                    File.AppendAllText("actualResults.txt", $"{item.Key} - {item.Value}" + Environment.NewLine);
                }
                count++;
            }

            bool result = true;

            for (int i = 0; i < listWords.Length; i++)
            {
                if (File.ReadAllLines("actualResults.txt")[i] != File.ReadAllLines("expectedResult.txt")[i])
                {
                    result = false;
                }
            }
            Console.WriteLine(result);
        }
    }
}
