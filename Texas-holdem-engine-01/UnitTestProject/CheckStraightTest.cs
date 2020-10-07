using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01;
using Texas_holdem_engine_01.Static;

namespace UnitTestProject
{
    [TestClass]
    public class CheckStraightTest
    {
        [TestMethod]
        public void Straight_True()
        {
            var cardList = new List<Card>
            {
                new Card('2', 's'), new Card('3', 's'),
                new Card('4', 's'), new Card('5', 's'),
                new Card('6', 's'), new Card('7', 'd')
            };
            Assert.IsTrue(CheckStraight.CheckIfStraight(cardList));
        }
        [TestMethod]
        public void Straight_False()
        {
            var cardList = new List<Card>
            {
                new Card('K', 's'), new Card('3', 's'),
                new Card('4', 's'), new Card('Q', 's'),
                new Card('6', 's'), new Card('7', 'd')
            };
            Assert.IsTrue(CheckStraight.CheckIfStraight(cardList) == false);
        }
    }
}
