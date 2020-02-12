using System;
using System.Collections.Generic;
using System.Linq;

namespace tarot.Models
{
    public class Oracle
    {
        public Deck Deck { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards)
        }
    }
}