using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_holdem_engine_01.Static
{
    public class CheckPairs
    {
        public static int CheckForPair(List<Card> cards)
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
            int pairCount = 0;
            foreach (var card in cards)
            {
                if (card.Rank == '2')
                {
                    count2++;
                    if (count2 == 2 || count2 == 4)
                    {
                        pairCount++;
                    }
                    
                }
                else if (card.Rank == '3')
                {
                    count3++;
                    if (count3 == 2 || count3 == 4)
                    {
                        pairCount++;
                    }
                }
                else if (card.Rank == '4')
                {
                    count4++;
                    if (count4 == 2 || count4 == 4)
                    {
                        pairCount++;
                    }
                }
                else if (card.Rank == '5')
                {
                    count5++;
                    if (count5 == 2 || count5 == 4)
                    {
                        pairCount++;
                    }
                }
                else if (card.Rank == '6')
                {
                    count6++;
                    if (count6 == 2 || count6 == 4)
                    {
                        pairCount++;
                    }
                }
                else if (card.Rank == '7')
                {
                    count7++;
                    if (count7 == 2 || count7 == 4)
                    {
                        pairCount++;
                    }
                }
                else if (card.Rank == '8')
                {
                    count8++;
                    if (count8 == 2 || count8 == 4)
                    {
                        pairCount++;
                    }
                }
                else if (card.Rank == '9')
                {
                    count9++;
                    if (count9 == 2 || count9 == 4)
                    {
                        pairCount++;
                    }
                }
                else if (card.Rank == 'T')
                {
                    countT++;
                    if (countT == 2 || countT == 4)
                    {
                        pairCount++;
                    }
                }
                else if (card.Rank == 'J')
                {
                    countJ++;
                    if (countJ == 2 || countJ == 4)
                    {
                        pairCount++;
                    }
                }
                else if (card.Rank == 'Q')
                {
                    countQ++;
                    if (countQ == 2 || countQ == 4)
                    {
                        pairCount++;
                    }
                }
                else if (card.Rank == 'K')
                {
                    countK++;
                    if (countK == 2 || countK == 4)
                    {
                        pairCount++;
                    }
                }
                else if (card.Rank == 'A')
                {
                    countA++;
                    if (countA == 2 || countA == 4)
                    {
                        pairCount++;
                    }
                }
            }

            return pairCount;
        }
    }
}
