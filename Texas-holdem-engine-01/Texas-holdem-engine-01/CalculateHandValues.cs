using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texas_holdem_engine_01.Interfaces;
using Texas_holdem_engine_01.Static;

namespace Texas_holdem_engine_01
{
    public class CalculateHandValues: ICalculateHandValues
    {
        public (IHand, List<IHand>) CalculateCardsValues(IList<Card> table, List<IHand> hands)
        {
            int strongest = 0;
            var listOfEquals = new List<IHand>() { };
            IHand strongestHand = new Hand();
            foreach (var item in hands)
            {
                var hand = new List<Card>(table);
                hand.Add(item.GetCards()[0]);
                hand.Add(item.GetCards()[1]);
                item.HighCard = CheckHighCard.HighestCard(hand);
                var resultPairs = CheckPairs.CheckForPair(hand);
                int pairs = resultPairs.PairCount;
                if (resultPairs.PairValue > 0)
                {
                    item.HighCard += resultPairs.PairValue;
                }
                if (pairs == 1)
                {
                    item.Pair = true;
                }
                else if (pairs == 2)
                {
                    item.TwoPair = true;
                }
                var resultThreeFourKind = CheckThreeAndFourKind.ThreeAndFourOfKind(hand);
                int threeOfKind = resultThreeFourKind.Item1;
                int fourOfKind = resultThreeFourKind.Item2;
                if (threeOfKind == 1)
                {
                    item.ThreeOfKind = true;
                }
                item.Flush = CheckFlush.CheckIfFlush(hand);
                if (fourOfKind == 1)
                {
                    item.FourOfKind = true;
                }
                item.Straight = CheckStraight.CheckIfStraight(hand);
                if (item.ThreeOfKind && item.Pair)
                {
                    item.FullHouse = true;
                }

                if (item.Flush != ' ' && item.Straight)
                {
                    item.RoyalFlush = CheckRoyalFlush.RoyalFlush(hand, item.Flush);
                    item.StraightFl = CheckStraightFlush.StraightFlush(hand, item.Flush);
                }

                int strength = item.GetStrengthOfHand();
                if (strength == strongest)
                {
                    listOfEquals.Add(strongestHand);
                    listOfEquals.Add(item);
                }
                if (strength > strongest)
                {
                    strongest = strength;
                    strongestHand = item;
                }
                
            }

            return (strongestHand, listOfEquals);
        }
    }
}
