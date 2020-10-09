using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_holdem_engine_01.Static
{
    public class CheckPairs
    {
        public static ReturnPairValue CheckForPair(List<Card> cards)
        {
            int countA = 0;
            int countK = 0;
            int countQ = 0;
            int countJ = 0;
            int countT = 0;
            int count9 = 0;
            int count8 = 0;
            int count7 = 0;
            int count6 = 0;
            int count5 = 0;
            int count4 = 0;
            int count3 = 0;
            int count2 = 0;
            var pairValue = new ReturnPairValue();
            foreach (var card in cards)
            {
                if (card.Rank == '2')
                {
                    count2++;
                    if (count2 == 2)
                    {
                        pairValue.PairCount++;
                        pairValue.PairValue += CardRankings.Rank2;
                    }
                }
                else if (card.Rank == '3')
                {
                    count3++;
                    if (count3 == 2)
                    {
                        pairValue.PairCount++;
                        pairValue.PairValue += CardRankings.Rank3;
                    }
                }
                else if (card.Rank == '4')
                {
                    count4++;
                    if (count4 == 2)
                    {
                        pairValue.PairCount++;
                        pairValue.PairValue += CardRankings.Rank4;
                    }
                }
                else if (card.Rank == '5')
                {
                    count5++;
                    if (count5 == 2)
                    {
                        pairValue.PairCount++;
                        pairValue.PairValue += CardRankings.Rank5;
                    }
                }
                else if (card.Rank == '6')
                {
                    count6++;
                    if (count6 == 2)
                    {
                        pairValue.PairCount++;
                        pairValue.PairValue += CardRankings.Rank6;
                    }
                }
                else if (card.Rank == '7')
                {
                    count7++;
                    if (count7 == 2)
                    {
                        pairValue.PairCount++;
                        pairValue.PairValue += CardRankings.Rank7;
                    }
                }
                else if (card.Rank == '8')
                {
                    count8++;
                    if (count8 == 2)
                    {
                        pairValue.PairCount++;
                        pairValue.PairValue += CardRankings.Rank8;
                    }
                }
                else if (card.Rank == '9')
                {
                    count9++;
                    if (count9 == 2)
                    {
                        pairValue.PairCount++;
                        pairValue.PairValue += CardRankings.Rank9;
                    }
                }
                else if (card.Rank == 'T')
                {
                    countT++;
                    if (countT == 2)
                    {
                        pairValue.PairCount++;
                        pairValue.PairValue += CardRankings.RankT;
                    }
                }
                else if (card.Rank == 'J')
                {
                    countJ++;
                    if (countJ == 2)
                    {
                        pairValue.PairCount++;
                        pairValue.PairValue += CardRankings.RankJ;
                    }
                }
                else if (card.Rank == 'Q')
                {
                    countQ++;
                    if (countQ == 2)
                    {
                        pairValue.PairCount++;
                        pairValue.PairValue += CardRankings.RankQ;
                    }
                }
                else if (card.Rank == 'K')
                {
                    countK++;
                    if (countK == 2)
                    {
                        pairValue.PairCount++;
                        pairValue.PairValue += CardRankings.RankK;
                    }
                }
                else if (card.Rank == 'A')
                {
                    countA++;
                    if (countA == 2)
                    {
                        pairValue.PairCount++;
                        pairValue.PairValue += CardRankings.RankA;
                    }
                }
            }

            return pairValue;
        }
    }
}
