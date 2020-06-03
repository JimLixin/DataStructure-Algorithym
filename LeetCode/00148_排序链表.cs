using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 148. 排序链表
/// https://leetcode-cn.com/problems/sort-list/
/// </summary>
namespace Algorithym.LeetCode
{
    /// <summary>
    /// 归并排序
    /// 时间:O(NLogN)
    /// 空间:O(N) --> 题目要求是O(1)，所以不能用递归
    /// </summary>
    public class _00148_排序链表
    {
        public ListNode SortList(ListNode head)
        {
            if (head == null) return null;
            if (head.next == null) return head;
            ListNode dumHead = new ListNode(0), fast = dumHead, slow = dumHead;
            dumHead.next = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            ListNode head2 = slow.next;
            slow.next = null;
            return MergeSorted(SortList(dumHead.next), SortList(head2));
        }

        public ListNode MergeSorted(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            ListNode head = new ListNode(0), cur = head;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    cur.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    cur.next = l2;
                    l2 = l2.next;
                }
                cur = cur.next;
            }
            cur.next = l1 == null ? l2 : l1;
            return head.next;
        }
    }
}
