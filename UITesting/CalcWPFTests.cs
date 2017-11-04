using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using System.IO;
using TestStack.White;
using TestStack.White.Factory;
using System.Diagnostics;

namespace UITesting
{
    [TestClass]
    public class CalcBtWPFTests
    {
        public TestContext TestContext { get; set; }
        static Application application;
        static Window window;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            //var applicationPath = Path.Combine("G:/ORT Course/Calc/WinF+WPF/WinF+WPF/CalcBtWPF/bin/Debug", "CalcBtWPF.exe");
            application = Application.Launch(new ProcessStartInfo(@"CalcBtWPF.exe")
            {
                WorkingDirectory = @"..\..\..\CalcBtWPF\bin\Debug",
            });
            window = application.GetWindow("Calc", InitializeOption.NoCache);
        }        

        [ClassCleanup]
        public static void ClassCleanup()
        {
            window.Close();
            application.Close();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            window.Get<TextBox>("tbScreen").Text = "";
            window.ReInitialize(InitializeOption.NoCache);
        }

        [DataTestMethod]
        [DataRow("btNum0")]
        [DataRow("btNum1")]
        [DataRow("btNum2")]
        [DataRow("btNum3")]
        [DataRow("btNum4")]
        [DataRow("btNum5")]
        [DataRow("btNum6")]
        [DataRow("btNum7")]
        [DataRow("btNum8")]
        [DataRow("btNum9")]
        [DataRow("btPlus")]
        [DataRow("btMinus")]
        [DataRow("btDiv")]
        [DataRow("btMult")]
        [DataRow("btCount")]

        [TestMethod]
        public void TestButtonsExist(string bt)
        {
            bool exist = window.Get<Button>(bt).Visible;

            Assert.IsTrue(exist);
        }

        [TestMethod]
        public void TestTBExists()
        {
            bool exist = window.Get<TextBox>("tbScreen").Visible;

            Assert.IsTrue(exist);
        }

        [DataTestMethod]
        [DataRow("btNum0", "0")]
        [DataRow("btNum1", "1")]
        [DataRow("btNum2", "2")]
        [DataRow("btNum3", "3")]
        [DataRow("btNum4", "4")]
        [DataRow("btNum5", "5")]
        [DataRow("btNum6", "6")]
        [DataRow("btNum7", "7")]
        [DataRow("btNum8", "8")]
        [DataRow("btNum9", "9")]
        [DataRow("btPlus", " + ")]
        [DataRow("btMinus", " - ")]
        [DataRow("btDiv", " / ")]
        [DataRow("btMult", " * ")]
        [DataRow("btCount", "0")]

        [TestMethod]
        public void TestButtonsSimple(string bt, string expected)
        {
            window.Get<Button>(bt).Click();

            string actual = window.Get<TextBox>("tbScreen").Text;

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow("btNum1", "btNum2", "btNum3", "123")]
        [DataRow("btNum4", "btNum5", "btNum6", "456")]
        [DataRow("btNum7", "btNum8", "btNum9", "789")]
        [DataRow("btNum0", "btNum5", "btNum7", "057")]
        [DataRow("btNum7", "btPlus", "btNum5", "7 + 5")]
        [DataRow("btNum9", "btMinus", "btNum3", "9 - 3")]
        [DataRow("btNum6", "btMult", "btNum5", "6 * 5")]
        [DataRow("btNum2", "btDiv", "btNum1", "2 / 1")]
        [DataRow("btNum5", "btMinus", "btNum9", "5 - 9")]
        [DataRow("btPlus", "btNum7", "btNum0", " + 70")]

        [TestMethod]
        public void TestButtonsCoplex(string bt1, string bt2, string bt3, string expected)
        {

            window.Get<Button>(bt1).Click();
            window.Get<Button>(bt2).Click();
            window.Get<Button>(bt3).Click();

            string actual = window.Get<TextBox>("tbScreen").Text;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ButtonCleanTest()
        {
            string expected = "";

            window.Get<TextBox>("tbScreen").Text = "1";
            window.Get<Button>("btClear").Click();

            string actual = window.Get<TextBox>("tbScreen").Text;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_5p5_10()
        {
            string expected = "10";

            window.Get<TextBox>("tbScreen").Text = "5 + 5";
            window.Get<Button>("btCount").Click();

            string actual = window.Get<TextBox>("tbScreen").Text;

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow("7 + 5", "12")]
        [DataRow("5 * 5", "25")]
        [DataRow("10 / 2", "5")]
        [DataRow("8 - 2", "6")]

        [TestMethod]
        public void Test_RealJob(string input, string expected)
        {
            window.Get<TextBox>("tbScreen").Text = input;
            window.Get<Button>("btCount").Click();

            string actual = window.Get<TextBox>("tbScreen").Text;

            Assert.AreEqual(expected, actual);
        }
    }
}
