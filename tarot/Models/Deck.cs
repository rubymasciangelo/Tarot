using System;
using System.Collections.Generic;
using System.Linq;

namespace tarot.Models
{
    public class Deck
    {
        Public Deck()
        {
            Cards = new List<Card>();

            for(int i = 0; i < 14; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    Card.Face = (Face)i;
                    Card.Suit = (Suit)i;
                    Cards.Add(card);
                }
            }
        }
    }
}
