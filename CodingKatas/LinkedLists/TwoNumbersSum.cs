namespace CodingKatas.LinkedLists
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

    public class AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var right = l1.next;
            var left = l2.next;
            var amount = (right.val + left.val) % 10;
            var root = new ListNode(amount);
            var nextNode = root;
            while (right != null && left != null)
            {
                right = right?.next;
                left = left?.next;
                amount = amount >= 10 ? 1 : 0;
                amount += ((right == null ? 0 : right.val) + (left == null ? 0 : left.val));

                nextNode.next = new ListNode(amount % 10);
                nextNode = nextNode.next;
            }

            return root;
        }
    }
}