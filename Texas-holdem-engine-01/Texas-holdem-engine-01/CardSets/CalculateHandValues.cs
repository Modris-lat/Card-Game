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
        public IHand CalculateCardsValues(IList<Card> table, List<IHand> hands)
        {
            int strongest = 0;
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
                if (resultThreeFourKind.FourKind)
                {
                    item.FourOfKind = true;
                    item.HighCard = resultThreeFourKind.FourKindValue;
                }
                else if (resultThreeFourKind.ThreeKind)
                {
                    item.ThreeOfKind = true;
                    item.HighCard = resultThreeFourKind.ThreeKindValue;
                }
                item.Flush = CheckFlush.CheckIfFlush(hand);
                
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
                if (strength > strongest)
                {
                    strongest = strength;
                    strongestHand = item;
                }
                
            }

            return strongestHand;
        }
    }
}
