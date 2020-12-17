using System.Collections.Generic;
using System.Linq;
using Engine.Models;
using Engine.Rankings;

namespace Engine.Services.StaticGetHandRankings.CheckEqualRanks
{
    public class CheckEqualRanks
    {
        public static CheckEqualRanksResult CheckForEqualRanks(List<Card> cards)
        {
            var result = new CheckEqualRanksResult();
            var groups = cards.GroupBy(c => c.CardValue);
            foreach (var group in groups)
            {
                if (group.Count() == 4)
                {
                    result.FourOfKind = true;
                    result.FourOfKindValue = group.Key + HandRankings.FourOfAKind;
                }

                if (group.Count() == 3)
                {
                    result.ThreeOfKind = true;
                    if(group.Key > result.ThreeOfKindValue) 
                        result.ThreeOfKindValue = group.Key + HandRankings.ThreeOfKind;
                }
                if (group.Count() == 2)
                {
                    result.PairCount++;
                    if (group.Key > result.PairValue)
                    {
                        result.PairValue = group.Key;
                    }
                }
            }
            if (result.PairCount == 1) result.PairValue += HandRankings.Pair;

            if (result.PairCount >= 2) result.PairValue += HandRankings.TwoPair;
            return result;
        }
    }
}
