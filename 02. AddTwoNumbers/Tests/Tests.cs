using AddTwoNumbers;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        private TwoNumberAdder _addTwoNumbers;
        [SetUp]
        public void Setup()
        {
            _addTwoNumbers = new TwoNumberAdder();
        }

        [Test]
        public void Test1()
        {
            ListNode l1 = ListNodeConverter.ToListNode(new int[] { 2, 4, 3 });
            ListNode l2 = ListNodeConverter.ToListNode(new int[] { 5, 6, 4 });
            var result = _addTwoNumbers.Add(l1, l2);

            VerifyResult(new int[] { 7, 0, 8 }, result);
        }

        [Test]
        public void Test2()
        {
            ListNode l1 = ListNodeConverter.ToListNode(new int[] { 0 });
            ListNode l2 = ListNodeConverter.ToListNode(new int[] { 0 });
            var result = _addTwoNumbers.Add(l1, l2);

            VerifyResult(new int[] { 0 }, result);
        }


        [Test]
        public void Test3()
        {
            ListNode l1 = ListNodeConverter.ToListNode(new int[] { 9,9,9,9,9,9,9 });
            ListNode l2 = ListNodeConverter.ToListNode(new int[] { 9,9,9,9 });
            var result = _addTwoNumbers.Add(l1, l2);

            VerifyResult(new int[] { 8,9,9,9,0,0,0,1 }, result);
        }


        [Test]
        public void Test4()
        {
            ListNode l1 = ListNodeConverter.ToListNode(new int[] { 9, 9, 9 });
            ListNode l2 = ListNodeConverter.ToListNode(new int[] { 9, 9, 9 });
            var result = _addTwoNumbers.Add(l1, l2);

            VerifyResult(new int[] { 8, 9, 9, 1 }, result);
        }

        [Test]
        public void Test5()
        {
            ListNode l1 = ListNodeConverter.ToListNode(new int[] { 9, 9, 9, 1, 2 });
            ListNode l2 = ListNodeConverter.ToListNode(new int[] { 9, 9, 9 });
            var result = _addTwoNumbers.Add(l1, l2);

            VerifyResult(new int[] { 8, 9, 9, 2, 2 }, result);
        }

        [Test]
        public void Test6()
        {
            ListNode l1 = ListNodeConverter.ToListNode(new int[] { 5, 5, 5, 5, 5, 1, 2, 3, 4 });
            ListNode l2 = ListNodeConverter.ToListNode(new int[] { 9, 9, 9 });
            var result = _addTwoNumbers.Add(l1, l2);

            VerifyResult(new int[] { 4, 5, 5, 6, 5, 1, 2, 3, 4 }, result);
        }


        private void VerifyResult(int[] expectedResult, ListNode actualResult)
        {
            ListNode expectedListNode = ListNodeConverter.ToListNode(expectedResult);

            Assert.IsNotNull(actualResult);
            Assert.AreEqual(expectedListNode.val, actualResult.val);

            ListNode actualResultEnumerator = actualResult;
            while (expectedListNode != null)
            {
                Assert.AreEqual(expectedListNode.val, actualResultEnumerator.val);
                expectedListNode = expectedListNode.next;
                actualResultEnumerator = actualResultEnumerator.next;
            }
        }
    }
}