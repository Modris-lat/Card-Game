using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Engine.Interfaces;
using Engine.Models;
using Engine.Rankings;
using Engine.Services;

namespace Unit.Testing
{
    [TestClass]
    public class GetHandValuesTest
    {
        private readonly IGetHandValues _getValues;

        public GetHandValuesTest() { _getValues = new GetHandValues(); }
        [TestMethod]
        public void Test_RoyalFlush_True()
        {
            var table = new List<Card>
            {
                new Card('A', 's'),
                new Card('K', 's'),
                new Card('Q', 's'),
                new Card('2', 'd'),
                new Card('3', 'd')
            };
            var hands = new List<Hand>
            {
                new Hand(0, new List<Card> {new Card('4', 'd'), new Card('5', 'd')}),
                new Hand(1, new List<Card> {new Card('J', 's'), new Card('T', 's')}),
                new Hand(2, new List<Card> {new Card('T', 'c'), new Card('9', 'c')})
            };
            var result = _getValues.Calculate(table, hands).ToList();
            Assert.IsTrue(result[0].Id == 1 && result[0].HandStrength == HandRankings.RoyalFlush);
        }
        [TestMethod]
        public void Test_StraightFlush_True()
        {
            var table = new List<Card>
            {
                new Card('J', 's'),
                new Card('K', 's'),
                new Card('Q', 's'),
                new Card('2', 'd'),
                new Card('3', 'd')
            };
            var hands = new List<Hand>
            {
                new Hand(0, new List<Card> {new Card('4', 'd'), new Card('5', 'd')}),
                new Hand(1, new List<Card> {new Card('9', 's'), new Card('T', 's')}),
                new Hand(2, new List<Card> {new Card('T', 'c'), new Card('9', 'c')})
            };
            var result = _getValues.Calculate(table, hands).ToList();
            Assert.IsTrue(result[0].Id == 1 && result[0].HandStrength == HandRankings.StraightFlush);
        }
        [TestMethod]
        public void Test_FourOfKind_True()
        {
            var table = new List<Card>
            {
                new Card('J', 's'),
                new Card('T', 'd'),
                new Card('T', 's'),
                new Card('2', 'd'),
                new Card('3', 'd')
            };
            var hands = new List<Hand>
            {
                new Hand(0, new List<Card> {new Card('4', 'd'), new Card('5', 'd')}),
                new Hand(1, new List<Card> {new Card('9', 's'), new Card('4', 's')}),
                new Hand(2, new List<Card> {new Card('T', 'h'), new Card('T', 'c')})
            };
            var result = _getValues.Calculate(table, hands).ToList();
            Assert.IsTrue(result[0].Id == 2 && result[0].HandStrength == HandRankings.FourOfAKind + CardRankings.RankT);
        }
        [TestMethod]
        public void Test_FourOfKind_VS_FourOfKind()
        {
            var table = new List<Card>
            {
                new Card('J', 's'),
                new Card('T', 'd'),
                new Card('T', 's'),
                new Card('J', 'c'),
                new Card('3', 'd')
            };
            var hands = new List<Hand>
            {
                new Hand(0, new List<Card> {new Card('4', 'd'), new Card('5', 'd')}),
                new Hand(1, new List<Card> {new Card('J', 'd'), new Card('J', 'h')}),
                new Hand(2, new List<Card> {new Card('T', 'h'), new Card('T', 'c')})
            };
            var result = _getValues.Calculate(table, hands).ToList();
            Assert.IsTrue(result[1].Id == 2 &&
                          result[1].HandStrength == HandRankings.FourOfAKind + CardRankings.RankT &&
                          result[0].Id == 1 &&
                          result[0].HandStrength == HandRankings.FourOfAKind + CardRankings.RankJ);
        }
        [TestMethod]
        public void Test_RoyalFlush_VS_StraightFlush_VS_FourOfKind()
        {
            var table = new List<Card>
            {
                new Card('J', 's'),
                new Card('T', 'd'),
                new Card('T', 's'),
                new Card('Q', 's'),
                new Card('3', 'd')
            };
            var hands = new List<Hand>
            {
                new Hand(0, new List<Card> {new Card('9', 's'), new Card('8', 's')}),
                new Hand(1, new List<Card> {new Card('A', 's'), new Card('K', 's')}),
                new Hand(2, new List<Card> {new Card('T', 'h'), new Card('T', 'c')})
            };
            var result = _getValues.Calculate(table, hands).ToList();
            Assert.IsTrue(result[0].Id == 1 && result[0].HandStrength == HandRankings.RoyalFlush &&
                          result[1].Id == 0 && result[1].HandStrength == HandRankings.StraightFlush &&
                          result[2].Id == 2 && result[2].HandStrength == HandRankings.FourOfAKind + CardRankings.RankT);
        }
        [TestMethod]
        public void Test_FullHouse_True()
        {
            var table = new List<Card>
            {
                new Card('K', 'h'),
                new Card('A', 'd'),
                new Card('A', 's'),
                new Card('2', 'h'),
                new Card('3', 'd')
            };
            var hands = new List<Hand>
            {
                new Hand(0, new List<Card> {new Card('9', 's'), new Card('8', 's')}),
                new Hand(1, new List<Card> {new Card('A', 's'), new Card('K', 's')}),
                new Hand(2, new List<Card> {new Card('9', 'h'), new Card('T', 'c')})
            };
            var result = _getValues.Calculate(table, hands).ToList();
            Assert.IsTrue(result[0].Id == 1 && result[0].HandStrength == HandRankings.FullHouse + CardRankings.RankA);
        }
        [TestMethod]
        public void Test_FullHouse_VS_FullHouse()
        {
            var table = new List<Card>
            {
                new Card('8', 'h'),
                new Card('T', 'd'),
                new Card('Q', 's'),
                new Card('Q', 'h'),
                new Card('Q', 'd')
            };
            var hands = new List<Hand>
            {
                new Hand(0, new List<Card> {new Card('9', 's'), new Card('8', 's')}),
                new Hand(1, new List<Card> {new Card('A', 'c'), new Card('A', 's')}),
                new Hand(2, new List<Card> {new Card('K', 'c'), new Card('K', 'd')})
            };
            var result = _getValues.Calculate(table, hands).ToList();
            Assert.IsTrue(result[0].Id == 1 && result[0].HandStrength == HandRankings.FullHouse + CardRankings.RankA &&
                          result[1].Id == 2 && result[1].HandStrength == HandRankings.FullHouse + CardRankings.RankK);
        }
        [TestMethod]
        public void Test_Flush_True()
        {
            var table = new List<Card>
            {
                new Card('9', 's'),
                new Card('T', 's'),
                new Card('Q', 's'),
                new Card('Q', 'h'),
                new Card('Q', 'd')
            };
            var hands = new List<Hand>
            {
                new Hand(0, new List<Card> {new Card('3', 's'), new Card('8', 's')}),
                new Hand(1, new List<Card> {new Card('A', 'c'), new Card('A', 's')}),
                new Hand(2, new List<Card> {new Card('K', 'c'), new Card('K', 'd')})
            };
            var result = _getValues.Calculate(table, hands).ToList();
            Assert.IsTrue(result[0].Id == 1 && result[0].HandStrength == HandRankings.FullHouse + CardRankings.RankA &&
                          result[1].Id == 2 && result[1].HandStrength == HandRankings.FullHouse + CardRankings.RankK &&
                          result[2].Id == 0 && result[2].HandStrength == HandRankings.Flush + CardRankings.RankQ);
        }
        [TestMethod]
        public void Test_Straight_True()
        {
            var table = new List<Card>
            {
                new Card('9', 's'),
                new Card('T', 's'),
                new Card('Q', 's'),
                new Card('Q', 'h'),
                new Card('Q', 'd')
            };
            var hands = new List<Hand>
            {
                new Hand(0, new List<Card> {new Card('3', 's'), new Card('8', 's')}),
                new Hand(1, new List<Card> {new Card('A', 'c'), new Card('A', 's')}),
                new Hand(2, new List<Card> {new Card('K', 'c'), new Card('K', 'd')}),
                new Hand(3, new List<Card> {new Card('J', 'c'), new Card('K', 'h')})
            };
            var result = _getValues.Calculate(table, hands).ToList();
            Assert.IsTrue(result[0].Id == 1 && result[0].HandStrength == HandRankings.FullHouse + CardRankings.RankA &&
                          result[1].Id == 2 && result[1].HandStrength == HandRankings.FullHouse + CardRankings.RankK &&
                          result[2].Id == 0 && result[2].HandStrength == HandRankings.Flush + CardRankings.RankQ &&
                          result[3].Id == 3 && result[3].HandStrength == HandRankings.Straight + CardRankings.RankK);
        }
        [TestMethod]
        public void Test_ThreeOfKind_True()
        {
            var table = new List<Card>
            {
                new Card('9', 's'),
                new Card('T', 's'),
                new Card('Q', 's'),
                new Card('Q', 'h'),
                new Card('Q', 'd')
            };
            var hands = new List<Hand>
            {
                new Hand(0, new List<Card> {new Card('3', 's'), new Card('8', 's')}),
                new Hand(1, new List<Card> {new Card('A', 'c'), new Card('A', 's')}),
                new Hand(2, new List<Card> {new Card('K', 'c'), new Card('K', 'd')}),
                new Hand(3, new List<Card> {new Card('J', 'c'), new Card('K', 'h')}),
                new Hand(4, new List<Card> {new Card('2', 'c'), new Card('3', 'h')})
            };
            var result = _getValues.Calculate(table, hands).ToList();
            Assert.IsTrue(result[0].Id == 1 && result[0].HandStrength == HandRankings.FullHouse + CardRankings.RankA &&
                          result[1].Id == 2 && result[1].HandStrength == HandRankings.FullHouse + CardRankings.RankK &&
                          result[2].Id == 0 && result[2].HandStrength == HandRankings.Flush + CardRankings.RankQ &&
                          result[3].Id == 3 && result[3].HandStrength == HandRankings.Straight + CardRankings.RankK &&
                          result[4].Id == 4 && result[4].HandStrength == HandRankings.ThreeOfKind + CardRankings.RankQ);
        }
        [TestMethod]
        public void Test_TwoPair_True()
        {
            var table = new List<Card>
            {
                new Card('8', 'c'),
                new Card('T', 's'),
                new Card('2', 's'),
                new Card('Q', 'h'),
                new Card('3', 'd')
            };
            var hands = new List<Hand>
            {
                new Hand(0, new List<Card> {new Card('3', 's'), new Card('8', 's')}),
                new Hand(1, new List<Card> {new Card('T', 'c'), new Card('Q', 's')})
            };
            var result = _getValues.Calculate(table, hands).ToList();
            Assert.IsTrue(result[0].Id == 1 && result[0].HandStrength == HandRankings.TwoPair + CardRankings.RankQ &&
                          result[1].Id == 0 && result[1].HandStrength == HandRankings.TwoPair + CardRankings.Rank8);
        }
        [TestMethod]
        public void Test_TwoPair_VS_Pair()
        {
            var table = new List<Card>
            {
                new Card('8', 'c'),
                new Card('T', 's'),
                new Card('2', 's'),
                new Card('Q', 'h'),
                new Card('3', 'd')
            };
            var hands = new List<Hand>
            {
                new Hand(0, new List<Card> {new Card('3', 's'), new Card('8', 's')}),
                new Hand(1, new List<Card> {new Card('T', 'c'), new Card('K', 's')})
            };
            var result = _getValues.Calculate(table, hands).ToList();
            Assert.IsTrue(result[0].Id == 0 && result[0].HandStrength == HandRankings.TwoPair + CardRankings.Rank8 &&
                          result[1].Id == 1 && result[1].HandStrength == HandRankings.Pair + CardRankings.RankT);
        }
        [TestMethod]
        public void Test_HighestCard()
        {
            var table = new List<Card>
            {
                new Card('8', 'c'),
                new Card('T', 's'),
                new Card('2', 's'),
                new Card('5', 'h'),
                new Card('3', 'd')
            };
            var hands = new List<Hand>
            {
                new Hand(0, new List<Card> {new Card('J', 's'), new Card('A', 's')}),
                new Hand(1, new List<Card> {new Card('J', 'c'), new Card('K', 's')}),
                new Hand(2, new List<Card> {new Card('J', 'c'), new Card('Q', 's')}),
                new Hand(3, new List<Card> {new Card('J', 'c'), new Card('6', 's')})
            };
            var result = _getValues.Calculate(table, hands).ToList();
            Assert.IsTrue(result[0].Id == 0 && result[0].HandStrength == CardRankings.RankA &&
                          result[1].Id == 1 && result[1].HandStrength == CardRankings.RankK &&
                          result[2].Id == 2 && result[2].HandStrength == CardRankings.RankQ &&
                          result[3].Id == 3 && result[3].HandStrength == CardRankings.RankJ);
        }
        [TestMethod]
        public void Test_Straight_RankA_Same_Value()
        {
            var table = new List<Card>
            {
                new Card('Q', 'c'),
                new Card('T', 's'),
                new Card('J', 's'),
                new Card('5', 'h'),
                new Card('3', 'd')
            };
            var hands = new List<Hand>
            {
                new Hand(0, new List<Card> {new Card('K', 's'), new Card('A', 's')}),
            };
            var result = _getValues.Calculate(table, hands).ToList();
            Assert.IsTrue(result[0].Id == 0 && result[0].HandStrength == CardRankings.RankA + HandRankings.Straight);
        }
        [TestMethod]
        public void Test_Straight_RankA_Value_Is_1()
        {
            var table = new List<Card>
            {
                new Card('Q', 'c'),
                new Card('T', 's'),
                new Card('4', 's'),
                new Card('5', 'h'),
                new Card('3', 'd')
            };
            var hands = new List<Hand>
            {
                new Hand(0, new List<Card> {new Card('2', 's'), new Card('A', 's')}),
            };
            var result = _getValues.Calculate(table, hands).ToList();
            Assert.IsTrue(result[0].Id == 0 && result[0].HandStrength == CardRankings.Rank5 + HandRankings.Straight);
        }
    }
}
