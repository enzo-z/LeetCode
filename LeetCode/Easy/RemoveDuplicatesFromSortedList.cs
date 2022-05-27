using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val, ListNode? next)
        {
            this.val = val;
            this.next = next;
        }
    }

    internal class RemoveDuplicatesFromSortedList
    {
        public static ListNode mySolution(ListNode head)
        {
            var firstNode = head;
            while(head is not null && head.next is not null)
            {
                if(head.val == head.next.val)
                    head.next = head.next.next;
                
                else
                    head = head.next;
            }
            
            return firstNode;
        }
    }
}
