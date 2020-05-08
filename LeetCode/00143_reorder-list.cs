using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 143. 重排链表
/// https://leetcode-cn.com/problems/reorder-list/
/// </summary>
namespace Algorithym.LeetCode
{
    /// <summary>
    /// 第一步，将链表平均分成两半
    /// 第二步，将第二个链表逆序
    /// 第三步，依次连接两个链表
    /// </summary>
    public class _00143_reorder_list
    {
        public void ReorderList(ListNode head)
        {
            ListNode dumHead = new ListNode(0), fast = dumHead, slow = dumHead, head2;
            dumHead.next = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            if (slow.next == null)
                return;
            head2 = slow.next;
            slow.next = null;
            head2 = ReverseList(head2);

            ListNode l1 = head, l2 = head2;
            while (l2 != null)
            {
                ListNode tmp1 = l1.next;
                ListNode tmp2 = l2.next;
                l1.next = l2;
                l2.next = tmp1;
                l1 = tmp1;
                l2 = tmp2;
            }
        }

        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
                return null;
            ListNode pre = null, cur = head;
            while (cur != null)
            {
                ListNode tmp = cur.next;
                cur.next = pre;
                pre = cur;
                cur = tmp;
            }
            return pre;
        }
    }
}
