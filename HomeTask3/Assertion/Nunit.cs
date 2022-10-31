using System;
using NUnit.Framework;
using CSharpCalculator;

[assembly: LevelOfParallelism(2)]
namespace HomeTask3.Assertion
{
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class NUnit
    {
        [OneTimeSetUp]
        public static void ClassInit()
        {
            Console.WriteLine("Preconditions for test class");
        }

        [SetUp]
        public static void TestInit()
        {
            Console.WriteLine("Preconditions for test");
        }

        [TestCase(4,8,12)]
        [TestCase(5,10,15)]
        [TestCase(10, 10, 20)]
        public void NunitTest(double x, double y, double e)
        { 
             Calculator cal= new Calculator();
             Assert.AreEqual(cal.Add(x, y), e);
        }

        [TestCase("1", "1", "2")]
        public void NunitTest1(string x, string y, string e)
        {
            double xnew = Convert.ToDouble(x);
            double ynew = Convert.ToDouble(y);
            double enew = Convert.ToDouble(e);
            Calculator cal = new Calculator();
            Assert.AreEqual(cal.Add(xnew, ynew), enew);
        }

        [TearDown]
        public static void TestClean()
        {
            Console.WriteLine("Post conditions for test");
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Console.WriteLine("Post conditions for test class");
        }
    }
}