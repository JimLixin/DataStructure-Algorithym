using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题24. 反转链表
    /// https://leetcode-cn.com/problems/fan-zhuan-lian-biao-lcof/
    /// </summary>
    public class fan_zhuan_lian_biao_lcof
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
                return null;
            ListNode p1 = null, p2 = head, tmp;
            while (p2 != null)
            {
                tmp = p2.next;
                p2.next = p1;
                p1 = p2;
                p2 = tmp;
            }
            return p1;
        }
    }
}
