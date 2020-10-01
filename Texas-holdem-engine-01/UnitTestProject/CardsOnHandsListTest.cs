using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01;

namespace UnitTestProject
{
    [TestClass]
    public class CardsOnHandsListTest
    {
        private ICardsOnHandsList CardsOnHands;
        private IGetInput Input;

        public CardsOnHandsListTest()
        {
            Input = new InputCards();
            CardsOnHands = new CardsOnHandsList(Input){};
            
        }
        [TestMethod]
        public void Add_Cards_To_List()
        {
            Input.GetInput("2h3h4h5d8d KdKs 9hJh");
            CardsOnHands.AddCardsToHandsList();
            Assert.IsTrue(CardsOnHands.ShowCardsOnHandsList().Count == 2);
        }
        [TestMethod]
        public void Add_Cards_In_First_Hand()
        {
            Input.GetInput("2h3h4h5d8d KdKs 9hJh");
            CardsOnHands.AddCardsToHandsList();
            Assert.IsTrue(CardsOnHands.ShowCardsOnHandsList()[0][0].Rank == 'K'
                          && CardsOnHands.ShowCardsOnHandsList()[0][0].Suit == 'd'
                          && CardsOnHands.ShowCardsOnHandsList()[0][1].Rank == 'K'
                          && CardsOnHands.ShowCardsOnHandsList()[0][1].Suit == 's');
        }
        [TestMethod]
        public void Add_Cards_In_Last_Hand()
        {
            Input.GetInput("4cKs4h8s7s Ad4s Ac4d As9s KhKd 5d6d");
            CardsOnHands.AddCardsToHandsList();
            Assert.IsTrue(CardsOnHands.ShowCardsOnHandsList()[4][0].Rank == '5' 
                          && CardsOnHands.ShowCardsOnHandsList()[4][0].Suit == 'd'
                          && CardsOnHands.ShowCardsOnHandsList()[4][1].Rank == '6'
                          && CardsOnHands.ShowCardsOnHandsList()[4][1].Suit == 'd');
        }
        [TestMethod]
        public void Remove_Hand()
        {
            Input.GetInput("4cKs4h8s7s Ad4s Ac4d As9s KhKd 5d6d");
            CardsOnHands.AddCardsToHandsList();
            CardsOnHands.RemoveHand(0);
            Assert.IsTrue(CardsOnHands.ShowCardsOnHandsList().Count == 4);
        }
    }
}
