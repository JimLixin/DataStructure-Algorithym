using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 61. 旋转链表
/// https://leetcode-cn.com/problems/rotate-list/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00061_旋转链表
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (k == 0 || head == null) return head;
            int count = 0;
            ListNode dumHead = new ListNode(0), fast = dumHead, slow = dumHead;
            dumHead.next = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                count++;
            }
            count = fast == null ? (count << 1) - 1 : (count << 1);
            k %= count;

            if (k == 0) return head;
            fast = dumHead;
            slow = dumHead;
            while (k-- > 0) fast = fast.next;
            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            ListNode newHead = slow.next;
            slow.next = null;
            fast.next = dumHead.next;
            return newHead;
        }
    }
}
