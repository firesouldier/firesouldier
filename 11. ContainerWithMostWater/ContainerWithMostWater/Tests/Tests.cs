using NUnit.Framework;

namespace ContainerWithMostWater
{
    public class Tests
    {
        private Solution _solution;
        [SetUp]
        public void Setup()
        {
            _solution = new Solution();
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(49, _solution.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, _solution.MaxArea(new int[] { 1, 1 }));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(16, _solution.MaxArea(new int[] { 4, 3, 2, 1, 4 }));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(2, _solution.MaxArea(new int[] { 1, 2, 1 }));
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(200, _solution.MaxArea(new int[] { 1, 8, 100, 2, 100, 4, 8, 3, 7 }));
        }


        [Test]
        public void Test6()
        {
            Assert.AreEqual(60, _solution.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7, 1, 1, 6, 2, 4 }));
        }

        
    }
}