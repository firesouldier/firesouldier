namespace AddTwoNumbers
{
    public static class ListNodeConverter
    {
        public static ListNode ToListNode(int[] array)
        {
            ListNode previous = null;
            
            for(int i = array.Length-1; i >= 0; --i)
            {
                ListNode current = new ListNode(array[i]);
                if(previous != null)
                {
                    current.next = previous;
                }
                previous = current;
            }
            return previous;
        }
    }
}
