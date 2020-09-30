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
            var cardsOnTable = Input.ShowInput();
            Assert.IsTrue(string.Join(",", Table.GetCardsOnTable()) == "4c,Ks,4h,8s,7s");
        }
        [TestMethod]
        public void For_Cards_On_Table()
        {
            Input.GetInput("4cKs4h8s Ad4s Ac4d As9s KhKd 5d6d");
            var cardsOnTable = Input.ShowInput();
            Assert.IsTrue(string.Join(",", Table.GetCardsOnTable()) == "4c,Ks,4h,8s");
        }
        [TestMethod]
        public void Three_Cards_On_Table()
        {
            Input.GetInput("4cKs4h Ad4s Ac4d As9s KhKd 5d6d");
            var cardsOnTable = Input.ShowInput();
            Assert.IsTrue(string.Join(",", Table.GetCardsOnTable()) == "4c,Ks,4h");
        }
    }
}
