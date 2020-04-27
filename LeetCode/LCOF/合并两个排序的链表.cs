using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题25. 合并两个排序的链表
    /// https://leetcode-cn.com/problems/he-bing-liang-ge-pai-xu-de-lian-biao-lcof/
    /// </summary>
    public class 合并两个排序的链表
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            ListNode head = new ListNode(0);
            head.next = l1;
            ListNode p1 = l1, p2 = l2, tmp, pre1 = head;
            while (p1 != null && p2 != null)
            {
                if (p2.val <= p1.val)
                {
                    tmp = p2.next;
                    pre1.next = p2;
                    p2.next = p1;
                    p2 = tmp;
                    pre1 = pre1.next;
                }
                else
                    while (p1 != null && p1.val < p2.val)
                    {
                        p1 = p1.next;
                        pre1 = pre1.next;
                    }
            }
            if (p2 != null) pre1.next = p2;
            return head.next;
        }
    }
}
