using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-nodes-in-k-group/
    /// </summary>
    public static class reverse_nodes_in_k_group
    {
        public static ListNode ReverseKGroup(ListNode head, int k)
        {
            if (k == 1)
                return head;
            int counter = 0;
            ListNode dummyHead = new ListNode(-1), start = dummyHead, current = head, previous = head;
            dummyHead.next = head;

            while (current != null)
            {
                if (previous == current)
                {
                    current = current.next;
                }
                else
                {
                    previous.next = current.next;
                    current.next = start.next;
                    start.next = current;
                    current = previous.next;
                    counter++;
                }
                if (counter == k - 1)
                {
                    start = previous;
                    previous = previous.next;
                    current = (previous != null ? previous.next : null);
                    counter = 0;
                }
            }

            while (counter > 0)
            {
                //Something left there, we need to reverse them back    
                var tmp = previous.next;
                previous.next = start.next;
                start.next = start.next.next;
                previous.next.next = tmp;
                counter--;
            }
            return dummyHead.next;
        }
    }
}
