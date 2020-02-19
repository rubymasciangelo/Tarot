using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarot_Test
{
    public class Subject
    {
        public Subject()
        {
            Hand = new List<Card>();
        }
        private List<Card> hand = new List<Card>();
        public List<Card> Hand { get { return hand; } }

    }
}