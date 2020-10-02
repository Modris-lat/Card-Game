using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_holdem_engine_01.Static
{
    public class CheckHighCard
    {
        public static int HighestCard(List<Card> cards)
        {
            int highest = 0;
            foreach (var card in cards)
            {
                if (card.Rank == '2')
                {
                    int value = 2;
                }
                else if (card.Rank == '3')
                {
                    int value = 3;
                    if (value > highest)
                    {
                        highest = value;
                    }
                }
                else if (card.Rank == '4')
                {
                    int value = 4;
                    if (value > highest)
                    {
                        highest = value;
                    }
                }
                else if (card.Rank == '5')
                {
                    int value = 5;
                    if (value > highest)
                    {
                        highest = value;
                    }
                }
                else if (card.Rank == '6')
                {
                    int value = 6;
                    if (value > highest)
                    {
                        highest = value;
                    }
                }
                else if (card.Rank == '7')
                {
                    int value = 7;
                    if (value > highest)
                    {
                        highest = value;
                    }
                }
                else if (card.Rank == '8')
                {
                    int value = 8;
                    if (value > highest)
                    {
                        highest = value;
                    }
                }
                else if (card.Rank == '9')
                {
                    int value = 9;
                    if (value > highest)
                    {
                        highest = value;
                    }
                }
                else if (card.Rank == 'T')
                {
                    int value = 10;
                    if (value > highest)
                    {
                        highest = value;
                    }
                }
                else if (card.Rank == 'J')
                {
                    int value = 11;
                    if (value > highest)
                    {
                        highest = value;
                    }
                }
                else if (card.Rank == 'Q')
                {
                    int value = 12;
                    if (value > highest)
                    {
                        highest = value;
                    }
                }
                else if (card.Rank == 'K')
                {
                    int value = 13;
                    if (value > highest)
                    {
                        highest = value;
                    }
                }
                else if (card.Rank == 'A')
                {
                    int value = 14;
                    if (value > highest)
                    {
                        highest = value;
                    }
                }
            }

            return highest;
        }
    }
}
