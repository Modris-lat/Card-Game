using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_holdem_engine_01.Static
{
    public class CheckThreeAndFourKind
    {
        public static ReturnThreeAndFourValues ThreeAndFourOfKind(List<Card> cards)
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
            var result = new ReturnThreeAndFourValues();
            int threeCount = 0;
            int fourCount = 0;
            foreach (var card in cards)
            {
                if (card.Rank == '2')
                {
                    count2++;
                    if (count2 == 3)
                    {
                        result.ThreeKind = true;
                        if (result.ThreeKindValue < CardRankings.Rank2)
                        {
                            result.ThreeKindValue = CardRankings.Rank2;
                        }
                    }
                    if (count2 == 4)
                    {
                        result.FourKind = true;
                        if (result.FourKindValue < CardRankings.Rank2)
                        {
                            result.FourKindValue = CardRankings.Rank2;
                        }
                    }
                }
                else if (card.Rank == '3')
                {
                    count3++;
                    if (count3 == 3)
                    {
                        result.ThreeKind = true;
                        if (result.ThreeKindValue < CardRankings.Rank3)
                        {
                            result.ThreeKindValue = CardRankings.Rank3;
                        }
                    }
                    if (count3 == 4)
                    {
                        result.FourKind = true;
                        if (result.FourKindValue < CardRankings.Rank3)
                        {
                            result.FourKindValue = CardRankings.Rank3;
                        }
                    }
                }
                else if (card.Rank == '4')
                {
                    count4++;
                    if (count4 == 3)
                    {
                        result.ThreeKind = true;
                        if (result.ThreeKindValue < CardRankings.Rank4)
                        {
                            result.ThreeKindValue = CardRankings.Rank4;
                        }
                    }
                    if (count4 == 4)
                    {
                        result.FourKind = true;
                        if (result.FourKindValue < CardRankings.Rank4)
                        {
                            result.FourKindValue = CardRankings.Rank4;
                        }
                    }
                }
                else if (card.Rank == '5')
                {
                    count5++;
                    if (count5 == 3)
                    {
                        result.ThreeKind = true;
                        if (result.ThreeKindValue < CardRankings.Rank5)
                        {
                            result.ThreeKindValue = CardRankings.Rank5;
                        }
                    }
                    if (count5 == 4)
                    {
                        result.FourKind = true;
                        if (result.FourKindValue < CardRankings.Rank5)
                        {
                            result.FourKindValue = CardRankings.Rank5;
                        }
                    }
                }
                else if (card.Rank == '6')
                {
                    count6++;
                    if (count6 == 3)
                    {
                        result.ThreeKind = true;
                        if (result.ThreeKindValue < CardRankings.Rank6)
                        {
                            result.ThreeKindValue = CardRankings.Rank6;
                        }
                    }
                    if (count6 == 4)
                    {
                        result.FourKind = true;
                        if (result.FourKindValue < CardRankings.Rank6)
                        {
                            result.FourKindValue = CardRankings.Rank6;
                        }
                    }
                }
                else if (card.Rank == '7')
                {
                    count7++;
                    if (count7 == 3)
                    {
                        result.ThreeKind = true;
                        if (result.ThreeKindValue < CardRankings.Rank7)
                        {
                            result.ThreeKindValue = CardRankings.Rank7;
                        }
                    }
                    if (count7 == 4)
                    {
                        result.FourKind = true;
                        if (result.FourKindValue < CardRankings.Rank7)
                        {
                            result.FourKindValue = CardRankings.Rank7;
                        }
                    }
                }
                else if (card.Rank == '8')
                {
                    count8++;
                    if (count8 == 3)
                    {
                        result.ThreeKind = true;
                        if (result.ThreeKindValue < CardRankings.Rank8)
                        {
                            result.ThreeKindValue = CardRankings.Rank8;
                        }
                    }
                    if (count8 == 4)
                    {
                        result.FourKind = true;
                        if (result.FourKindValue < CardRankings.Rank8)
                        {
                            result.FourKindValue = CardRankings.Rank8;
                        }
                    }
                }
                else if (card.Rank == '9')
                {
                    count9++;
                    if (count9 == 3)
                    {
                        result.ThreeKind = true;
                        if (result.ThreeKindValue < CardRankings.Rank9)
                        {
                            result.ThreeKindValue = CardRankings.Rank9;
                        }
                    }
                    if (count9 == 4)
                    {
                        result.FourKind = true;
                        if (result.FourKindValue < CardRankings.Rank9)
                        {
                            result.FourKindValue = CardRankings.Rank9;
                        }
                    }
                }
                else if (card.Rank == 'T')
                {
                    countT++;
                    if (countT == 3)
                    {
                        result.ThreeKind = true;
                        if (result.ThreeKindValue < CardRankings.RankT)
                        {
                            result.ThreeKindValue = CardRankings.RankT;
                        }
                    }
                    if (countT == 4)
                    {
                        result.FourKind = true;
                        if (result.FourKindValue < CardRankings.RankT)
                        {
                            result.FourKindValue = CardRankings.RankT;
                        }
                    }
                }
                else if (card.Rank == 'J')
                {
                    countJ++;
                    if (countJ == 3)
                    {
                        result.ThreeKind = true;
                        if (result.ThreeKindValue < CardRankings.RankJ)
                        {
                            result.ThreeKindValue = CardRankings.RankJ;
                        }
                    }
                    if (countJ == 4)
                    {
                        result.FourKind = true;
                        if (result.FourKindValue < CardRankings.RankJ)
                        {
                            result.FourKindValue = CardRankings.RankJ;
                        }
                    }
                }
                else if (card.Rank == 'Q')
                {
                    countQ++;
                    if (countQ == 3)
                    {
                        result.ThreeKind = true;
                        if (result.ThreeKindValue < CardRankings.RankQ)
                        {
                            result.ThreeKindValue = CardRankings.RankQ;
                        }
                    }
                    if (countQ == 4)
                    {
                        result.FourKind = true;
                        if (result.FourKindValue < CardRankings.RankQ)
                        {
                            result.FourKindValue = CardRankings.RankQ;
                        }
                    }
                }
                else if (card.Rank == 'K')
                {
                    countK++;
                    if (countK == 3)
                    {
                        result.ThreeKind = true;
                        if (result.ThreeKindValue < CardRankings.RankK)
                        {
                            result.ThreeKindValue = CardRankings.RankK;
                        }
                    }
                    if (countK == 4)
                    {
                        result.FourKind = true;
                        if (result.FourKindValue < CardRankings.RankK)
                        {
                            result.FourKindValue = CardRankings.RankK;
                        }
                    }
                }
                else if (card.Rank == 'A')
                {
                    countA++;
                    if (countA == 3)
                    {
                        result.ThreeKind = true;
                        if (result.ThreeKindValue < CardRankings.RankK)
                        {
                            result.ThreeKindValue = CardRankings.RankK;
                        }
                    }
                    if (countA == 4)
                    {
                        result.FourKind = true;
                        if (result.FourKindValue < CardRankings.RankK)
                        {
                            result.FourKindValue = CardRankings.RankK;
                        }
                    }
                }
            }

            return result;
        }
    }
}
