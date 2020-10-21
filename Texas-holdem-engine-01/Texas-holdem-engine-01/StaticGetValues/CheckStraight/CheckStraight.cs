using System.Collections.Generic;
using System.Linq;
using Texas_holdem_engine_01.CardSets;

namespace Texas_holdem_engine_01.StaticGetValues.CheckStraight
{
    public class CheckStraight
    {
        public static ReturnCheckStraightValues CheckIfStraight(List<Card> cardsList)
        {
            var cards = cardsList;
            var cardValueList = new List<int>(){};
            var result = new ReturnCheckStraightValues();
            foreach (var card in cards)
            {
                if (card.Rank == 'A')
                {
                    card.CardValue = 1;
                }
                cardValueList.Add(card.CardValue);
            }
            cardValueList.Sort();
            int count = 0;
            var straightValueList = new List<int>() { };
            for(int i=0; i< cardValueList.Count-1; i++)
            {
                var sum = cardValueList[i + 1] - cardValueList[i];
                if (sum == 1)
                {
                    count++;
                    straightValueList.Add(cardValueList[i+1]);
                    if (count == 4)
                    {
                        result.Straight = true;
                        result.StraightValue = straightValueList.Max();
                        return result;
                    }
                }
                else if (sum == 0)
                {
                    continue;
                }
                else
                {
                    count = 0;
                    straightValueList.Clear();
                }
            }
            return result;
        }
    }
}
