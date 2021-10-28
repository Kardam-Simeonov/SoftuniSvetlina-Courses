using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassDeckOfCards
{
    internal class DeckOfCards
    {
        List<Card> deckOfCards = new List<Card>();
        Random rand = new Random();

        public void Add(Card card)
        {
            deckOfCards.Add(card);
        }

        public void Print()
        {
            if (deckOfCards.Count != 0)
                deckOfCards[deckOfCards.Count - 1].Print();
        }

        public void GetAllCards()
        {
            deckOfCards.ForEach(x => x.Print());
        }

        public void Shuffle()
        {
            deckOfCards.OrderBy(x => rand.Next()).ToList().ForEach(x => x.Print());
        }

        public void Clear()
        {
            deckOfCards = new List<Card>();
        }
    }
}