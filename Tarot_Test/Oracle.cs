using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Tarot_Test
{
    public class Oracle
    {
        public Deck Deck { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards);
        }
    }
}