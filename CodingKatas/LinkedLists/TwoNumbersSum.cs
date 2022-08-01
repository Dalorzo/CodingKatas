namespace CodingKatas.LinkedLists
{
    
    public class TwoNumbersSum
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var amount = (l1.val + l2.val);
            var root = new ListNode(amount % 10);
            l1 = l1?.next;
            l2 = l2?.next;
            var nextNode = root;
            while (l1 != null || l2 != null)
            {
                amount = amount >= 10 ? 1 : 0;
                amount += ((l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val));

                nextNode.next = new ListNode(amount % 10);
                nextNode = nextNode.next;
                l1 = l1?.next;
                l2 = l2?.next;
            }
            if (l1 == null && l2 == null && amount >= 10)
            {
                nextNode.next = new ListNode(1);
            }
            return root;
        }
    }
}