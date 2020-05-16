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
        /// <summary>
        /// 第一次做的答案
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 第二次做的答案
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static ListNode ReverseKGroupV2(ListNode head, int k)
        {
            if (head == null) return null;
            ListNode fast = head, slow = head, dumHead = new ListNode(0), tail = null;
            while (fast != null)
            {
                int count = 0;
                while (++count < k && fast.next != null) fast = fast.next;
                ListNode tmp = fast.next;
                if (count < k)
                {
                    if (tail == null)
                        dumHead.next = slow;
                    else
                        tail.next = slow;
                }
                else
                {
                    fast.next = null;
                    ListNode pre = null, cur = slow;
                    while (cur != null)
                    {
                        ListNode temp = cur.next;
                        cur.next = pre;
                        pre = cur;
                        cur = temp;
                    }
                    if (dumHead.next == null)
                    {
                        dumHead.next = fast;
                        tail = slow;
                    }
                    else
                    {
                        tail.next = fast;
                        tail = slow;
                    }
                }
                fast = tmp;
                slow = tmp;
            }
            return dumHead.next;
        }
    }
}
