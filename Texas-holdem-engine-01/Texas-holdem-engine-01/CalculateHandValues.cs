using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texas_holdem_engine_01.Interfaces;
using Texas_holdem_engine_01.Static;

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
                var flushCount = CheckFlush.CheckIfFlush(hand);
                if (flushCount > 0)
                {
                    item.Flush = true;
                }

                item.HighCard = CheckHighCard.HighestCard(hand);
            }
            throw new NotImplementedException();
        }

    }
}
