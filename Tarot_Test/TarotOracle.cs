using System;
using System.Collections.Generic;
using System.Linq;

namespace Tarot_Test
{
    public class TarotOracle : Oracle
    {
        private List<Card> hand = new List<Card>();
        public List<Card> Hand { get { return hand; } }
    }
}