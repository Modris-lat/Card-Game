using System.Collections.Generic;
using System.Linq;
using Engine.Models;
using Engine.Rankings;

namespace Engine.Services.StaticGetHandRankings
{
    public class CheckRoyalFlush
    {
        public static int RoyalFlush(List<Card> cards)
        {
            var flushSuit = CheckFlush.CheckIfFlush(cards);
            var royalFlush = cards.Where(card => card.Rank == 'T' && card.Suit == flushSuit.Item1 ||
                                              card.Rank == 'J' && card.Suit == flushSuit.Item1 ||
                                              card.Rank == 'Q' && card.Suit == flushSuit.Item1 ||
                                              card.Rank == 'K' && card.Suit == flushSuit.Item1 ||
                                              card.Rank == 'A' && card.Suit == flushSuit.Item1);
            if (royalFlush.Count() >= 5)
            {
                return HandRankings.RoyalFlush;
            }
            
            return 0;
        }
    }
}
