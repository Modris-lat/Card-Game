using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Engine;
using Engine.Interfaces;
using Engine.Models;
using Engine.Rankings;
using Engine.Services;

namespace Unit.Testing
{
    [TestClass]
    public class GetCardsTest
    {
        private readonly IGetCards _getCards;

        public GetCardsTest()
        {
            _getCards = new GetCards();
        }
        [TestMethod]
        public void Valid_Input_Count()
        {
            var input = new GameInput
            {
                Table = "4cKs4h8s7s",
                Hands = new List<string>
                {
                    "Ad4s",
                    "Ac4d",
                    "As9s",
                    "KhKd",
                    "5d6d"
                }
            };
            var result = _getCards.ConvertInput(input);
            Assert.IsTrue(result.Item1.Count == 5 && result.Item2.Count == 5);
        }
        [TestMethod]
        public void Valid_Input_Content()
        {
            var input = new GameInput
            {
                Table = "4cKs4h8s7s",
                Hands = new List<string>
                {
                    "Ad4s",
                    "Ac4d",
                    "As9s",
                    "KhKd",
                    "5d6d"
                }
            };
            var result = _getCards.ConvertInput(input);
            Assert.IsTrue(result.Item1[1].CardValue == CardRankings.RankK && result.Item1[1].Suit == 's' &&
                          result.Item2[1].Id == 1 && result.Item2[1].Cards[0].Rank == 'A');
        }
    }
}
