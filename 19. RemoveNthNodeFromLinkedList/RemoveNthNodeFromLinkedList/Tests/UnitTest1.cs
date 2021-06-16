using NUnit.Framework;
using RemoveNthNodeFromLinkedList;
using System.Linq;

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

        [Test]
        public void Test1()
        {
            var list = GenerateList(1, 2, 3, 4, 5);
            var expected = GenerateList(1, 2, 3, 5);

            var result = _solution.RemoveNthFromEnd(list, 2);

            AssertThatListNodesMatch(expected, result);
        }

        [Test]
        public void Test2()
        {
            var list = GenerateList(1);
            var expected = GenerateList();

            var result = _solution.RemoveNthFromEnd(list, 1);

            AssertThatListNodesMatch(expected, result);
        }

        [Test]
        public void Test3()
        {
            var list = GenerateList(1,2);
            var expected = GenerateList(1);

            var result = _solution.RemoveNthFromEnd(list, 1);

            AssertThatListNodesMatch(expected, result);
        }

        [Test]
        public void Test4()
        {
            var list = GenerateList(1, 2, 3, 4, 5);
            var expected = GenerateList(1, 2, 4, 5);

            var result = _solution.RemoveNthFromEnd(list, 3);

            AssertThatListNodesMatch(expected, result);
        }

        [Test]
        public void Test5()
        {
            var list = GenerateList(1, 2);
            var expected = GenerateList(2);

            var result = _solution.RemoveNthFromEnd(list, 2);

            AssertThatListNodesMatch(expected, result);
        }



        private void AssertThatListNodesMatch(ListNode expected, ListNode result)
        {
            if(expected == null)
            {
                Assert.IsNull(result);
            }

            while (expected != null)
            {
                Assert.IsNotNull(result);
                Assert.AreEqual(expected.val, result.val);
                result = result.next;
                expected = expected.next;
            }
        }


        private ListNode GenerateList(params int[] listValues)
        {
            ListNode first = null;
            ListNode previous = null;
            for(int i = 0; i < listValues.Length; ++i)
            {
                ListNode n = new ListNode(listValues[i]);
                if(previous != null)
                {
                    previous.next = n;
                }

                if(first == null)
                {
                    first = n;
                }
                previous = n;
            }
            return first;
        }
    }
}