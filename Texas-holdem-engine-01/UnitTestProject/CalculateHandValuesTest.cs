using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01;
using Texas_holdem_engine_01.CardSets;
using Texas_holdem_engine_01.Interfaces;
using Texas_holdem_engine_01.StaticGetValues;

namespace UnitTestProject
{
    [TestClass]
    public class CalculateHandValuesTest
    {
        private readonly ITable Table;
        private readonly ICardsOnHandsList CardsOnHands;
        private readonly IGetInput Input;
        private ICalculateHandValues Calculate;

        public CalculateHandValuesTest()
        {
            Input = new InputCards();
            Table = new Table(Input);
            CardsOnHands = new CardsOnHandsList(Input);
            Calculate = new CalculateHandValues();
        }
        [TestMethod]
        public void Strongest_Hand_With_Highest_Card_K()
        {
            Input.GetInput("4c3s9h8s7s KdJc 2cQd");
            Table.GetCardsOnTable();
            CardsOnHands.AddCardsToHandsList();
            var strongestHand = Calculate.CalculateCardsValues(Table.ShowCardsOnTable(),
                CardsOnHands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.HighCard == CardRankings.RankK);
        }
        [TestMethod]
        public void Strongest_Hand_With_Highest_Card_A()
        {
            Input.GetInput("4c3s9h8s7s AdJc 2cQd");
            Table.GetCardsOnTable();
            CardsOnHands.AddCardsToHandsList();
            var strongestHand = Calculate.CalculateCardsValues(Table.ShowCardsOnTable(),
                CardsOnHands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.Strength == CardRankings.RankA);
        }
        [TestMethod]
        public void Strongest_Hand_With_Highest_Card_J()
        {
            Input.GetInput("4c3s9h8s7s 5dJc 2cTd");
            Table.GetCardsOnTable();
            CardsOnHands.AddCardsToHandsList();
            var strongestHand = Calculate.CalculateCardsValues(Table.ShowCardsOnTable(),
                CardsOnHands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.Strength == CardRankings.RankJ);
        }
        [TestMethod]
        public void Strongest_Hand_With_Highest_Card_With_Many_Hands()
        {
            Input.GetInput("4c3s9h8s7s 5dTc 2cTd 6dAc KcQd KsQh JhTh KhQh");
            Table.GetCardsOnTable();
            CardsOnHands.AddCardsToHandsList();
            var strongestHand = Calculate.CalculateCardsValues(Table.ShowCardsOnTable(),
                CardsOnHands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.Strength == CardRankings.RankA);
        }
        [TestMethod]
        public void Strongest_Hand_With_Pair()
        {
            Input.GetInput("4c3s9h8s7s 3dQh JhTh KhAh");
            Table.GetCardsOnTable();
            CardsOnHands.AddCardsToHandsList();
            var strongestHand = Calculate.CalculateCardsValues(Table.ShowCardsOnTable(),
                CardsOnHands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.Pair &&
                          strongestHand.GetCards()[0].CardValue == CardRankings.Rank3);
        }
        [TestMethod]
        public void Strongest_Hand_With_Two_Hands_Pair()
        {
            Input.GetInput("4c3s9h8s7s 3dQh 4hTh KhAh");
            Table.GetCardsOnTable();
            CardsOnHands.AddCardsToHandsList();
            var strongestHand = Calculate.CalculateCardsValues(Table.ShowCardsOnTable(),
                CardsOnHands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.Pair &&
                          strongestHand.GetCards()[0].CardValue == CardRankings.Rank4);
        }
        [TestMethod]
        public void Strongest_Hand_With_Two_Hands_Equal_Pairs_But_Highest_Hand()
        {
            Input.GetInput("4c3s9h8s7s 3dQh 3hTh KhAh");
            Table.GetCardsOnTable();
            CardsOnHands.AddCardsToHandsList();
            var strongestHand = Calculate.CalculateCardsValues(Table.ShowCardsOnTable(),
                CardsOnHands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.Pair &&
                          strongestHand.GetCards()[1].CardValue == CardRankings.RankQ);
        }
        [TestMethod]
        public void Strongest_Hand_With_Three_Hands_Equal_Pairs_But_Highest_Hand()
        {
            Input.GetInput("4c3s9h8s7s 3dQh 3hTh 3cAh");
            Table.GetCardsOnTable();
            CardsOnHands.AddCardsToHandsList();
            var strongestHand = Calculate.CalculateCardsValues(Table.ShowCardsOnTable(),
                CardsOnHands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.Pair &&
                          strongestHand.GetCards()[1].CardValue == CardRankings.RankA);
        }
        [TestMethod]
        public void Strongest_Hand_With_Two_Pairs()
        {
            Input.GetInput("4c3s9h8s7s 3d9h 3h4h QcAh");
            Table.GetCardsOnTable();
            CardsOnHands.AddCardsToHandsList();
            var strongestHand = Calculate.CalculateCardsValues(Table.ShowCardsOnTable(),
                CardsOnHands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.TwoPair &&
                          strongestHand.GetCards()[1].CardValue == CardRankings.Rank9);
        }
        [TestMethod]
        public void Strongest_Hand_With_Two_Pairs_Equal_Pair_Value()
        {
            Input.GetInput("4c3s9h8s7s 3d9h 3h9h QcAh");
            Table.GetCardsOnTable();
            CardsOnHands.AddCardsToHandsList();
            var strongestHand = Calculate.CalculateCardsValues(Table.ShowCardsOnTable(),
                CardsOnHands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.TwoPair &&
                          strongestHand.GetCards()[1].CardValue == CardRankings.Rank9);
        }
    }
}
