using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01;
using Texas_holdem_engine_01.CardSets;
using Texas_holdem_engine_01.Interfaces;

namespace UnitTestProject
{
    [TestClass]
    public class OutputHandBlockTest
    {
        private IOutput Output;
        private readonly ITable Table;
        private readonly ICardsOnHandsList CardsOnHands;
        private readonly IGetInput Input;
        private ICalculateHandValues Calculate;

        public OutputHandBlockTest()
        {
            Input = new InputCards();
            Table = new Table(Input);
            CardsOnHands = new CardsOnHandsList(Input);
            Calculate = new CalculateHandValues();
            Output = new OutputHandBlock(Table, CardsOnHands, Calculate);
        }
        [TestMethod]
        public void Valid_Output_Five_Hands_If_Equal_Strength()
        {
            Input.GetInput("4cKs4h8s7s Ad4s Ac4d As9s KhKd 5d6d");
            Table.GetCardsOnTable();
            CardsOnHands.AddCardsToHandsList();
            Output.GetOutput();
            Assert.IsTrue(Output.Output() == "Ac4d=Ad4s 5d6d As9s KhKd");
        }
        [TestMethod]
        public void Valid_Output_Two_Hands()
        {
            Input.GetInput("2h3h4h5d8d KdKs 9hJh");
            Table.GetCardsOnTable();
            CardsOnHands.AddCardsToHandsList();
            Output.GetOutput();
            Assert.IsTrue(Output.Output() == "KdKs 9hJh");
        }
        [TestMethod]
        public void Valid_Output_Three_Hands()
        {
            Input.GetInput("2h3h4h5d8d KdKs 9hJh TsQc");
            Table.GetCardsOnTable();
            CardsOnHands.AddCardsToHandsList();
            Output.GetOutput();
            Assert.IsTrue(Output.Output() == "TsQc KdKs 9hJh");
        }
    }
}
