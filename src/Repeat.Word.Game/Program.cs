using System;
using System.Collections.Generic;

namespace Repeat.Word.Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sentence = Console.ReadLine();

            var words = sentence.ToUpper().Split(' ');
            var wordCounts = new Dictionary<string, int>();
            var repeatedWordsFound = false;

            foreach (string word in words)
            {
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else
                {
                    wordCounts[word] = 1;
                }
            }

            foreach (var key in wordCounts)
            {
                if (key.Value > 1)
                {
                    repeatedWordsFound = true;
                }
            }

            var result = (repeatedWordsFound == false) ? "Yes" : "No";

            Console.WriteLine(result.ToLower());

            Console.Read();
        }
    }
}