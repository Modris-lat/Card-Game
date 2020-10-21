using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01;
using Texas_holdem_engine_01.CardSets;
using Texas_holdem_engine_01.StaticGetValues;

namespace UnitTestProject
{
    [TestClass]
    public class SetCardValuesTest
    {
        [TestMethod]
        public void Card_Value_True()
        {
            var card = new Card('K', 's');
            card.SetCardValue();
            Assert.IsTrue(card.CardValue == CardRankings.RankK);
        }
        [TestMethod]
        public void Card_Value_False()
        {
            var card = new Card('K', 's');
            card.SetCardValue();
            Assert.IsFalse(card.CardValue == CardRankings.RankJ);
        }
    }
}
