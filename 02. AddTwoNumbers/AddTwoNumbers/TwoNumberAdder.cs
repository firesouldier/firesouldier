using System;
using System.Collections.Generic;

namespace AddTwoNumbers
{
    public class TwoNumberAdder
    {
        public ListNode Add(ListNode l1, ListNode l2)
        {
            List<int> result = new List<int>();

            int carryValue = 0;
            while (l1 != null || l2 != null)
            {
                int delta = GetSumOfNodeValues(l1, l2) + (carryValue > 0 ? 1 : 0);
                carryValue = CalculateCarryValue(delta);
                result.Add(carryValue > 0 ? carryValue - 1 : delta);
                l1 = l1?.next;
                l2 = l2?.next;
            }
            if(carryValue > 0)
            {
                result.Add(1);
            }

            return ListNodeConverter.ToListNode(result.ToArray());
        }


        private int CalculateCarryValue(int delta)
        {
            return Math.Max(delta - 9, 0);
        }

        private int GetSumOfNodeValues(ListNode n1, ListNode n2)
        {
            int sum = 0;
            if(n1 != null)
            {
                sum += n1.val;
            }

            if(n2 != null)
            {
                sum += n2.val;
            }
            return sum;
        }
    }
}
