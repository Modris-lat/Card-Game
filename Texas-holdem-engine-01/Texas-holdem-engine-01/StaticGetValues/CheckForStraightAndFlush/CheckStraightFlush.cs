using System.Collections.Generic;
using System.Linq;
using Texas_holdem_engine_01.CardSets;
using Texas_holdem_engine_01.StaticGetValues.CheckFlush;
using Texas_holdem_engine_01.StaticGetValues.CheckForStraightAndFlush;
using Texas_holdem_engine_01.StaticGetValues.CheckStraight;

namespace Texas_holdem_engine_01.StaticGetValues
{
    public class CheckStraightFlush
    {
        public static StraightFlushResult GetResult(List<Card> cards)
        {
            var cardValueList = new List<int> { };
            var result = new StraightFlushResult();
            foreach (var card in cards)
            {
                if (card.Rank == 'A')
                {
                    cardValueList.Add(1);
                }
                else
                {
                    cardValueList.Add(card.CardValue);
                }
            }
            cardValueList.Sort();
            int count = 0;
            var straightValueList = new List<int> { };
            for (int i = 0; i < cardValueList.Count - 1; i++)
            {
                var sum = cardValueList[i + 1] - cardValueList[i];
                if (sum == 1)
                {
                    count++;
                    straightValueList.Add(cardValueList[i + 1]);
                    if (count == 4)
                    {
                        result.Straight = true;
                        result.StraightValue = straightValueList.Max();
                        break;
                    }
                }
                else if (sum == 0) { }
                else
                {
                    count = 0;
                    straightValueList.Clear();
                }
            }
            var flushList = new List<Card> { };
            var hList = cards.Where(card => card.Suit == 'h');
            var sList = cards.Where(card => card.Suit == 's');
            var dList = cards.Where(card => card.Suit == 'd');
            var cList = cards.Where(card => card.Suit == 'c');
            if (sList.Count() >= 5)
            {
                result.Flush = true;
                //result.FlushSuit = 's';
            }
            else if (hList.Count() >= 5)
            {
                result.Flush = true;
                //result.FlushSuit = 'h';
            }
            else if (cList.Count() >= 5)
            {
                result.Flush = true;
                //result.FlushSuit = 'c';
            }
            else if (dList.Count() >= 5)
            {
                result.Flush = true;
                //result.FlushSuit = 'd';
            }

            return result;
        }
    }
}
