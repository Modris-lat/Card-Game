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
            char flushSuit = CheckFlush.CheckIfFlush(cards);
            var royalFlush = cards.Where(card => card.Rank == 'T' && card.Suit == flushSuit ||
                                              card.Rank == 'J' && card.Suit == flushSuit ||
                                              card.Rank == 'Q' && card.Suit == flushSuit ||
                                              card.Rank == 'K' && card.Suit == flushSuit ||
                                              card.Rank == 'A' && card.Suit == flushSuit);
            if (royalFlush.Count() >= 5)
            {
                return HandRankings.RoyalFlush;
            }
            
            return 0;
        }
    }
}
