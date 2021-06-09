using NUnit.Framework;
using ZigZagConversion;

namespace Tests
{
    public class Tests
    {
        private ZigZagConverter _zigZagConverter;
        [SetUp]
        public void Setup()
        {
            _zigZagConverter = new ZigZagConverter();
        }

        [TestCase("PAYPALISHIRING", "PAHNAPLSIIGYIR", 3)]
        [TestCase("PAYPALISHIRING", "PINALSIGYAHRPI", 4)]
        [TestCase("A", "A", 1)]
        public void Test1(string input, string expected, int numRows)
        {
            Assert.AreEqual(expected, _zigZagConverter.Convert(input, numRows));
        }
    }
}