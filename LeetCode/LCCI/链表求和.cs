using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 02.05. 链表求和
/// https://leetcode-cn.com/problems/sum-lists-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class 链表求和
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(0), tail = null;
            int carry = 0, tmp = 0, cnt1 = 0, cnt2 = 0;
            while (l1 != null && l2 != null)
            {
                tmp = l1.val + l2.val + carry;
                carry = tmp / 10;
                if (head.next == null)
                {
                    head.next = new ListNode(tmp % 10);
                    tail = head.next;
                }
                else
                {
                    tail.next = new ListNode(tmp % 10);
                    tail = tail.next;
                }
                l1 = l1.next;
                l2 = l2.next;
            }
            while (l1 != null)
            {
                tmp = l1.val + carry;
                carry = tmp / 10;
                tail.next = new ListNode(tmp % 10);
                tail = tail.next;
                l1 = l1.next;
            }
            while (l2 != null)
            {
                tmp = l2.val + carry;
                carry = tmp / 10;
                tail.next = new ListNode(tmp % 10);
                tail = tail.next;
                l2 = l2.next;
            }
            if (carry > 0)
                tail.next = new ListNode(1);
            return head.next;
        }
    }
}
