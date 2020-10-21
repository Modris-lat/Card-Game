using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01;
using Texas_holdem_engine_01.CardSets;
using Texas_holdem_engine_01.StaticGetValues;
using Texas_holdem_engine_01.StaticGetValues.CheckThreeAndFourKind;

namespace UnitTestProject
{
    [TestClass]
    public class CheckThreeAndFourOfKindTest
    {
        [TestMethod]
        public void One_Trio_True()
        {
            var cardList = new List<Card>
            {
                new Card('2', 's'), new Card('J', 's'),
                new Card('4', 's'), new Card('J', 's'),
                new Card('6', 's'), new Card('J', 'd')
            };
            Assert.IsTrue(CheckThreeAndFourKind.ThreeAndFourOfKind(cardList).ThreeKind);
        }
        [TestMethod]
        public void Two_Trio_Value()
        {
            var cardList = new List<Card>
            {
                new Card('2', 's'), new Card('J', 's'),
                new Card('2', 's'), new Card('J', 's'),
                new Card('2', 's'), new Card('J', 'd')
            };
            Assert.IsTrue(CheckThreeAndFourKind.ThreeAndFourOfKind(cardList).ThreeKindValue == CardRankings.RankJ);
        }
        [TestMethod]
        public void FourKind_Low()
        {
            var cardList = new List<Card>
            {
                new Card('2', 's'), new Card('2', 's'),
                new Card('2', 's'), new Card('J', 's'),
                new Card('2', 's'), new Card('J', 'd')
            };
            Assert.IsTrue(CheckThreeAndFourKind.ThreeAndFourOfKind(cardList).FourKind);
        }
        [TestMethod]
        public void FourKind_High_Value()
        {
            var cardList = new List<Card>
            {
                new Card('2', 's'), new Card('J', 's'),
                new Card('2', 's'), new Card('J', 's'),
                new Card('J', 's'), new Card('J', 'd')
            };
            Assert.IsTrue(CheckThreeAndFourKind.ThreeAndFourOfKind(cardList).FourKindValue == CardRankings.RankJ);
        }
    }
}
