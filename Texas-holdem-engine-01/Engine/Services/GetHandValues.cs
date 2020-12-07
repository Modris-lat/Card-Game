using System.Collections.Generic;
using System.Linq;
using Engine.Interfaces;
using Engine.Models;
using Engine.Rankings;
using Engine.Services.StaticGetHandRankings;
using Engine.Services.StaticGetHandRankings.CheckEqualRanks;

namespace Engine.Services
{
    public class GetHandValues: IGetHandValues
    {
        public IEnumerable<Hand> Calculate(List<Card> table, List<Hand> hands)
        {
            for (int i = 0; i < hands.Count; i++)
            {
                var handAndTableCards = new List<Card>(table);
                handAndTableCards.AddRange(hands[i].Cards);
                CheckEqualRanksResult equalRanksResult = CheckEqualRanks.CheckForEqualRanks(handAndTableCards);
                hands[i].HandStrength = CheckRoyalFlush.RoyalFlush(handAndTableCards);
                hands[i].HandValueType = "RoyalFlush";
                if (hands[i].HandStrength == 0)
                {
                    hands[i].HandStrength = CheckStraightFlush.GetResult(handAndTableCards);
                    hands[i].HandValueType = "StraighFlush";
                }

                if (hands[i].HandStrength == 0 && equalRanksResult.FourOfKind)
                {
                    hands[i].HandStrength = equalRanksResult.FourOfKindValue;
                    hands[i].HandValueType = "FourKind";
                }

                if (hands[i].HandStrength == 0)
                {
                    hands[i].HandStrength = CheckFullHouse.GetResult(handAndTableCards);
                    hands[i].HandValueType = "FullHouse";
                }
                    
                if (hands[i].HandStrength == 0)
                {
                    var flush = CheckFlush.CheckIfFlush(handAndTableCards);
                    if (flush.Item1 != ' ')
                    {
                        hands[i].HandStrength = HandRankings.Flush + flush.Item2;
                        hands[i].HandValueType = "Flush";
                    }
                }

                if (hands[i].HandStrength == 0)
                {
                    hands[i].HandStrength = CheckStraight.CheckIfStraight(handAndTableCards);
                    hands[i].HandValueType = "Straight";
                }

                if (hands[i].HandStrength == 0 && equalRanksResult.ThreeOfKind)
                {
                    hands[i].HandStrength = equalRanksResult.ThreeOfKindValue;
                    hands[i].HandValueType = "ThreeOfKind";
                }

                if (hands[i].HandStrength == 0 && equalRanksResult.PairCount >= 1)
                {
                    hands[i].HandStrength = equalRanksResult.PairValue;
                    if (equalRanksResult.PairCount == 1)
                    {
                        hands[i].HandValueType = "Pair";
                    }

                    if (equalRanksResult.PairCount >= 1)
                    {
                        hands[i].HandValueType = "TwoPair";
                    }
                }

                if (hands[i].HandStrength == 0)
                {
                    hands[i].HandStrength = hands[i].Cards.Max(c => c.CardValue);
                    hands[i].HandValueType = "HighCard";
                }
            }

            var handsOrderByValue = hands.OrderByDescending(h => h.HandStrength);
            return handsOrderByValue;
        }
    }
}
