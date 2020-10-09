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
        public bool FourOfKind { get; set; }
        public bool FullHouse { get; set; }
        public char Flush { get; set; }
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
        public int GetStrengthOfHand()
        {
            int totalStrength = HighCard;
            if (TwoPair)
            {
                totalStrength = 20 + HighCard;
            }
            else if (Pair)
            {
                totalStrength = 15 + HighCard;
            }

            if (ThreeOfKind)
            {
                totalStrength = 25 + HighCard;
            }

            if (Straight)
            {
                totalStrength = 30 + HighCard;
            }

            if (Flush == 's' || Flush == 'h' || Flush == 'c' || Flush == 'd')
            {
                totalStrength = 35 + HighCard;
            }

            if (FullHouse)
            {
                totalStrength = 40 + HighCard;
            }

            if (FourOfKind)
            {
                totalStrength = 45 + HighCard;
            }

            if (StraightFl)
            {
                totalStrength = 60 + HighCard;
            }

            if (RoyalFlush)
            {
                totalStrength = 100;
            }
            return totalStrength;
        }

        public List<Card> GetCards()
        {
            return Cards;
        }
    }
}
