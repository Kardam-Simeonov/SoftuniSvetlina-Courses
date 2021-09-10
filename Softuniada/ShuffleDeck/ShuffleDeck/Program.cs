using System;
using System.Collections.Generic;
using System.Linq;

namespace ShuffleDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());

            var cardDeck = new int[len];

            for (int i = 0; i < len; i++)
            {
                cardDeck[i] = i + 1;
            }

            int[] splitPoints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (cardDeck.Length > 2)
                foreach (var splitPoint in splitPoints)
                {
                    List<int> shuffledDeck = new List<int>(len);
                    int firstDeckIndex = 0;
                    int secondDeckIndex = splitPoint;

                    for (int i = 0; i < cardDeck.Length; i++)
                    {
                        if (i % 2 == 0 && firstDeckIndex < splitPoint)
                        {
                            shuffledDeck.Add(cardDeck[firstDeckIndex]);
                            firstDeckIndex++;
                        }
                        else
                        {
                            shuffledDeck.Add(cardDeck[secondDeckIndex]);
                            secondDeckIndex++;
                        }
                    }

                    shuffledDeck.CopyTo(cardDeck);
                }

            Console.WriteLine(String.Join(" ", cardDeck));
        }
    }
}
