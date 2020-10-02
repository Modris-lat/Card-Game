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
            Hand.Flush = true;
            Hand.HighCard = true;
            Hand.FullHouse = false;
            Assert.IsTrue(Hand.Flush && Hand.HighCard && Hand.FullHouse == false && Hand.Pair == false);
        }
    }
}
