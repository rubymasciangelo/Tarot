using System;
using System.Collections.Generic;
using System.Linq;

namespace Tarot_Test
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();

            for (int i = 0; i < 14; i++)// for minor arcana
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.FaceMinor = (FaceMinor)i;
                    card.Minor = (Minor)j;
                    Cards.Add(card);
                }
            }

            for (int k = 0; k < 22; k++)// for major arcana
            {
                for (int l = 0; l < 1; j++)
                {
                    Card card = new Card();
                    card.FaceMajor = (FaceMajor)k;
                    card.Major = (Major)l;
                }
            }
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)// should this go in controller?
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
            foreach (Card card in Cards)
            {
                var reverse = new Random();
                var isReverse = reverse.Next(2) == 1;// 0 = false 1 = true
            }
        }
    }
}
