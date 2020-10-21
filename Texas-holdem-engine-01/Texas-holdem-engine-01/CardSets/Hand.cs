using System.Collections.Generic;
using System.Linq;
using Texas_holdem_engine_01.Interfaces;

namespace Texas_holdem_engine_01.CardSets
{
    public class Hand: IHand
    {
        List<Card> Cards;
        public int Id { get; set; }
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
            if (RoyalFlush)
            {
                Strength = 100;
            }
            else if (StraightFl)
            {
                Strength += 70;
            }
            else if (FourOfKind)
            {
                Strength += 50;
            }
            else if (FullHouse)
            {
                Strength += 40;
            }
            else if (Flush == 's' || Flush == 'h' || Flush == 'c' || Flush == 'd')
            {
                Strength = 35;
            }
            else if (Straight)
            {
                Strength += 30;
            }
            else if (ThreeOfKind)
            {
                Strength += 25;
            }
            else if (TwoPair)
            {
                Strength = 20;
            }
            else if (Pair)
            {
                Strength += 15;
            }
            else
            {
                Strength = GetHighestCard();
            }
            return Strength;
        }

        public int GetHighestCard()
        {
            HighCard = Cards.Max(card => card.CardValue);
            return HighCard;
        }
        public List<Card> GetCards()
        {
            return Cards;
        }
    }
}
