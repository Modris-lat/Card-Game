using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01;
using Texas_holdem_engine_01.Interfaces;

namespace UnitTestProject
{
    [TestClass]
    public class HandTest
    {
        private IHand Hand;

        public HandTest()
        {
            Hand = new Hand(1, new List<Card>{new Card('K', 's'), new Card('7', 'd')});
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
            Hand.HighCard = 10;
            Hand.FullHouse = false;
            Assert.IsTrue(Hand.GetStrengthOfHand() == 45);
        }
        [TestMethod]
        public void Test_Strength_Of_Hand_Value_RoyalFlush()
        {
            Hand.RoyalFlush = true;
            Hand.HighCard = 14;
            Assert.IsTrue(Hand.GetStrengthOfHand() == 100);
        }
        [TestMethod]
        public void Test_Strength_Of_Hand_Value_StraightFlush()
        {
            Hand.StraightFl = true;
            Hand.HighCard = 10;
            Assert.IsTrue(Hand.GetStrengthOfHand() == 70);
        }
        [TestMethod]
        public void Test_Strength_Of_Hand_Value_FourOfKind()
        {
            Hand.FourOfKind = true;
            Hand.HighCard = 10;
            Assert.IsTrue(Hand.GetStrengthOfHand() == 55);
        }
        [TestMethod]
        public void Test_Strength_Of_Hand_Value_FullHouse()
        {
            Hand.FullHouse = true;
            Hand.HighCard = 10;
            Assert.IsTrue(Hand.GetStrengthOfHand() == 50);
        }
        [TestMethod]
        public void Test_Strength_Of_Hand_Value_Straight()
        {
            Hand.Straight = true;
            Hand.HighCard = 10;
            Assert.IsTrue(Hand.GetStrengthOfHand() == 40);
        }
        [TestMethod]
        public void Test_Strength_Of_Hand_Value_ThreeOfKind()
        {
            Hand.ThreeOfKind = true;
            Hand.HighCard = 10;
            Assert.IsTrue(Hand.GetStrengthOfHand() == 35);
        }
        [TestMethod]
        public void Test_Strength_Of_Hand_Value_TwoPair()
        {
            Hand.TwoPair = true;
            Hand.HighCard = 10;
            Assert.IsTrue(Hand.GetStrengthOfHand() == 30);
        }
        [TestMethod]
        public void Test_Strength_Of_Hand_Value_Pair()
        {
            Hand.Pair = true;
            Hand.HighCard = 10;
            Assert.IsTrue(Hand.GetStrengthOfHand() == 25);
        }
    }
}
