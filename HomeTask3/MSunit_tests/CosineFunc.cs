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
    public class CosineFunc
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
        [DataRow(0, 1)]
        public void CosineTest(double x,double e)
        {
            double expected = e;
            double actual = calculatorFunc.Cos(x);
            Assert.AreEqual(actual, expected);
        }

        [DataTestMethod]
        [DataRow("0", "1")]
        public void CosineStringTest(string x, string e)
        {
            double xnew = Convert.ToDouble(x);
            double enew = Convert.ToDouble(e);
            double actual = calculatorFunc.Cos(xnew);
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
