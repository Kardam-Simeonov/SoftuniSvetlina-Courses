using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordsFilePath = @"..\..\..\Files\words.txt";
            string textFilePath = @"..\..\..\Files\text.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";
            CalculateWordCounts(wordsFilePath, textFilePath, outputFilePath);
        }
        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            using (var readerWords = new StreamReader(wordsFilePath))
            {
                List<string> words = readerWords
                    .ReadToEnd()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var wordCounts = new Dictionary<string, int>();

                using (var readerText = new StreamReader(wordsFilePath))
                {
                    string[] text = readerWords
                        .ReadToEnd()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    foreach (var word in words)
                    {
                        if (words.Contains(word))
                        {
                            if (!wordCounts.ContainsKey(word))
                                wordCounts[word] = 0;
                            
                            wordCounts[word]++;
                        }
                    }
                }
                using (var writer = new StreamWriter(outputFilePath))
                {
                    foreach (var wordValuePair in wordCounts.OrderBy(x => x.Value))
                        writer.WriteLine($"{wordValuePair.Key} - {wordValuePair.Value}");
                }
            }
        }
    }
}
