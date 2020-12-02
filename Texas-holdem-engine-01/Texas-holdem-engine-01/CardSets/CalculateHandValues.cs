using System.Collections.Generic;
using System.Linq;
using Texas_holdem_engine_01.Interfaces;
using Texas_holdem_engine_01.StaticGetValues;
using Texas_holdem_engine_01.StaticGetValues.CheckEqualRanks;
using Texas_holdem_engine_01.StaticGetValues.CheckFlush;
using Texas_holdem_engine_01.StaticGetValues.CheckStraight;

namespace Texas_holdem_engine_01.CardSets
{
    public class CalculateHandValues: ICalculateHandValues
    {
        public IHand CalculateCardsValues(IList<Card> table, List<IHand> hands)
        {
            int strongest = 0;
            IHand strongestHand = new Hand();
            var highestCard = hands.Max(hand => hand.GetHighestCard());
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

                if (resultEqualRanks.ThreeOfKind && pairs == 1)
                {
                    hand.FullHouse = true;
                    hand.Strength = resultEqualRanks.PairValue + resultEqualRanks.ThreeOfKindValue;
                }

                if (resultEqualRanks.FourOfKind)
                {
                    hand.FourOfKind = true;
                    hand.Strength += resultEqualRanks.FourOfKindValue;
                }
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
