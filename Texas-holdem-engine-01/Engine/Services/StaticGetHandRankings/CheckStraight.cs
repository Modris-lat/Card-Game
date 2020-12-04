using System.Collections.Generic;
using System.Linq;
using Engine.Models;
using Engine.Rankings;

namespace Engine.Services.StaticGetHandRankings
{
    public static class CheckStraight
    {
        public static int CheckIfStraight(List<Card> cardsList)
        {
            var cards = cardsList;
            var cardValueList = new List<int>{};
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
            for(int i=0; i< cardValueList.Count-1; i++)
            {
                var sum = cardValueList[i + 1] - cardValueList[i];
                if (sum == 1)
                {
                    count++;
                    straightValueList.Add(cardValueList[i+1]);
                    if (count == 4)
                    {
                        return HandRankings.Straight + straightValueList.Max();
                    }
                }
                else if (sum == 0) { }
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
