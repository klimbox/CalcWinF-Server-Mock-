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
    public class CalcTBTests
    {
        public TestContext TestContext { get; set; }
        static Application application;
        static Window window;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            //var applicationPath = Path.Combine("D:/ORT Course/Calc/WinF+WPF/WinF+WPF/CalcTb/bin/Debug", "CalcTb.exe");
            application = Application.Launch(new ProcessStartInfo(@"CalcTb.exe")
            {
                WorkingDirectory = @"..\..\..\CalcTb\bin\Debug",
            });
            window = application.GetWindow("Calc", InitializeOption.NoCache);
        }

        [DataTestMethod]
        [DataRow("tbA", "123")]
        [DataRow("tbB", "321")]
        [DataRow("tbO", "awsd")]


        [TestMethod]
        public void TestButtons(string tb, string expected)
        {

            window.Get<TextBox>(tb).Text = expected;
            string actual = window.Get<TextBox>(tb).Text;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_5p5_10()
        {
            string expected = "10";

            window.Get<TextBox>("tbA").Text = "5";
            window.Get<TextBox>("tbB").Text = "5";
            window.Get<TextBox>("tbO").Text = "+";
            window.Get<Button>("btCount").Click();

            string actual = window.Get<TextBox>("tbA").Text;

            Assert.AreEqual(expected, actual);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            window.Get<TextBox>("tbA").Text = "";
            window.Get<TextBox>("tbB").Text = "";
            window.Get<TextBox>("tbO").Text = "";
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            window.Close();
            application.Close();
        }
    }
}
