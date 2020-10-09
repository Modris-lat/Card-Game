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
                    int value = CardRankings.Rank2;
                }
                else if (card.Rank == '3')
                {
                    int value = CardRankings.Rank3;
                    if (value > highest)
                    {
                        highest = value;
                    }
                }
                else if (card.Rank == '4')
                {
                    int value = CardRankings.Rank4;
                    if (value > highest)
                    {
                        highest = value;
                    }
                }
                else if (card.Rank == '5')
                {
                    int value = CardRankings.Rank5;
                    if (value > highest)
                    {
                        highest = value;
                    }
                }
                else if (card.Rank == '6')
                {
                    int value = CardRankings.Rank6;
                    if (value > highest)
                    {
                        highest = value;
                    }
                }
                else if (card.Rank == '7')
                {
                    int value = CardRankings.Rank7;
                    if (value > highest)
                    {
                        highest = value;
                    }
                }
                else if (card.Rank == '8')
                {
                    int value = CardRankings.Rank8;
                    if (value > highest)
                    {
                        highest = value;
                    }
                }
                else if (card.Rank == '9')
                {
                    int value = CardRankings.Rank9;
                    if (value > highest)
                    {
                        highest = value;
                    }
                }
                else if (card.Rank == 'T')
                {
                    int value = CardRankings.RankT;
                    if (value > highest)
                    {
                        highest = value;
                    }
                }
                else if (card.Rank == 'J')
                {
                    int value = CardRankings.RankJ;
                    if (value > highest)
                    {
                        highest = value;
                    }
                }
                else if (card.Rank == 'Q')
                {
                    int value = CardRankings.RankQ;
                    if (value > highest)
                    {
                        highest = value;
                    }
                }
                else if (card.Rank == 'K')
                {
                    int value = CardRankings.RankK;
                    if (value > highest)
                    {
                        highest = value;
                    }
                }
                else if (card.Rank == 'A')
                {
                    int value = CardRankings.RankA;
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
