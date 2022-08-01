namespace CodingKatas.LinkedLists
{
    public class Palindrome
    {
        private bool palindrome = true;
        public bool IsPalindrome(ListNode head)
        {
            this.NavigateNode(head, head);
            return this.palindrome;
        }
    
        public ListNode NavigateNode(ListNode node, ListNode head){
            var lnode = head;
            if (node.next != null) {
                lnode =NavigateNode(node.next, head);
            }
            this.palindrome = palindrome && lnode != null &&(node.val == lnode.val);
            return lnode.next;
        }
    }
}