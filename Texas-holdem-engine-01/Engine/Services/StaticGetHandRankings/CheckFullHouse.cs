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
            foreach (var item in result)
            {
                if (item.Count() == 2)
                {

                    pair = true;
                }

                if (item.Count() == 3)
                {
                    threeOfKind = true;
                }

                if (pair && threeOfKind)
                {
                    return HandRankings.FullHouse;
                }
            }
            return 0;
        }
    }
}
