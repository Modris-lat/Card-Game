using System.Collections.Generic;
using System.Linq;
using Texas_holdem_engine_01.CardSets;

namespace Texas_holdem_engine_01.StaticGetValues
{
    public class CheckStraightFlush
    {
        public static bool StraightFlush(List<Card> cards, char flushSuit)
        {
            var royalFlush = cards.Where(card => card.Rank == '2' && card.Suit == flushSuit ||
                                                 card.Rank == '3' && card.Suit == flushSuit ||
                                                 card.Rank == '4' && card.Suit == flushSuit ||
                                                 card.Rank == '5' && card.Suit == flushSuit ||
                                                 card.Rank == '6' && card.Suit == flushSuit ||
                                                 card.Rank == '7' && card.Suit == flushSuit ||
                                                 card.Rank == '8' && card.Suit == flushSuit ||
                                                 card.Rank == '9' && card.Suit == flushSuit);
            if (royalFlush.Count() >= 5)
            {
                return true;
            }
            return false;
        }
    }
}
