using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题18. 删除链表的节点
    /// https://leetcode-cn.com/problems/shan-chu-lian-biao-de-jie-dian-lcof/
    /// </summary>
    public class shan_chu_lian_biao_de_jie_dian_lcof
    {
        public ListNode DeleteNode(ListNode head, int val)
        {
            ListNode dumHead = new ListNode(0), pre = dumHead, cur = head;
            dumHead.next = head;
            while (cur != null)
            {
                if (cur.val == val)
                    pre.next = cur.next;
                cur = cur.next;
                pre = pre.next;
            }
            return dumHead.next;
        }
    }
}
