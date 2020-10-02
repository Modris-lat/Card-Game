using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texas_holdem_engine_01.Interfaces;

namespace Texas_holdem_engine_01
{
    public class Hand: IHand
    {
        public int Id { get; set; }
        List<Card> Cards;
        public bool RoyalFlush { get; set; }
        public bool StraightFl { get; set; }
        public bool FullHouse { get; set; }
        public bool Flush { get; set; }
        public bool Straight { get; set; }
        public bool ThreeOfKind { get; set; }
        public bool TwoPair { get; set; }
        public bool Pair { get; set; }
        public int HighCard { get; set; }

        public Hand()
        {
            Cards = new List<Card>(){};
        }

        public Hand(int id, List<Card> cards)
        {
            Id = id;
            Cards = cards;
        }

        public List<Card> GetCards()
        {
            return Cards;
        }
    }
}
