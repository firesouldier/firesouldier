using NUnit.Framework;
using ReverseInteger;

namespace Tests
{
    public class Tests
    {
        private Solution _integerReverser;
        [SetUp]
        public void Setup()
        {
            _integerReverser = new Solution();
        }

        [TestCase(321, 123)]
        [TestCase(-123, -321)]
        [TestCase(120, 21)]
        [TestCase(0, 0)]
        [TestCase(1200000000, 21)]
        [TestCase(1534236469, 0)]
        [TestCase(int.MaxValue, 0)]
        [TestCase(int.MinValue, 0)]
        public void Test1(int input, int expected)
        {
            Assert.AreEqual(expected, _integerReverser.Reverse(input));
        }
    }
}