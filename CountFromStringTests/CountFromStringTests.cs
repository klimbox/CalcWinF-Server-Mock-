using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CountFromString.Tests
{
    [TestClass()]
    public class CountFromStringTests
    {
        private ICalculation c = new ServerCalculation();
       
        [DataTestMethod]
        [DataRow("1", "2", "+", 3)]
        [DataRow("1", "2", "-", -1)]
        [DataRow("12", "3", "/", 4)]
        [DataRow("0", "2", "*", 0)]

        [TestMethod()]
        public void InputDataDrivenTest(string a, string b, string o, int expected)
        {
            int actual = c.Calculate(a, b, o);

            Assert.AreEqual(expected, actual);
        }
        
    }
}