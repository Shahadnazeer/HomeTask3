using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace HomeTask3.Assertion
{

    [TestClass]
    public class MSunit
    {
        public TestContext TestContext { get; set; }
        [ClassInitialize]
        public static void ClassInit(TestContext x)
        {
            Console.WriteLine("Preconditions for test class");
        }

        [TestInitialize]
        public void TestInit()
        {
            Console.WriteLine("Preconditions for test");
        }

        [DataTestMethod]
        [DataRow(8, 4, 4)]
        [DataRow(10, 5, 5)]
        [DataRow(10, 10, 0)]
        public void MSunitTest(double x, double y, double e)
        {
            Calculator cal = new Calculator();
            Assert.AreEqual(cal.Sub(x, y), e);
        }

        [DataTestMethod]
        [DataRow("2", "1", "1")]
        public void MSunitTest1(string x, string y, string e)
        {
            double xnew = Convert.ToDouble(x);
            double ynew = Convert.ToDouble(y);
            double enew = Convert.ToDouble(e);
            Calculator cal = new Calculator();
            Assert.AreEqual(cal.Sub(xnew, ynew), enew);
        }

        [TestCleanup]
        public void TestClean()
        {
            Console.WriteLine("Post conditions for test");
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            Console.WriteLine("Post conditions for test class");
        }
    }
}
