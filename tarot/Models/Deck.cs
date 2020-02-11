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
                    card.Face = (Face)i;
                    card.Minor = (Minor)j;
                    Cards.Add(card);
                }
            }

            for(int k = 0; k <22; k++)
            {
                for (int l = 0; l < 1; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)k;
                    card.Major = (Major)l;
                }
            }
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
        }
    }
}
