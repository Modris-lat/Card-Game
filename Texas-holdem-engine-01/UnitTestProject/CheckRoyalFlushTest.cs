using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01.CardSets;
using Texas_holdem_engine_01.StaticGetValues;

namespace UnitTestProject
{
    [TestClass]
    public class CheckRoyalFlushTest
    {
        [TestMethod]
        public void RoyalFlush_True()
        {
            var cardList = new List<Card>
            {
                new Card('2', 's'), new Card('Q', 's'),
                new Card('T', 's'), new Card('K', 's'),
                new Card('J', 's'), new Card('A', 's')
            };
            Assert.IsTrue(CheckRoyalFlush.RoyalFlush(cardList, 's'));
        }
        [TestMethod]
        public void RoyalFlush_False()
        {
            var cardList = new List<Card>
            {
                new Card('2', 's'), new Card('Q', 's'),
                new Card('T', 'd'), new Card('K', 'd'),
                new Card('J', 's'), new Card('A', 's')
            };
            Assert.IsTrue(CheckRoyalFlush.RoyalFlush(cardList, 's') == false);
        }
    }
}
