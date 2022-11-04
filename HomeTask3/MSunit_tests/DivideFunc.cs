using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace HomeTask3.MSunit_tests
{

    [TestClass]
    public class DivideFunc
    {
        public Calculator calculatorFunc;
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
            calculatorFunc = new Calculator();
        }

        [DataTestMethod]
        [DataRow(8, 4, 2)]
        [DataRow(10, 5, 2)]
        [DataRow(10, 10, 1)]
        public void DivideTest(double x, double y, double e)
        {
            double expected = e;
            double actual = calculatorFunc.Divide(x, y);
            Assert.AreEqual(actual, expected);
        }

        [DataTestMethod]
        [DataRow("2", "1", "2")]
        public void DivideStringTest(string x, string y, string e)
        {
            double xnew = Convert.ToDouble(x);
            double ynew = Convert.ToDouble(y);
            double enew = Convert.ToDouble(e);
            double actual = calculatorFunc.Divide(xnew, ynew);
            double expected = enew;
            Assert.AreEqual(actual, expected);
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
