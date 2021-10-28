using System;
using System.Collections.Generic;

namespace ClassCard
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> deckOfCards = new List<Card>
            { 
                new Card("A", "Spades"), 
                new Card("J", "Diamonds"),
                new Card("Q", "Clubs"),
                new Card("10", "Hearts")
            };

            foreach (Card card in deckOfCards)
                card.Print();
        }
    }
}
