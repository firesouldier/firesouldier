using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeKSortedLists
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            return MergeKListsInternal(GetIterator(lists));
        }

        private ListNode[] GetIterator(ListNode[] lists)
        {
            return lists.Select(l =>
            {
                if (l == null)
                {
                    return null;
                }
                var ret = new ListNode(l.val, l.next);
                return ret;
            }).ToArray();
        }

        private ListNode MergeKListsInternal(ListNode[] lists)
        {
            ListNode sorted = null;
            while (true)
            {
                bool foundAnyElements = false;
                for (int i = 0; i < lists.Length; ++i)
                {
                    var current = lists[i];

                    if(current != null)
                    {
                        foundAnyElements = true;
                        ListNode newNode = new ListNode(current.val);

                        if (sorted == null)
                        {
                            sorted = newNode;
                        }
                        else
                        {
                            if (newNode.val < sorted.val)
                            {
                                newNode.next = sorted;
                                sorted = newNode;
                            }
                            else
                            {
                                ListNode iterator = sorted;
                                while (iterator.next != null && iterator.next.val < newNode.val)
                                {
                                    iterator = iterator.next;
                                }
                                newNode.next = iterator.next;
                                iterator.next = newNode;
                            }
                        }

                        lists[i] = lists[i].next;
                    }
                }

                if (!foundAnyElements)
                {
                    break;
                }
            }
            return sorted;
        }
    }
}
