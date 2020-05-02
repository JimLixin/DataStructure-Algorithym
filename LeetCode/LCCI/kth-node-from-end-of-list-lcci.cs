using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCCI
{
    /// <summary>
    /// 面试题 02.02. 返回倒数第 k 个节点
    /// https://leetcode-cn.com/problems/kth-node-from-end-of-list-lcci/
    /// </summary>
    public class kth_node_from_end_of_list_lcci
    {
        public int KthToLast(ListNode head, int k)
        {
            if (head == null) return -1;
            ListNode dumHead = new ListNode(0), slow = dumHead, fast = dumHead;
            dumHead.next = head;
            while (k > 0)
            {
                fast = fast.next;
                k--;
            }
            while (fast != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            return slow.val;
        }
    }
}
