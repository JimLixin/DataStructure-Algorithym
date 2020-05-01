using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题52. 两个链表的第一个公共节点
    /// https://leetcode-cn.com/problems/liang-ge-lian-biao-de-di-yi-ge-gong-gong-jie-dian-lcof/
    /// </summary>
    public class 两个链表的第一个公共节点
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode h1 = headA, h2 = headB;
            while (h1 != h2)
            {
                h1 = h1 == null ? headB : h1.next;
                h2 = h2 == null ? headA : h2.next;
            }
            return h1;
        }
    }
}
