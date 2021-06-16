using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveNthNodeFromLinkedList
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
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int numElementsInList = 0;

            ListNode iterator = head;
            while(iterator != null)
            {
                iterator = iterator.next;
                ++numElementsInList;
            }

            int indexOfElementToRemove = numElementsInList - n;
            if (indexOfElementToRemove <= 0)
            {
                head = head.next;
            }
            else
            {
                iterator = head;
                int iteratorIndex = 0;
                while (iteratorIndex < indexOfElementToRemove - 1)
                {
                    iterator = iterator.next;
                    ++iteratorIndex;
                }


                if (iterator.next != null)
                {
                    iterator.next = iterator.next.next;
                }
            }

            return head;
        }
    }
}
