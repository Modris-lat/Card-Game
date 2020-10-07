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
        public void Test_If_Flush_True()
        {
            var cardList = new List<Card>
            {
                new Card('2', 's'), new Card('3', 's'),
                new Card('4', 's'), new Card('5', 's'),
                new Card('6', 's'), new Card('7', 'd')
            };
            Assert.IsTrue(CheckFlush.CheckIfFlush(cardList) == true);
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
            Assert.IsTrue(CheckFlush.CheckIfFlush(cardList) == false);
        }
    }
}
