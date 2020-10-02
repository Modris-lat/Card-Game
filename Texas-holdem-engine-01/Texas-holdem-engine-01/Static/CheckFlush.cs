using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_holdem_engine_01.Static
{
    public class CheckFlush
    {
        public static int CheckIfFlush(List<Card> list)
        {
            int countH = 0;
            int countD = 0;
            int countS = 0;
            int countC = 0;
            foreach (var card in list)
            {
                if (card.Suit == 'h')
                {
                    countH++;
                }
                else if (card.Suit == 'd')
                {
                    countD++;
                }
                else if (card.Suit == 's')
                {
                    countS++;
                }
                else if (card.Suit == 'c')
                {
                    countC++;
                }
            }

            int flushCount = 0;
            if (countS >= 5)
            {
                flushCount++;
            }
            if (countC >= 5)
            {
                flushCount++;
            }
            if (countD >= 5)
            {
                flushCount++;
            }
            if (countH >= 5)
            {
                flushCount++;
            }

            return flushCount;
        }
    }
}
