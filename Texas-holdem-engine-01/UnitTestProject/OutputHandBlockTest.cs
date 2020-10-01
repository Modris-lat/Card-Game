using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01;
using Texas_holdem_engine_01.Interfaces;

namespace UnitTestProject
{
    [TestClass]
    public class OutputHandBlockTest
    {
        private IOutput Output;
        private ITable Table;
        private ICardsOnHandsList CardsOnHands;
        private IGetInput Input;

        public OutputHandBlockTest()
        {
            Input = new InputCards();
            Table = new Table(Input);
            CardsOnHands = new CardsOnHandsList(Input);
            Output = new OutputHandBlock(Table, CardsOnHands);
        }
        [TestMethod]
        public void Valid_Output_Five_Hands()
        {
            Input.GetInput("4cKs4h8s7s Ad4s Ac4d As9s KhKd 5d6d");
            Table.GetCardsOnTable();
            CardsOnHands.AddCardsToHandsList();
            Assert.IsTrue(Output.Output() == "Ac4d=Ad4s 5d6d As9s KhKd");
        }
        [TestMethod]
        public void Valid_Output_Two_Hands()
        {
            Input.GetInput("2h3h4h5d8d KdKs 9hJh");
            Table.GetCardsOnTable();
            CardsOnHands.AddCardsToHandsList();
            Assert.IsTrue(Output.Output() == "KdKs 9hJh");
        }
    }
}
