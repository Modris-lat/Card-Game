using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_holdem_engine_01.Static
{
    public class CheckFlush
    {
        public static bool CheckIfFlush(List<Card> list)
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
            if (countS >= 5)
            {
                return true;
            }
            if (countC >= 5)
            {
                return true;
            }
            if (countD >= 5)
            {
                return true;
            }
            if (countH >= 5)
            {
                return true;
            }
            return false;
        }
    }
}
