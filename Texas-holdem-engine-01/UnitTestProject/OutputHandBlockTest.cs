using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01;
using Texas_holdem_engine_01.CardSets;
using Texas_holdem_engine_01.Interfaces;

namespace UnitTestProject
{
    [TestClass]
    public class OutputHandBlockTest
    {
        private readonly IOutput _output;
        private readonly ITable _table;
        private readonly ICardsOnHandsList _hands;
        private readonly ICalculateHandValues _calculate;

        public OutputHandBlockTest()
        {
            _table = new Table();
            _hands = new CardsOnHandsList();
            _calculate = new CalculateHandValues();
            _output = new OutputHandBlock(_table, _hands, _calculate);
        }
        [TestMethod]
        public void Valid_Output_Five_Hands_If_Equal_Strength()
        {
            _table.GetCardsOnTable("4cKs4h8s7s");
            _hands.AddHands(
                new List<string>
            {
                "Ad4s",
                "Ac4d",
                "As9s",
                "KhKd",
                "5d6d"
            });
            _output.GetOutput();
            Assert.IsTrue(_output.Output() == "Ac4d=Ad4s 5d6d As9s KhKd");
        }
        [TestMethod]
        public void Valid_Output_Two_Hands()
        {
            _table.GetCardsOnTable("2h3h4h5d8d");
            _hands.AddHands(
                new List<string>
                {
                    "KdKs",
                    "9hJh"
                });
            _output.GetOutput();
            Assert.IsTrue(_output.Output() == "KdKs 9hJh");
        }
        [TestMethod]
        public void Valid_Output_Three_Hands()
        {
            _table.GetCardsOnTable("2h3h4h5d8d");
            _hands.AddHands(
                new List<string>
                {
                    "KdKs",
                    "9hJh",
                    "TsQc"
                });
            _output.GetOutput();
            Assert.IsTrue(_output.Output() == "TsQc KdKs 9hJh");
        }
    }
}
