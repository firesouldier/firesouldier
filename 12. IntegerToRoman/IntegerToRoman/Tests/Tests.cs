using NUnit.Framework;

namespace IntegerToRoman
{
    public class Tests
    {
        private Solution _solution;
        [SetUp]
        public void Setup()
        {
            _solution = new Solution();
        }

        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("IX", 9)]
        [TestCase("LVIII", 58)]
        [TestCase("LXXXIII", 83)]
        [TestCase("MCMXCIV", 1994)]
        [TestCase("MCM", 1900)]
        [TestCase("CD", 400)]
        [TestCase("CM", 900)]
        public void Test1(string expected, int integer)
        {
            Assert.AreEqual(expected, _solution.IntToRoman(integer));
        }
    }
}