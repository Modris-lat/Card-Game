using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01;
using Texas_holdem_engine_01.Static;

namespace UnitTestProject
{
    [TestClass]
    public class CheckPairsTest
    {
        [TestMethod]
        public void One_Pair()
        {
            var cardList = new List<Card>
            {
                new Card('2', 's'), new Card('3', 's'),
                new Card('4', 's'), new Card('J', 's'),
                new Card('6', 's'), new Card('J', 'd')
            };
            var result = CheckPairs.CheckForPair(cardList);
            Assert.IsTrue(result.Item1 == 1 && result.Item2 == CardRankings.RankJ);
        }
        [TestMethod]
        public void Two_Pairs()
        {
            var cardList = new List<Card>
            {
                new Card('2', 's'), new Card('3', 's'),
                new Card('2', 's'), new Card('J', 's'),
                new Card('6', 's'), new Card('J', 'd')
            };
            var result = CheckPairs.CheckForPair(cardList);
            Assert.IsTrue(result.Item1 == 2 &&
                          result.Item2 == CardRankings.Rank2 + CardRankings.RankJ);
        }
        [TestMethod]
        public void Two_The_Same_Kind_Pairs()
        {
            var cardList = new List<Card>
            {
                new Card('2', 's'), new Card('3', 's'),
                new Card('2', 's'), new Card('2', 's'),
                new Card('6', 's'), new Card('2', 'd')
            };
            var result = CheckPairs.CheckForPair(cardList);
            Assert.IsTrue(result.Item1 == 2 &&
                          result.Item2 == CardRankings.Rank2 + CardRankings.Rank2);
        }
    }
}
