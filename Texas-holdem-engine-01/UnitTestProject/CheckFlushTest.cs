using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01;
using Texas_holdem_engine_01.Static;

namespace UnitTestProject
{
    [TestClass]
    public class CheckFlushTest
    {
        [TestMethod]
        public void Test_If_Flush_True_S()
        {
            var card1 = new Card('2', 's');
            card1.SetCardValue();
            var card2 = new Card('3', 's');
            card2.SetCardValue();
            var card3 = new Card('4', 'h');
            card3.SetCardValue();
            var card4 = new Card('5', 's');
            card4.SetCardValue();
            var card5 = new Card('6', 'd');
            card5.SetCardValue();
            var card6 = new Card('K', 's');
            card6.SetCardValue();
            var card7 = new Card('Q', 's');
            card7.SetCardValue();
            var cardList = new List<Card>
            {
                card1, card2, card3, card4, card5, card6, card7
            };
            var result = CheckFlush.CheckIfFlush(cardList);
            Assert.IsTrue(result.FlushSuit == 's');
        }
        [TestMethod]
        public void Test_If_Flush_True_H()
        {
            var card1 = new Card('2', 'h');
            card1.SetCardValue();
            var card2 = new Card('3', 'h');
            card2.SetCardValue();
            var card3 = new Card('4', 'h');
            card3.SetCardValue();
            var card4 = new Card('5', 's');
            card4.SetCardValue();
            var card5 = new Card('6', 'd');
            card5.SetCardValue();
            var card6 = new Card('K', 'h');
            card6.SetCardValue();
            var card7 = new Card('Q', 'h');
            card7.SetCardValue();
            var cardList = new List<Card>
            {
                card1, card2, card3, card4, card5, card6, card7
            };
            var result = CheckFlush.CheckIfFlush(cardList);
            Assert.IsTrue(result.FlushSuit == 'h');
        }
        [TestMethod]
        public void Test_If_Flush_True_D()
        {
            var card1 = new Card('2', 'd');
            card1.SetCardValue();
            var card2 = new Card('3', 's');
            card2.SetCardValue();
            var card3 = new Card('4', 'd');
            card3.SetCardValue();
            var card4 = new Card('5', 's');
            card4.SetCardValue();
            var card5 = new Card('6', 'd');
            card5.SetCardValue();
            var card6 = new Card('K', 'd');
            card6.SetCardValue();
            var card7 = new Card('Q', 'd');
            card7.SetCardValue();
            var cardList = new List<Card>
            {
                card1, card2, card3, card4, card5, card6, card7
            };
            var result = CheckFlush.CheckIfFlush(cardList);
            Assert.IsTrue(result.FlushSuit == 'd');
        }
        [TestMethod]
        public void Test_If_Flush_True_C()
        {
            var card1 = new Card('2', 'c');
            card1.SetCardValue();
            var card2 = new Card('3', 'c');
            card2.SetCardValue();
            var card3 = new Card('4', 'h');
            card3.SetCardValue();
            var card4 = new Card('5', 'c');
            card4.SetCardValue();
            var card5 = new Card('6', 'd');
            card5.SetCardValue();
            var card6 = new Card('K', 'c');
            card6.SetCardValue();
            var card7 = new Card('Q', 'c');
            card7.SetCardValue();
            var cardList = new List<Card>
            {
                card1, card2, card3, card4, card5, card6, card7
            };
            var result = CheckFlush.CheckIfFlush(cardList);
            Assert.IsTrue(result.FlushSuit == 'c');
        }
        [TestMethod]
        public void Test_If_Flush_False()
        {
            var cardList = new List<Card>
            {
                new Card('2', 'd'), new Card('3', 's'),
                new Card('4', 's'), new Card('5', 's'),
                new Card('6', 's'), new Card('7', 'd')
            };
            var result = CheckFlush.CheckIfFlush(cardList);
            Assert.IsFalse(result.FlushSuit == 's');
        }
    }
}
