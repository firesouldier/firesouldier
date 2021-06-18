using MergeKSortedLists;
using NUnit.Framework;

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
            ListNode[] lists = new ListNode[]
            {
                GenerateList(1,4,5),
                GenerateList(1,3,4),
                GenerateList(2,6),
            };
            var expected = GenerateList(1,1,2,3,4,4,5,6);

            var result = _solution.MergeKLists(lists);

            AssertThatListNodesMatch(expected, result);
        }


        [Test]
        public void Test2()
        {
            ListNode[] lists = new ListNode[]
            {
                GenerateList(1),
                GenerateList(0)
            };
            var expected = GenerateList(0,1);

            var result = _solution.MergeKLists(lists);

            AssertThatListNodesMatch(expected, result);
        }

        [Test]
        public void Test3()
        {
            ListNode[] lists = new ListNode[]
            {
                null
            };
            ListNode expected = null;

            var result = _solution.MergeKLists(lists);

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