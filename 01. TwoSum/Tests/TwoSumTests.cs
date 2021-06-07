using NUnit.Framework;
using TwoSum;

namespace Tests
{
    public class TwoSumTests
    {
        private TwoSumCalculator _calculator;
        [SetUp]
        public void Setup()
        {
            _calculator = new TwoSumCalculator();
        }

        [Test]
        public void Test1()
        {
            var result = _calculator.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            Verify(result, 0, 1);
        }

        [Test]
        public void Test2()
        {
            var result = _calculator.TwoSum(new int[] { 3, 2, 4, }, 6);
            Verify(result, 1, 2);
        }

        [Test]
        public void Test3()
        {
            var result = _calculator.TwoSum(new int[] { 3, 3, }, 6);
            Verify(result, 0, 1);
        }

        [Test]
        public void Test4()
        {
            var result = _calculator.TwoSum(new int[] { 3, 3, 2, 9, 18}, 27);
            Verify(result, 3, 4);
        }

        [Test]
        public void Test5()
        {
            var result = _calculator.TwoSum(new int[] { 2, 7, 11, 15 }, 18);
            Verify(result, 1, 2);
        }

        [Test]
        public void Test6()
        {
            var result = _calculator.TwoSum(new int[] { 1, 7, 11, 15, 6, 2, 92, 1028 }, 1029);
            Verify(result, 0, 7);
        }

        private void Verify(int[] result, int firstIndex, int secondIndex)
        {
            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(firstIndex, result[0]);
            Assert.AreEqual(secondIndex, result[1]);
        }
    }
}