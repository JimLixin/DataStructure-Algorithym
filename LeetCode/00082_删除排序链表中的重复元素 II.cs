using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 82. 删除排序链表中的重复元素 II
/// https://leetcode-cn.com/problems/remove-duplicates-from-sorted-list-ii/
/// </summary>
/// 
namespace Algorithym.LeetCode
{

    public class remove_duplicates_from_sorted_list_ii
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode dumHead = new ListNode(0), slow, fast;
            dumHead.next = head;
            slow = dumHead;
            fast = head;
            int fastStep = 0;

            while (fast != null && fast.next != null)
            {
                if (fast.next.val != fast.val)
                {
                    if (fastStep > 0)
                    {
                        slow.next = fast.next;
                        fast = fast.next;
                        fastStep = 0;
                    }
                    else
                    {
                        fast = fast.next;
                        slow = slow.next;
                    }
                }
                else
                {
                    fast = fast.next;
                    fastStep++;
                }
            }
            if (slow.next != fast)
                slow.next = null;

            return dumHead.next;
        }

        /// <summary>
        /// Best solution in submissions!!!
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode DeleteDuplicatesV2(ListNode head)
        {
            if (head == null) return head;

            var tempHead = new ListNode(0);
            var t = tempHead;
            while (head != null)
            {
                if (head?.next != null && head.val == head.next.val)
                {
                    while (head?.next != null && head.val == head.next.val)
                    {
                        head = head.next;
                    }
                    head = head.next;
                }
                else
                {
                    t.next = head;
                    t = t.next;
                    head = head.next;
                }

            }
            t.next = null;
            return tempHead.next;
        }
    }
}
