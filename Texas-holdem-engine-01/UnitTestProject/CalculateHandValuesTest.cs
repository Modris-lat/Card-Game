using System.Collections.Generic;
using Engine.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01.CardSets;
using Texas_holdem_engine_01.Interfaces;
using Texas_holdem_engine_01.StaticGetValues;

namespace UnitTestProject
{
    [TestClass]
    public class CalculateHandValuesTest
    {
        private readonly ITable _table;
        private readonly ICardsOnHandsList _hands;
        private readonly ICalculateHandValues _calculate;

        public CalculateHandValuesTest()
        {
            _table = new Table();
            _hands = new CardsOnHandsList();
            _calculate = new CalculateHandValues();
        }
        [TestMethod]
        public void Strongest_Hand_With_Highest_Card_K()
        {
            _table.GetCardsOnTable("4c3s9h8s7s");
            _hands.AddHands(new List<string>{"KdJc", "2cQd"});
            var strongestHand = _calculate.CalculateCardsValues(
                _table.ShowCardsOnTable(), _hands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.HighCard == CardRankings.RankK);
        }
        [TestMethod]
        public void Strongest_Hand_With_Highest_Card_A()
        {
            _table.GetCardsOnTable("4c3s9h8s7s");
            _hands.AddHands(new List<string> { "AdJc", "2cQd" });
            var strongestHand = _calculate.CalculateCardsValues(
                _table.ShowCardsOnTable(), _hands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.HighCard == CardRankings.RankA);
        }
        [TestMethod]
        public void Strongest_Hand_With_Highest_Card_J()
        {
            _table.GetCardsOnTable("4c3s9h8s7s");
            _hands.AddHands(new List<string> { "5dJc", "2cTd" });
            var strongestHand = _calculate.CalculateCardsValues(
                _table.ShowCardsOnTable(), _hands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.HighCard == CardRankings.RankJ);
        }
        [TestMethod]
        public void Strongest_Hand_With_Highest_Card_With_Many_Hands()
        {
            _table.GetCardsOnTable("4c3s9h8s7s");
            _hands.AddHands(new List<string>
            {
                "5dTc", "2cTd", "6dAc", "KcQd", "KsQh", "JhTh", "KhQh"
            });
            var strongestHand = _calculate.CalculateCardsValues(
                _table.ShowCardsOnTable(), _hands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.HighCard == CardRankings.RankA);
        }
        [TestMethod]
        public void Strongest_Hand_With_Pair()
        {
            _table.GetCardsOnTable("4c3s9h8s7s");
            _hands.AddHands(new List<string>
            {
                "3dQh", "JhTh", "KhAh"
            });
            var strongestHand = _calculate.CalculateCardsValues(
                _table.ShowCardsOnTable(), _hands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.Pair && strongestHand.GetCards()[0].CardValue == CardRankings.Rank3);
        }
        [TestMethod]
        public void Strongest_Hand_With_Two_Hands_Pair()
        {
            _table.GetCardsOnTable("4c3s9h8s7s");
            _hands.AddHands(new List<string>
            {
                "3dQh", "4hTh", "KhAh"
            });
            var strongestHand = _calculate.CalculateCardsValues(
                _table.ShowCardsOnTable(), _hands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.Pair && strongestHand.GetCards()[0].CardValue == CardRankings.Rank4);
        }
        [TestMethod]
        public void Strongest_Hand_With_Two_Hands_Equal_Pairs_But_Highest_Hand()
        {
            _table.GetCardsOnTable("4c3s9h8s7s");
            _hands.AddHands(new List<string>
            {
                "3dQh", "3hTh", "KhAh"
            });
            var strongestHand = _calculate.CalculateCardsValues(
                _table.ShowCardsOnTable(), _hands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.Pair &&
                          strongestHand.GetCards()[1].CardValue == CardRankings.RankQ);
        }
        [TestMethod]
        public void Strongest_Hand_With_Three_Hands_Equal_Pairs_But_Highest_Hand()
        {
            _table.GetCardsOnTable("4c3s9h8s7s");
            _hands.AddHands(new List<string>
            {
                "3dQh", "3hTh", "3cAh"
            });
            var strongestHand = _calculate.CalculateCardsValues(
                _table.ShowCardsOnTable(), _hands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.Pair &&
                          strongestHand.GetCards()[1].CardValue == CardRankings.RankA);
        }
        [TestMethod]
        public void Strongest_Hand_With_Two_Pairs()
        {
            _table.GetCardsOnTable("4c3s9h8s7s");
            _hands.AddHands(new List<string>
            {
                "3d9h", "3h4h", "QcAh"
            });
            var strongestHand = _calculate.CalculateCardsValues(
                _table.ShowCardsOnTable(), _hands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.TwoPair &&
                          strongestHand.GetCards()[1].CardValue == CardRankings.Rank9);
        }
        [TestMethod]
        public void Strongest_Hand_With_Two_Pairs_Equal_Pair_Value()
        {
            _table.GetCardsOnTable("4c3s9h8s7s");
            _hands.AddHands(new List<string>
            {
                "3d9h", "3h9h", "QcAh"
            });
            var strongestHand = _calculate.CalculateCardsValues(
                _table.ShowCardsOnTable(), _hands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.TwoPair &&
                          strongestHand.GetCards()[1].CardValue == CardRankings.Rank9);
        }
        [TestMethod]
        public void Strongest_Hand_With_ThreeOfKind()
        {
            _table.GetCardsOnTable("4c3s9h8s7s");
            _hands.AddHands(new List<string>
            {
                "3d3h", "JhKh", "QcAh"
            });
            var strongestHand = _calculate.CalculateCardsValues(
                _table.ShowCardsOnTable(), _hands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.ThreeOfKind &&
                          strongestHand.GetCards()[1].CardValue == CardRankings.Rank3);
        }
        [TestMethod]
        public void Strongest_Hand_With_ThreeOfKind_In_Two_Hands()
        {
            _table.GetCardsOnTable("4c3s9h8s7s");
            _hands.AddHands(new List<string>
            {
                "3d3h", "JhKh", "9c9s"
            });
            var strongestHand = _calculate.CalculateCardsValues(
                _table.ShowCardsOnTable(), _hands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.ThreeOfKind &&
                          strongestHand.GetCards()[1].CardValue == CardRankings.Rank9);
        }
        [TestMethod]
        public void Strongest_Hand_With_ThreeOfKind_In_Two_Hands_Equal()
        {
            _table.GetCardsOnTable("4c3s9h9s7s");
            _hands.AddHands(new List<string>
            {
                "9d3h", "JhKh", "9cAs"
            });
            var strongestHand = _calculate.CalculateCardsValues(
                _table.ShowCardsOnTable(), _hands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.ThreeOfKind && strongestHand.FullHouse && strongestHand.Id == 0);
        }
        [TestMethod]
        public void Strongest_Hand_With_FourOfKind_False()
        {
            _table.GetCardsOnTable("4c3s9h9s7s");
            _hands.AddHands(new List<string>
            {
                "9d3h", "JhKh", "9cAs"
            });
            var strongestHand = _calculate.CalculateCardsValues(
                _table.ShowCardsOnTable(), _hands.ShowCardsOnHandsList());
            Assert.IsFalse(strongestHand.FourOfKind);
        }
        [TestMethod]
        public void Strongest_Hand_With_FourOfKind_True()
        {
            _table.GetCardsOnTable("3c3s9h9s7s");
            _hands.AddHands(new List<string>
            {
                "3d3h", "JhKh", "9cAs"
            });
            var strongestHand = _calculate.CalculateCardsValues(
                _table.ShowCardsOnTable(), _hands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.FourOfKind);
        }
        [TestMethod]
        public void Strongest_Hand_With_Two_FourOfKind_True()
        {
            _table.GetCardsOnTable("3c3s9h9s7s");
            _hands.AddHands(new List<string>
            {
                "3d3h", "JhKh", "9c9d"
            });
            var strongestHand = _calculate.CalculateCardsValues(
                _table.ShowCardsOnTable(), _hands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.FourOfKind && strongestHand.Id == 2);
        }
        [TestMethod]
        public void Strongest_Hand_With_Straight()
        {
            _table.GetCardsOnTable("3c5s9h6s7s");
            _hands.AddHands(new List<string>
            {
                "3d3h", "JhKh", "8c9d"
            });
            var strongestHand = _calculate.CalculateCardsValues(
                _table.ShowCardsOnTable(), _hands.ShowCardsOnHandsList());
            Assert.IsTrue(strongestHand.Straight && strongestHand.Id == 2);
        }
    }
}
