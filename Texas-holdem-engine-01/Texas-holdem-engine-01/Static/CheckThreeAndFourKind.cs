using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_holdem_engine_01.Static
{
    public class CheckThreeAndFourKind
    {
        public static (int, int) ThreeAndFourOfKind(List<Card> cards)
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
            int threeCount = 0;
            int fourCount = 0;
            foreach (var card in cards)
            {
                if (card.Rank == '2')
                {
                    count2++;
                    if (count2 == 3)
                    {
                        threeCount++;
                    }
                    if (count2 == 4)
                    {
                        fourCount++;
                    }
                }
                else if (card.Rank == '3')
                {
                    count3++;
                    if (count3 == 3)
                    {
                        threeCount++;
                    }
                    if (count3 == 4)
                    {
                        fourCount++;
                    }
                }
                else if (card.Rank == '4')
                {
                    count4++;
                    if (count4 == 3)
                    {
                        threeCount++;
                    }
                    if (count4 == 4)
                    {
                        fourCount++;
                    }
                }
                else if (card.Rank == '5')
                {
                    count5++;
                    if (count5 == 3)
                    {
                        threeCount++;
                    }
                    if (count5 == 4)
                    {
                        fourCount++;
                    }
                }
                else if (card.Rank == '6')
                {
                    count6++;
                    if (count6 == 3)
                    {
                        threeCount++;
                    }
                    if (count6 == 4)
                    {
                        fourCount++;
                    }
                }
                else if (card.Rank == '7')
                {
                    count7++;
                    if (count7 == 3)
                    {
                        threeCount++;
                    }
                    if (count7 == 4)
                    {
                        fourCount++;
                    }
                }
                else if (card.Rank == '8')
                {
                    count8++;
                    if (count8 == 3)
                    {
                        threeCount++;
                    }
                    if (count8 == 4)
                    {
                        fourCount++;
                    }
                }
                else if (card.Rank == '9')
                {
                    count9++;
                    if (count9 == 3)
                    {
                        threeCount++;
                    }
                    if (count9 == 4)
                    {
                        fourCount++;
                    }
                }
                else if (card.Rank == 'T')
                {
                    countT++;
                    if (countT == 3)
                    {
                        threeCount++;
                    }
                    if (countT == 4)
                    {
                        fourCount++;
                    }
                }
                else if (card.Rank == 'J')
                {
                    countJ++;
                    if (countJ == 3)
                    {
                        threeCount++;
                    }
                    if (countJ == 4)
                    {
                        fourCount++;
                    }
                }
                else if (card.Rank == 'Q')
                {
                    countQ++;
                    if (countQ == 3)
                    {
                        threeCount++;
                    }
                    if (countQ == 4)
                    {
                        fourCount++;
                    }
                }
                else if (card.Rank == 'K')
                {
                    countK++;
                    if (countK == 3)
                    {
                        threeCount++;
                    }
                    if (countK == 4)
                    {
                        fourCount++;
                    }
                }
                else if (card.Rank == 'A')
                {
                    countA++;
                    if (countA == 3)
                    {
                        threeCount++;
                    }
                    if (countA == 4)
                    {
                        fourCount++;
                    }
                }
            }

            return (threeCount, fourCount);
        }
    }
}
