using System;

namespace ClassDeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            DeckOfCards masterDeck = new DeckOfCards();
            string[] input = Console.ReadLine().Split();

            while (input[0] != "End")
            {
                switch (input[0])
                {
                    case "Add":
                        masterDeck.Add(new Card(input[1], input[2]));
                        break;
                    case "Print":
                        masterDeck.Print();
                        break;
                    case "Get":
                        masterDeck.GetAllCards();
                        break;
                    case "Randomize":
                        masterDeck.Shuffle();
                        break;
                    case "Clear":
                        masterDeck.Clear();
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine().Split();
            }
        }
    }
}
