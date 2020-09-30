using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01;

namespace UnitTestProject
{
    [TestClass]
    public class TableTest
    {
        private ITable Table;
        private IGetInput Input;

        public TableTest()
        {
            Input = new InputCards();
            Table = new Table(Input);
            
        }
        [TestMethod]
        public void Five_Cards_On_Table()
        {
            Input.GetInput("4cKs4h8s7s Ad4s Ac4d As9s KhKd 5d6d");
            Table.GetCardsOnTable();
            Assert.IsTrue(Table.ShowCardsOnTable().Count == 5);
        }
        [TestMethod]
        public void For_Cards_On_Table()
        {
            Input.GetInput("4cKs4h8s Ad4s Ac4d As9s KhKd 5d6d");
            Table.GetCardsOnTable();
            Assert.IsTrue(Table.ShowCardsOnTable().Count == 4);
        }
        [TestMethod]
        public void Three_Cards_On_Table()
        {
            Input.GetInput("4cKs4h Ad4s Ac4d As9s KhKd 5d6d");
            Table.GetCardsOnTable();
            Assert.IsTrue(Table.ShowCardsOnTable().Count == 3);
        }
        [TestMethod]
        public void Valid_Card_Values_First_Item()
        {
            Input.GetInput("4cKs4h8s7s Ad4s Ac4d As9s KhKd 5d6d");
            Table.GetCardsOnTable();
            Assert.IsTrue(Table.ShowCardsOnTable()[0].Rank == '4'
            && Table.ShowCardsOnTable()[0].Suit == 'c');
        }
        [TestMethod]
        public void Valid_Card_Values_Last_Item()
        {
            Input.GetInput("4cKs4h8s7s Ad4s Ac4d As9s KhKd 5d6d");
            Table.GetCardsOnTable();
            Assert.IsTrue(Table.ShowCardsOnTable()[4].Rank == '7'
                          && Table.ShowCardsOnTable()[4].Suit == 's');
        }
    }
}
