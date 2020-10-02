using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01;
using Texas_holdem_engine_01.Static;

namespace UnitTestProject
{
    [TestClass]
    public class CheckHighestCardTest
    {
        [TestMethod]
        public void Test_Method()
        {
            var cardList = new List<Card> {new Card('K', 'd'), new Card('A', 's')};
            Assert.IsTrue(CheckHighCard.HighestCard(cardList) == 14);
        }
        [TestMethod]
        public void Test_Method_For_Cards()
        {
            var cardList = new List<Card>
            {
                new Card('9', 'd'), new Card('5', 'c'),
                new Card('2', 'h'),  new Card('6', 's')
            };
            Assert.IsTrue(CheckHighCard.HighestCard(cardList) == 9);
        }
    }
}
