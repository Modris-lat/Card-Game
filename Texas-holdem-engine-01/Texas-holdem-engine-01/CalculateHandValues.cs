using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texas_holdem_engine_01.Interfaces;

namespace Texas_holdem_engine_01
{
    public class CalculateHandValues: ICalculateHandValues
    {
        public IHand CalculateCardsValues(IList<Card> table, List<IHand> hands)
        {
            foreach (var item in hands)
            {
                var hand = new List<Card>(table);
                hand.Add(item.GetCards()[0]);
                hand.Add(item.GetCards()[1]);
                var flushCount = CountSuits(hand);
            }
            throw new NotImplementedException();
        }

        int CountSuits(List<Card> list)
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

        //static char GetHighestCard(List<Card> list)
        //{

        //}
    }
}
