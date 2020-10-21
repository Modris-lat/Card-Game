using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01.CardSets;
using Texas_holdem_engine_01.StaticGetValues;

namespace UnitTestProject
{
    [TestClass]
    public class CheckStraightFlushTest
    {
        [TestMethod]
        public void StraightFlush_True()
        {
            var cardList = new List<Card>
            {
                new Card('2', 's'), new Card('3', 's'),
                new Card('4', 's'), new Card('5', 's'),
                new Card('6', 's'), new Card('J', 'd')
            };
            Assert.IsTrue(CheckStraightFlush.StraightFlush(cardList, 's'));
        }
        [TestMethod]
        public void StraightFlush_False()
        {
            var cardList = new List<Card>
            {
                new Card('T', 's'), new Card('K', 's'),
                new Card('J', 's'), new Card('A', 's'),
                new Card('Q', 's'), new Card('J', 'd')
            };
            Assert.IsTrue(CheckStraightFlush.StraightFlush(cardList, 's') == false);
        }
    }
}
