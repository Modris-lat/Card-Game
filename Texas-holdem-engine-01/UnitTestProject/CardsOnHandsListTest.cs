using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01;

namespace UnitTestProject
{
    [TestClass]
    public class CardsOnHandsListTest
    {
        private ICardsOnHandsList CardsOnHands;

        public CardsOnHandsListTest()
        {
            CardsOnHands = new CardsOnHandsList(){};
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
