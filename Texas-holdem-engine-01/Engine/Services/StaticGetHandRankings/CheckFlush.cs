using System.Collections.Generic;
using System.Linq;
using Engine.Models;

namespace Engine.Services.StaticGetHandRankings
{
    public static class CheckFlush
    {
        public static char CheckIfFlush(List<Card> list)
        {
            var hList = list.Where(card => card.Suit == 'h');
            var sList = list.Where(card => card.Suit == 's');
            var dList = list.Where(card => card.Suit == 'd');
            var cList = list.Where(card => card.Suit == 'c');
            if (sList.Count() >= 5)
            {
                return 's';
            }
            if (hList.Count() >= 5)
            {
                return 'h';
            }
            if (cList.Count() >= 5)
            {
                return 'c';
            }
            if (dList.Count() >= 5)
            {
                return 'd';
            }
            return ' ';
        }
    }
}
