using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题22. 链表中倒数第k个节点
    /// https://leetcode-cn.com/problems/lian-biao-zhong-dao-shu-di-kge-jie-dian-lcof/
    /// </summary>
    public class lian_biao_zhong_dao_shu_di_kge_jie_dian_lcof
    {
        public ListNode GetKthFromEnd(ListNode head, int k)
        {
            ListNode fast = head, slow = head;
            while (k-- > 0)
            {
                fast = fast.next;
            }
            while (fast != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            return slow;
        }

        /// <summary>
        /// A better solution need to understand!!!
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public ListNode GetKthFromEndV2(ListNode head, int k)
        {
            ListNode fast = head;
            while (fast != null)
            {
                fast = fast.next;
                if (k == 0)
                    head = head.next;
                else
                    k--;
            }
            return head;
        }
    }
}
