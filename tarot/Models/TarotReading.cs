using System;
using System.Collections.Generic;
using System.Linq;

namespace tarot.Models
{
    public class TarotReading : Reading
    {
        public TarotReading Oracle { get; set; }
        public override void Divine()
        {
            Oracle = new TarotOracle();
            foreach (Subject subject in Subjects)
            {
                subject.Hand = new List<Card>();
            }
            Oracle.Deck = new Deck();
            Oracle.Deck.Shuffle();
        }
    }
}