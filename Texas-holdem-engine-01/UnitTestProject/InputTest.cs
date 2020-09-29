using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01;

namespace UnitTestProject
{
    [TestClass]
    public class InputTest
    {
        private IGetInput Input;

        public InputTest()
        {
            Input = new Input();
        }
        [TestMethod]
        public void GetInput()
        {
            var list = Input.GetInput("4cKs4h8s7s Ad4s Ac4d As9s KhKd 5d6d");
            Assert.IsTrue(string.Join(",",list) == "4cKs4h8s7s,Ad4s,Ac4d,As9s,KhKd,5d6d");
        }
    }
}
