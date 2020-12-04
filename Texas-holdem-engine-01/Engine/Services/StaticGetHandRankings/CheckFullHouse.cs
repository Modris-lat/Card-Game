using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Rankings;

namespace Engine.Services.StaticGetHandRankings
{
    public static class CheckFullHouse
    {
        public static int GetResult(List<Card> cards)
        {
            var result = cards.GroupBy(c => c.Rank);
            var pair = false;
            var threeOfKind = false;
            var highestCard = 0;
            foreach (var group in result)
            {
                if (group.Count() == 2)
                {
                    pair = true;
                    var value = group.ToList()[0].CardValue;
                    if (value > highestCard) highestCard = value;
                }
                if (group.Count() == 3)
                {
                    threeOfKind = true;
                    var value = group.ToList()[0].CardValue;
                    if (value > highestCard) highestCard = value;
                }

                if (pair && threeOfKind) return HandRankings.FullHouse + highestCard;
            }
            return 0;
        }
    }
}
