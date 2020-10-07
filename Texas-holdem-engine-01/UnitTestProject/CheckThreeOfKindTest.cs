using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01;
using Texas_holdem_engine_01.Static;

namespace UnitTestProject
{
    [TestClass]
    public class CheckThreeOfKindTest
    {
        [TestMethod]
        public void One_Trio()
        {
            var cardList = new List<Card>
            {
                new Card('2', 's'), new Card('J', 's'),
                new Card('4', 's'), new Card('J', 's'),
                new Card('6', 's'), new Card('J', 'd')
            };
            Assert.IsTrue(CheckThreeOfKind.ThreeOfKind(cardList) == 1);
        }
        [TestMethod]
        public void Two_Trios()
        {
            var cardList = new List<Card>
            {
                new Card('2', 's'), new Card('J', 's'),
                new Card('2', 's'), new Card('J', 's'),
                new Card('2', 's'), new Card('J', 'd')
            };
            Assert.IsTrue(CheckThreeOfKind.ThreeOfKind(cardList) == 2);
        }
    }
}
