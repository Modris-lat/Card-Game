using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_holdem_engine_01.Static
{
    public class CheckHighCard
    {
        public static int HighestCard(List<Card> cards)
        {
            var sortedCards = cards.OrderBy(card => card.CardValue)
                .Select(card => card);
            var list = sortedCards.ToList();
            list.Reverse();
            var highest = list[0].CardValue;
            return highest;
        }
    }
}
