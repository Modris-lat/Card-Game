using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Texas_holdem_engine_01.CardSets;
using Texas_holdem_engine_01.StaticGetValues;

namespace UnitTestProject
{
    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void Set_Card_Value_On_Creation_True()
        {
            var card = new Card('K', 's');
            Assert.IsTrue(card.CardValue == CardRankings.RankK);
        }
        [TestMethod]
        public void Set_Card_Value_On_Creation_False()
        {
            var card = new Card('K', 's');
            Assert.IsFalse(card.CardValue == CardRankings.RankA);
        }
    }
}
