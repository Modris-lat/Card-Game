using System.Collections.Generic;
using System.Linq;
using Texas_holdem_engine_01.CardSets;

namespace Texas_holdem_engine_01.StaticGetValues.CheckFlush
{
    public class CheckFlush
    {
        public static ReturnCheckFlushResult CheckIfFlush(List<Card> list)
        {
            var result = new ReturnCheckFlushResult();
            var hList = list.Where(card => card.Suit == 'h');
            var sList = list.Where(card => card.Suit == 's');
            var dList = list.Where(card => card.Suit == 'd');
            var cList = list.Where(card => card.Suit == 'c');
            if (sList.Count() >= 5)
            {
                result.Flush = true;
                result.FlushSuit = 's';
            }
            else if (hList.Count() >= 5)
            {
                result.Flush = true;
                result.FlushSuit = 'h';
            }
            else if (cList.Count() >= 5)
            {
                result.Flush = true;
                result.FlushSuit = 'c';
            }
            else if (dList.Count() >= 5)
            {
                result.Flush = true;
                result.FlushSuit = 'd';
            }
            return result;
        }
    }
}
