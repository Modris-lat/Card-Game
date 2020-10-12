using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_holdem_engine_01.Static
{
    public class CheckStraight
    {
        public static bool CheckIfStraight(List<Card> cards)
        {
            //var sortedCards = cards.Sort
            var valuesList = new List<int>();
            foreach (var card in cards)
            {
                if (card.Rank == '2')
                {
                    int value = 2;
                    valuesList.Add(value);
                }
                else if (card.Rank == '3')
                {
                    int value = 3;
                    valuesList.Add(value);
                }
                else if (card.Rank == '4')
                {
                    int value = 4;
                    valuesList.Add(value);
                }
                else if (card.Rank == '5')
                {
                    int value = 5;
                    valuesList.Add(value);
                }
                else if (card.Rank == '6')
                {
                    int value = 6;
                    valuesList.Add(value);
                }
                else if (card.Rank == '7')
                {
                    int value = 7;
                    valuesList.Add(value);
                }
                else if (card.Rank == '8')
                {
                    int value = 8;
                    valuesList.Add(value);
                }
                else if (card.Rank == '9')
                {
                    int value = 9;
                    valuesList.Add(value);
                }
                else if (card.Rank == 'T')
                {
                    int value = 10;
                    valuesList.Add(value);
                }
                else if (card.Rank == 'J')
                {
                    int value = 11;
                    valuesList.Add(value);
                }
                else if (card.Rank == 'Q')
                {
                    int value = 12;
                    valuesList.Add(value);
                }
                else if (card.Rank == 'K')
                {
                    int value = 13;
                    valuesList.Add(value);
                }
                else if (card.Rank == 'A')
                {
                    int value = 14;
                    valuesList.Add(value);
                }
            }
            valuesList.Sort();
            int count = 0;
            for(int i=0; i<valuesList.Count-1; i++)
            {
                var sum = valuesList[i + 1] - valuesList[i];
                if (sum == 1)
                {
                    count++;
                    if (count == 5)
                    {
                        return true;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            return false;
        }
    }
}
