using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 142. 环形链表 II
/// https://leetcode-cn.com/problems/linked-list-cycle-ii/
/// </summary>
namespace Algorithym.LeetCode
{
    /// <summary>
    /// 双指针
    /// fast,slow 第一次相遇之后设置fast为head节点并继续，当第二次相遇时fast(或slow)所在位置即为环形入口节点。 
    /// </summary>
    public class _00142_linked_list_cycle_ii
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null)
                return null;
            ListNode fast = head, slow = head;
            while (true)
            {
                if (fast == null || fast.next == null) return null;
                fast = fast.next.next;
                slow = slow.next;
                if (fast == slow) break;
            }
            fast = head;
            while (fast != slow)
            {
                fast = fast.next;
                slow = slow.next;
            }
            return slow;
        }
    }
}
