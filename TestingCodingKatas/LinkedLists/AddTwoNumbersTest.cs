using CodingKatas.LinkedLists;
using NUnit.Framework;

namespace TestingCodingKatas.LinkedLists
{
    public class AddTwoNumbersTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestingAddingNumbers01()
        {
            /*
            Input: l1 = [2,4,3], l2 = [5,6,4]
            Output: [7,0,8]
            */
            var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            var output = new ListNode(7, new ListNode(0, new ListNode(8)));
            var sum = new TwoNumbersSum();
            var result = sum.AddTwoNumbers(l1, l2);
            Assert.AreEqual(true,ExtendingAssert.AreEqualList(output , result), "Testing simple");
        }
        
        [Test]
        public void TestingAddingNumbers02()
        {
            /*
                Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
                Output: [8,9,9,9,0,0,0,1]
            */
            var l1 = new ListNode(9, new ListNode(9, new ListNode(9,new ListNode(9,new ListNode(9,new ListNode(9,new ListNode(9)))))));
            var l2 = new ListNode(9, new ListNode(9, new ListNode(9,new ListNode(9))));
            var output = new ListNode(8, new ListNode(9, new ListNode(9,new ListNode(9,new ListNode(0,new ListNode(0,new ListNode(0,new ListNode(1))))))));
            var sum = new TwoNumbersSum();
            var result = sum.AddTwoNumbers(l1, l2);
            Assert.AreEqual(true,ExtendingAssert.AreEqualList(output , result), "Testing simple");
        }
        
        [Test]
        public void TestingAddingNumbers03()
        {
            /*
            Input: l1 = [2,4,3], l2 = [5,6,4]
            Output: [7,0,8]
            */
            var l1 = new ListNode(5);
            var l2 = new ListNode(5);
            var output = new ListNode(0, new ListNode(1));
            var sum = new TwoNumbersSum();
            var result = sum.AddTwoNumbers(l1, l2);
            Assert.AreEqual(true,ExtendingAssert.AreEqualList(output , result), "Testing simple");
        }
    }

    public static class ExtendingAssert {
        public static bool AreEqualList(ListNode l1, ListNode l2)
        {

            while (l1 != null && l2 != null)
            {
                if (l1.val != l2.val)
                {
                    return false;
                }

                l1 = l1.next;
                l2 = l2.next;
            }
            
            return l1 == l2;
        }
    }
}