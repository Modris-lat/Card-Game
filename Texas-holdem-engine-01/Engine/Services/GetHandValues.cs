using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Interfaces;
using Engine.Models;
using Engine.Rankings;
using Engine.Services.StaticGetHandRankings;
using Engine.Services.StaticGetHandRankings.StaticGetValues.CheckEqualRanks;

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
                if(hands[i].HandStrength == 0) 
                    hands[i].HandStrength = CheckStraightFlush.GetResult(handAndTableCards);
                if (hands[i].HandStrength == 0 && equalRanksResult.FourOfKind)
                    hands[i].HandStrength = HandRankings.FourOfAKind + equalRanksResult.FourOfKindValue;
                if (hands[i].HandStrength == 0)
                    hands[i].HandStrength = CheckFullHouse.GetResult(handAndTableCards);
                if (hands[i].HandStrength == 0)
                {
                    var flush = CheckFlush.CheckIfFlush(handAndTableCards);
                    if (flush != ' ')
                        hands[i].HandStrength = HandRankings.Flush;
                }
                    
            }

            var handsOrderByValue = hands.OrderByDescending(h => h.HandStrength);
            return handsOrderByValue;
        }
    }
}
