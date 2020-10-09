using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_holdem_engine_01.Static
{
    public class CheckRoyalFlush
    {
        public static bool RoyalFlush(List<Card> cards, char flushSuit)
        {
            var royalFlush = cards.Where(card => card.Rank == 'T' && card.Suit == flushSuit ||
                                              card.Rank == 'J' && card.Suit == flushSuit ||
                                              card.Rank == 'Q' && card.Suit == flushSuit ||
                                              card.Rank == 'K' && card.Suit == flushSuit ||
                                              card.Rank == 'A' && card.Suit == flushSuit);
            if (royalFlush.Count() >= 5)
            {
                return true;
            }
            
            return false;
        }
    }
}
