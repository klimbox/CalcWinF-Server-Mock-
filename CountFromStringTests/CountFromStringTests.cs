using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CountFromString.Tests
{
    [TestClass()]
    public class CountFromStringTests
    {
        [DataTestMethod]
        [DataRow(1, 2, '+', 3)]
        [DataRow(1, 2, '-', -1)]
        [DataRow(12, 3, '/', 4)]
        [DataRow(0, 2, '*', 0)]

        [TestMethod()]
        public void OperationDataDrivenTest(int a, int b, char o, int expected)
        {
            int actual = CountFromString.Operation(a, b, o);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Invalid operation")]
        public void OperationExeptionTest()
        {
            CountFromString.Operation(0, 0, 'x');
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException), "Divide by zero")]
        public void Operation_d0_ExeptionTest()
        {
            CountFromString.Operation(0, 0, '/');
        }

        [DataTestMethod]
        [DataRow("1", "2", "+", 3)]
        [DataRow("1", "2", "-", -1)]
        [DataRow("12", "3", "/", 4)]
        [DataRow("0", "2", "*", 0)]

        [TestMethod()]
        public void InputDataDrivenTest(string a, string b, string o, int expected)
        {
            int actual = CountFromString.Input(a, b, o);

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow("1 + 2", 3)]
        [DataRow("1 - 2", -1)]
        [DataRow("12 / 3", 4)]
        [DataRow("0 * 2", 0)]

        [TestMethod()]
        public void ComplexInputDataDrivenTest(string input, int expected)
        {
            int actual = CountFromString.Input(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Invalid input")]
        public void ComplesInputExeptionTest()
        {
            CountFromString.Input("sdawsddasd asdaw a");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Invalid input")]
        public void InputExeptionTest()
        {
            CountFromString.Input("a", "b", "+");
        }
    }
}