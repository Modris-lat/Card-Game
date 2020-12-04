using System.Collections.Generic;
using System.Linq;
using Engine.Models;

namespace Engine.Services.StaticGetHandRankings
{
    public static class CheckFlush
    {
        public static (char, int) CheckIfFlush(List<Card> list)
        {
            var groups = list.GroupBy(c => c.Suit);
            foreach (var group in groups)
            {
                if (group.Count() == 5)
                {
                    var highestValue = group.Max(c => c.CardValue);
                    return (group.Key, highestValue);
                }
            }
            return (' ', 0);
        }
    }
}
