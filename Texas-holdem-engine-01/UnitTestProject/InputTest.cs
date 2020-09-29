using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01;

namespace UnitTestProject
{
    [TestClass]
    public class InputTest
    {
        private IGetInput firstClass;

        public InputTest()
        {
            firstClass = new Input();
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
