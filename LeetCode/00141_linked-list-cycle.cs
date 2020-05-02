using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// 141. 环形链表
    /// https://leetcode-cn.com/problems/linked-list-cycle/
    /// </summary>
    public class linked_list_cycle
    {
        public bool HasCycle(ListNode head)
        {
            ListNode dumHead1 = new ListNode(0), dumHead2 = new ListNode(0), slow = dumHead1, fast = head;
            dumHead1.next = dumHead2;
            dumHead2.next = head;
            while (fast != null && fast.next != null)
            {
                if (fast == slow) return true;
                slow = slow.next;
                fast = fast.next.next;
            }
            return false;
        }
    }
}
