using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01.CardSets;
using Texas_holdem_engine_01.Interfaces;

namespace UnitTestProject
{
    [TestClass]
    public class TableTest
    {
        private readonly ITable _table;

        public TableTest()
        {
            _table = new Table();
            
        }
        [TestMethod]
        public void Five_Cards_On_Table()
        {
            _table.GetCardsOnTable("4cKs4h8s7s");
            Assert.IsTrue(_table.ShowCardsOnTable().Count == 5);
        }
        [TestMethod]
        public void For_Cards_On_Table()
        {
            _table.GetCardsOnTable("4cKs4h8s");
            Assert.IsTrue(_table.ShowCardsOnTable().Count == 4);
        }
        [TestMethod]
        public void Three_Cards_On_Table()
        {
            _table.GetCardsOnTable("4cKs4h");
            Assert.IsTrue(_table.ShowCardsOnTable().Count == 3);
        }
        [TestMethod]
        public void Valid_Card_Values_First_Item()
        {
            _table.GetCardsOnTable("4cKs4h8s7s");
            Assert.IsTrue(_table.ShowCardsOnTable()[0].Rank == '4'
                          && _table.ShowCardsOnTable()[0].Suit == 'c');
        }
        [TestMethod]
        public void Valid_Card_Values_Last_Item()
        {
            _table.GetCardsOnTable("4cKs4h8s7s");
            Assert.IsTrue(_table.ShowCardsOnTable()[4].Rank == '7'
                          && _table.ShowCardsOnTable()[4].Suit == 's');
        }
    }
}
