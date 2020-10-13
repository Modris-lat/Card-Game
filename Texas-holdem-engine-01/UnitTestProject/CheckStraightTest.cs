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
            var result = CheckStraight.CheckIfStraight(cardList);
            Assert.IsTrue(result.Straight && result.StraightValue == CardRankings.Rank6);
        }
        [TestMethod]
        public void Straight_False()
        {
            var card1 = new Card('2', 's');
            card1.SetCardValue();
            var card2 = new Card('4', 's');
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
            var result = CheckStraight.CheckIfStraight(cardList);
            Assert.IsTrue(result.Straight == false);
        }
        [TestMethod]
        public void Straight_With_Ace()
        {
            var card1 = new Card('2', 's');
            card1.SetCardValue();
            var card2 = new Card('3', 's');
            card2.SetCardValue();
            var card3 = new Card('4', 'h');
            card3.SetCardValue();
            var card4 = new Card('5', 's');
            card4.SetCardValue();
            var card5 = new Card('A', 'd');
            card5.SetCardValue();
            var card6 = new Card('K', 's');
            card6.SetCardValue();
            var card7 = new Card('Q', 's');
            card7.SetCardValue();
            var cardList = new List<Card>
            {
                card1, card2, card3, card4, card5, card6, card7
            };
            var result = CheckStraight.CheckIfStraight(cardList);
            Assert.IsTrue(result.Straight && result.StraightValue == CardRankings.Rank5);
        }
        [TestMethod]
        public void Straight_With_Equal_Cards()
        {
            var card1 = new Card('2', 's');
            card1.SetCardValue();
            var card2 = new Card('3', 's');
            card2.SetCardValue();
            var card3 = new Card('4', 'h');
            card3.SetCardValue();
            var card4 = new Card('5', 's');
            card4.SetCardValue();
            var card5 = new Card('A', 'd');
            card5.SetCardValue();
            var card6 = new Card('3', 'd');
            card6.SetCardValue();
            var card7 = new Card('3', 'h');
            card7.SetCardValue();
            var cardList = new List<Card>
            {
                card1, card2, card3, card4, card5, card6, card7
            };
            var result = CheckStraight.CheckIfStraight(cardList);
            Assert.IsTrue(result.Straight && result.StraightValue == CardRankings.Rank5);
        }
    }
}
