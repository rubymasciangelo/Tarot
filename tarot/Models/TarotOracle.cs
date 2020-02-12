using System;
using System.Collections.Generic;
using System.Linq;

namespace tarot.Models
{
    public class TarotOracle : Oracle
    {
        private List<Card> hand = new List<Card>();
        public List<Card> Hand { get { return hand; } }
    }
}