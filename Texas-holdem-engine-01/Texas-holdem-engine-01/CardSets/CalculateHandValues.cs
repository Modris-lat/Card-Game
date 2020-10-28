using System.Collections.Generic;
using System.Linq;
using Texas_holdem_engine_01.Interfaces;
using Texas_holdem_engine_01.StaticGetValues;
using Texas_holdem_engine_01.StaticGetValues.CheckEqualRanks;
using Texas_holdem_engine_01.StaticGetValues.CheckFlush;
using Texas_holdem_engine_01.StaticGetValues.CheckStraight;
using Texas_holdem_engine_01.StaticGetValues.CheckThreeAndFourKind;

namespace Texas_holdem_engine_01.CardSets
{
    public class CalculateHandValues: ICalculateHandValues
    {
        public IHand CalculateCardsValues(IList<Card> table, List<IHand> hands)
        {
            int strongest = 0;
            IHand strongestHand = new Hand();
            //var HighestCard = hands.Max(hand => hand.GetHighestCard());
            foreach (var hand in hands)
            {
                var tableCards = table.ToList();
                tableCards.Add(hand.GetCards()[0]);
                tableCards.Add(hand.GetCards()[1]);
                var resultEqualRanks = CheckEqualRanks.CheckForEqualRanks(tableCards);
                int pairs = resultEqualRanks.PairCount;
                if (pairs == 1)
                {
                    hand.Pair = true;
                    hand.Strength += resultEqualRanks.PairValue;
                }
                else if (pairs == 2)
                {
                    hand.TwoPair = true;
                    hand.Strength = resultEqualRanks.PairValue;
                }

                if (resultEqualRanks.ThreeOfKind)
                {
                    hand.ThreeOfKind = true;
                    hand.Strength += resultEqualRanks.ThreeOfKindValue;
                }
                //var resultThreeFourKind = CheckThreeAndFourKind.ThreeAndFourOfKind(hand);
                //if (resultThreeFourKind.FourKind)
                //{
                //    item.FourOfKind = true;
                //    item.Strength = resultThreeFourKind.FourKindValue;
                //}
                //else if (resultThreeFourKind.ThreeKind)
                //{
                //    item.ThreeOfKind = true;
                //    item.Strength = resultThreeFourKind.ThreeKindValue;
                //}
                //var resultStraight = CheckStraight.CheckIfStraight(hand);
                //if (resultStraight.Straight)
                //{
                //    item.Straight = true;
                //    item.Strength = resultStraight.StraightValue;
                //}
                //var resultFlush = CheckFlush.CheckIfFlush(hand);
                //if (resultFlush.Flush)
                //{
                //    item.Flush = resultFlush.FlushSuit;
                //}
                //if (item.ThreeOfKind && item.Pair)
                //{
                //    item.FullHouse = true;
                //    item.Strength = resultThreeFourKind.FourKindValue + resultPairs.PairValue;
                //}

                //if (item.Flush != ' ' && item.Straight)
                //{
                //    item.RoyalFlush = CheckRoyalFlush.RoyalFlush(hand, item.Flush);
                //    item.StraightFl = CheckStraightFlush.StraightFlush(hand, item.Flush);
                //}

                int strength = hand.GetStrengthOfHand();
                if (strength > strongest)
                {
                    strongest = strength;
                    strongestHand = hand;
                }
                else if (strength == strongest)
                {
                    if (hand.GetHighestCard() > strongestHand.GetHighestCard() && hand.Pair)
                    {
                        strongestHand = hand;
                    }
                    else if (hand.GetHighestCard() > strongestHand.GetHighestCard() && hand.ThreeOfKind)
                    {
                        strongestHand = hand;
                    }
                }
            }

            
            return strongestHand;
        }
    }
}
