using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Engine;
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
    }
}
