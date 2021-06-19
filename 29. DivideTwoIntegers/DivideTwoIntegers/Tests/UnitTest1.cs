using DivideTwoIntegers;
using NUnit.Framework;
using System.Diagnostics;

namespace Tests
{
    public class Tests
    {
        private Solution _solution;
        [SetUp]
        public void Setup()
        {
            _solution = new Solution();
        }

        [TestCase(10, 3, 3)]
        [TestCase(4, 2, 2)]
        [TestCase(11, 5, 2)]
        [TestCase(7, -3, -2)]
        [TestCase(-7, -3, 2)]
        [TestCase(-7, 3, -2)]
        [TestCase(1, 1, 1)]
        [TestCase(int.MinValue, 1, int.MinValue)]
        [TestCase(int.MinValue, -1, int.MaxValue)]
        [TestCase(-1, -1, 1)]
        [TestCase(10, -1, -10)]
        [TestCase(int.MaxValue, 2, int.MaxValue/2)]
        [TestCase(int.MinValue, 2, int.MinValue/2)]
        [TestCase(int.MinValue, int.MinValue, 1)]
        public void Test1(int dividend, int divisor, int expectedResult)
        {
            var sw = Stopwatch.StartNew();
            Assert.AreEqual(expectedResult, _solution.Divide(dividend, divisor));
            var el = sw.ElapsedMilliseconds;
        }
    }
}