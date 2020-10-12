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
        public int Strength { get; set; }
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
            Strength = HighCard;
            if (TwoPair)
            {
                Strength = 20 + HighCard;
            }
            else if (Pair)
            {
                Strength = 15 + HighCard;
            }

            if (ThreeOfKind)
            {
                Strength = 25 + HighCard;
            }

            if (Straight)
            {
                Strength = 30 + HighCard;
            }

            if (Flush == 's' || Flush == 'h' || Flush == 'c' || Flush == 'd')
            {
                Strength = 35 + HighCard;
            }

            if (FullHouse)
            {
                Strength = 40 + HighCard;
            }

            if (FourOfKind)
            {
                Strength = 45 + HighCard;
            }

            if (StraightFl)
            {
                Strength = 60 + HighCard;
            }

            if (RoyalFlush)
            {
                Strength = 100;
            }
            return Strength;
        }

        public List<Card> GetCards()
        {
            return Cards;
        }
    }
}
