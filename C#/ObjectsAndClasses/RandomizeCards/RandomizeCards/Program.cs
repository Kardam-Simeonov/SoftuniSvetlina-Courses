using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomizeCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<Card> deckOfCards = new List<Card>();

            string[] faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "J", "Q", "K" };
            string[] suites = { "Spades", "Diamonds", "Clubs", "Hearts" };

            foreach (string suite in suites)
                foreach (string face in faces)
                    deckOfCards.Add(new Card(face, suite));

            foreach (var card in deckOfCards.OrderBy(x => rand.Next()))
                card.Print();
        }
    }
}
