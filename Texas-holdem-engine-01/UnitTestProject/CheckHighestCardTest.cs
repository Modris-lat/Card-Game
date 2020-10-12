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
            var card1 = new Card('K', 'd');
            card1.SetCardValue();
            var card2 = new Card('A', 's');
            card2.SetCardValue();
            var cardList = new List<Card> { card1, card2 };
            Assert.IsTrue(CheckHighCard.HighestCard(cardList) == 14);
        }
        [TestMethod]
        public void Test_Method_For_Cards()
        {
            var card1 = new Card('9', 'd');
            card1.SetCardValue();
            var card2 = new Card('5', 'c');
            card2.SetCardValue();
            var card3 = new Card('2', 'h');
            card3.SetCardValue();
            var card4 = new Card('6', 's');
            card4.SetCardValue();
            var cardList = new List<Card>
            {
                card1, card2,
                card3, card4
            };
            Assert.IsTrue(CheckHighCard.HighestCard(cardList) == 9);
        }
    }
}
