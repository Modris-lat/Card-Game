using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01;

namespace UnitTestProject
{
    [TestClass]
    public class CardRankingTest
    {
        [TestMethod]
        public void Rankings_True()
        {
            Assert.IsTrue(CardRankings.Rank2 == 2 && CardRankings.Rank3 == 3 && CardRankings.Rank4 == 4
                          && CardRankings.Rank5 == 5 && CardRankings.Rank6 == 6 && CardRankings.Rank7 == 7 &&
                          CardRankings.Rank8 == 8 && CardRankings.Rank9 == 9 && CardRankings.RankT == 10 &&
                          CardRankings.RankJ == 11 && CardRankings.RankQ == 12 && CardRankings.RankK == 13 &&
                          CardRankings.RankA == 14);
        }
        [TestMethod]
        public void Rankings_False()
        {
            Assert.IsFalse(CardRankings.Rank2 == 3 && CardRankings.Rank3 == 4 && CardRankings.Rank4 == 5 
                          && CardRankings.Rank5 == 9 && CardRankings.Rank6 == 6 && CardRankings.Rank7 == 7 &&
                          CardRankings.Rank8 == 8 && CardRankings.Rank9 == 10 && CardRankings.RankT == 10 &&
                          CardRankings.RankJ == 11 && CardRankings.RankQ == 12 && CardRankings.RankK == 13 &&
                          CardRankings.RankA == 14);
        }
    }
}
