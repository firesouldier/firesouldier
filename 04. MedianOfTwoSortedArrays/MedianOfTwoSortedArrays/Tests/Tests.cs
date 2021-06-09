using MedianOfTwoSortedArrays;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        private MedianCalculator _medianCalculator;
        [SetUp]
        public void Setup()
        {
            _medianCalculator = new MedianCalculator();
        }

        [Test]
        public void Test1()
        {
            int[] arr1 = new int[] { 1, 3 };
            int[] arr2 = new int[] { 2 };
            Assert.AreEqual(2, _medianCalculator.FindMedianSortedArrays(arr1, arr2));
        }

        [Test]
        public void Test2()
        {
            int[] arr1 = new int[] { 1, 2 };
            int[] arr2 = new int[] { 3, 4 };
            Assert.AreEqual(2.5, _medianCalculator.FindMedianSortedArrays(arr1, arr2));
        }

        [Test]
        public void Test3()
        {
            int[] arr1 = new int[] { 0, 0 };
            int[] arr2 = new int[] { 0, 0 };
            Assert.AreEqual(0, _medianCalculator.FindMedianSortedArrays(arr1, arr2));
        }

        [Test]
        public void Test4()
        {
            int[] arr1 = new int[] {};
            int[] arr2 = new int[] { 1 };
            Assert.AreEqual(1, _medianCalculator.FindMedianSortedArrays(arr1, arr2));
        }

        [Test]
        public void Test5()
        {
            int[] arr1 = new int[] { 2 };
            int[] arr2 = new int[] {};
            Assert.AreEqual(2, _medianCalculator.FindMedianSortedArrays(arr1, arr2));
        }

        [Test]
        public void Test6()
        {
            int[] arr1 = new int[] { 1,2,3,6,7,8,9 };
            int[] arr2 = new int[] { 4,5 };
            Assert.AreEqual(5, _medianCalculator.FindMedianSortedArrays(arr1, arr2));
        }

        [Test]
        public void Test7()
        {
            int[] arr1 = new int[] { 1, 6, 9, 11 };
            int[] arr2 = new int[] { 2, 5, 8 };
            Assert.AreEqual(6, _medianCalculator.FindMedianSortedArrays(arr1, arr2));
        }

        [Test]
        public void Test8()
        {
            int[] arr1 = new int[] { 1, 1, 2, 2, 2 };
            int[] arr2 = new int[] { 3, 3, 4, 4, 5 };
            Assert.AreEqual(2.5, _medianCalculator.FindMedianSortedArrays(arr1, arr2));
        }

        [Test]
        public void Test9()
        {
            int[] arr1 = new int[] { 1, 2, 4, 6 };
            int[] arr2 = new int[] { 5, 7, 9 };
            Assert.AreEqual(5, _medianCalculator.FindMedianSortedArrays(arr1, arr2));
        }

        [Test]
        public void Test10()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] arr2 = new int[] { 1, 2, 3, 4 };
            Assert.AreEqual(3.5, _medianCalculator.FindMedianSortedArrays(arr1, arr2));
        }

        [Test]
        public void Test11()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            Assert.AreEqual(3, _medianCalculator.FindMedianSortedArrays(arr1, arr2));
        }
    }
}