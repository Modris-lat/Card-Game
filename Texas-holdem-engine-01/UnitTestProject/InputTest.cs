using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texas_holdem_engine_01;
using Texas_holdem_engine_01.Interfaces;

namespace UnitTestProject
{
    [TestClass]
    public class InputTest
    {
        private IGetInput Input;

        public InputTest()
        {
            Input = new InputCards();
        }
        [TestMethod]
        public void GetInput()
        {
            Input.GetInput("4cKs4h8s7s Ad4s Ac4d As9s KhKd 5d6d");
            var list = Input.ShowInput();
            Assert.IsTrue(string.Join(",",list) == "4cKs4h8s7s,Ad4s,Ac4d,As9s,KhKd,5d6d");
        }
    }
}
