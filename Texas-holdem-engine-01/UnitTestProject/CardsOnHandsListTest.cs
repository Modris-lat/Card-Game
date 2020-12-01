using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01;
using Texas_holdem_engine_01.CardSets;
using Texas_holdem_engine_01.Interfaces;

namespace UnitTestProject
{
    [TestClass]
    public class CardsOnHandsListTest
    {
        private readonly ICardsOnHandsList _cardsOnHands;

        public CardsOnHandsListTest()
        {
            _cardsOnHands = new CardsOnHandsList();
            
        }
        [TestMethod]
        public void Add_Cards_To_List()
        {
            var hands = new List<string>
            {
                "KdKs",
                "9hJh"
            };
            _cardsOnHands.AddHands(hands);
            Assert.IsTrue(_cardsOnHands.ShowCardsOnHandsList().Count == 2);
        }
        [TestMethod]
        public void Add_Cards_In_First_Hand()
        {
            var hands = new List<string>
            {
                "KdKs",
                "9hJh"
            };
            _cardsOnHands.AddHands(hands);
            Assert.IsTrue(_cardsOnHands.ShowCardsOnHandsList()[0].GetCards()[0].Rank == 'K'
                          && _cardsOnHands.ShowCardsOnHandsList()[0].GetCards()[0].Suit == 'd'
                          && _cardsOnHands.ShowCardsOnHandsList()[0].GetCards()[1].Rank == 'K'
                          && _cardsOnHands.ShowCardsOnHandsList()[0].GetCards()[1].Suit == 's');
        }
        [TestMethod]
        public void Add_Cards_In_Last_Hand()
        {
            var hands = new List<string>
            {
                "Ad4s",
                "Ac4d",
                "As9s",
                "KhKd",
                "5d6d"
            };
            _cardsOnHands.AddHands(hands);
            Assert.IsTrue(_cardsOnHands.ShowCardsOnHandsList()[4].GetCards()[0].Rank == '5' 
                          && _cardsOnHands.ShowCardsOnHandsList()[4].GetCards()[0].Suit == 'd'
                          && _cardsOnHands.ShowCardsOnHandsList()[4].GetCards()[1].Rank == '6'
                          && _cardsOnHands.ShowCardsOnHandsList()[4].GetCards()[1].Suit == 'd');
        }
        [TestMethod]
        public void Remove_Hand()
        {
            var hands = new List<string>
            {
                "Ad4s",
                "Ac4d",
                "As9s",
                "KhKd",
                "5d6d"
            };
            _cardsOnHands.AddHands(hands);
            _cardsOnHands.RemoveHand(_cardsOnHands.ShowCardsOnHandsList()[0].Id);
            Assert.IsTrue(_cardsOnHands.ShowCardsOnHandsList().Count == 4);
        }
    }
}
