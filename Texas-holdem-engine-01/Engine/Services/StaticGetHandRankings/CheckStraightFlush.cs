using System.Collections.Generic;
using System.Linq;
using Engine.Models;
using Engine.Rankings;
using Engine.Services.StaticGetHandRankings.StaticGetValues.CheckForStraightAndFlush;

namespace Engine.Services.StaticGetHandRankings
{
    public class CheckStraightFlush
    {
        public static int GetResult(List<Card> cards)
        {
            var suit = CheckFlush.CheckIfFlush(cards);
            var suitList = cards.Where(c => c.Suit == suit);
            var cardValueList = new List<int> { };
            foreach (var card in suitList)
            {
                cardValueList.Add(card.Rank == 'A' ? 1 : card.CardValue);
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
                        return HandRankings.StraightFlush;
                    }
                }
                else if (sum == 0){}
                else
                {
                    count = 0;
                    straightValueList.Clear();
                }
            }
            return 0;
        }
    }
}
