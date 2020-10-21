using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01;
using Texas_holdem_engine_01.CardSets;
using Texas_holdem_engine_01.Interfaces;
using Texas_holdem_engine_01.StaticGetValues;

namespace UnitTestProject
{
    [TestClass]
    public class HandTest
    {
        private IHand Hand;

        public HandTest()
        {
            var card1 = new Card('K', 's');
            card1.SetCardValue();
            var card2 = new Card('7', 'd');
            card1.SetCardValue();
            Hand = new Hand(1, new List<Card>{card1, card2});
        }
        [TestMethod]
        public void Test_Id()
        {
            Assert.IsTrue(Hand.Id == 1);
        }
        [TestMethod]
        public void Test_Id_False()
        {
            Assert.IsFalse(Hand.Id == 2);
        }
        [TestMethod]
        public void Test_List_Count()
        {
            Assert.IsTrue(Hand.GetCards().Count == 2);
        }
        [TestMethod]
        public void Test_List_Items()
        {
            Assert.IsTrue(Hand.GetCards()[0].Rank == 'K' &&
                          Hand.GetCards()[1].Suit == 'd');
        }
        [TestMethod]
        public void Test_Hand_Value()
        {
            Hand.Flush = 's';
            Hand.HighCard = 12;
            Hand.FullHouse = false;
            Assert.IsTrue(Hand.Flush == 's' && Hand.HighCard == 12 && Hand.FullHouse == false && Hand.Pair == false);
        }
        [TestMethod]
        public void Test_Strength_Of_Hand_Value_Flush()
        {
            Hand.Flush = 's';
            Hand.FullHouse = false;
            Assert.IsTrue(Hand.GetStrengthOfHand() == 35 + CardRankings.RankK);
        }
        [TestMethod]
        public void Test_Strength_Of_Hand_Value_RoyalFlush()
        {
            Hand.RoyalFlush = true;
            Assert.IsTrue(Hand.GetStrengthOfHand() == 100);
        }
        [TestMethod]
        public void Test_Strength_Of_Hand_Value_StraightFlush()
        {
            Hand.StraightFl = true;
            Hand.Strength = CardRankings.RankJ;
            Assert.IsTrue(Hand.GetStrengthOfHand() == 70 + CardRankings.RankJ);
        }
        [TestMethod]
        public void Test_Strength_Of_Hand_Value_FourOfKind()
        {
            Hand.FourOfKind = true;
            Hand.Strength = CardRankings.RankJ;
            Assert.IsTrue(Hand.GetStrengthOfHand() == 50 + CardRankings.RankK + CardRankings.RankJ);
        }
        [TestMethod]
        public void Test_Strength_Of_Hand_Value_FullHouse()
        {
            Hand.FullHouse = true;
            Hand.Strength = CardRankings.RankJ;
            Assert.IsTrue(Hand.GetStrengthOfHand() == 40 + CardRankings.RankJ);
        }
        [TestMethod]
        public void Test_Strength_Of_Hand_Value_Straight()
        {
            Hand.Straight = true;
            Hand.Strength = CardRankings.RankJ;
            Assert.IsTrue(Hand.GetStrengthOfHand() == 30 + CardRankings.RankJ);
        }
        [TestMethod]
        public void Test_Strength_Of_Hand_Value_ThreeOfKind()
        {
            Hand.ThreeOfKind = true;
            Assert.IsTrue(Hand.GetStrengthOfHand() == 25 + CardRankings.RankK);
        }
        [TestMethod]
        public void Test_Strength_Of_Hand_Value_TwoPair()
        {
            Hand.TwoPair = true;
            Assert.IsTrue(Hand.GetStrengthOfHand() == 20 + CardRankings.RankK);
        }
        [TestMethod]
        public void Test_Strength_Of_Hand_Value_Pair()
        {
            Hand.Pair = true;
            Assert.IsTrue(Hand.GetStrengthOfHand() == 15 + CardRankings.RankK);
        }
    }
}
