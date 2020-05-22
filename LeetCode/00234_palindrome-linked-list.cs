using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// 234. 回文链表
    /// https://leetcode-cn.com/problems/palindrome-linked-list/
    /// </summary>
    public class palindrome_linked_list
    {
        /// <summary>
        /// 时间复杂度: O(N)
        /// 空间复杂度: O(N)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool IsPalindrome(ListNode head)
        {
            if (head == null) return true;
            ListNode slow = head, fast = head;
            Stack<int> s = new Stack<int>();
            while (true)
            {
                if (fast == null) break;
                if (fast.next == null)
                {
                    slow = slow.next;
                    break;
                }
                s.Push(slow.val);
                slow = slow.next;
                fast = fast.next.next;
            }
            while (s.Count > 0)
            {
                if (s.Pop() != slow.val)
                    return false;
                slow = slow.next;
            }
            return true;
        }

        /// <summary>
        /// 时间复杂度: O(N)
        /// 空间复杂度: O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool IsPalindromeV2(ListNode head)
        {
            ListNode dumHead1 = new ListNode(0), fast = dumHead1, slow = dumHead1, dumHead2 = new ListNode(0), pre = null, cur = null;
            dumHead1.next = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            dumHead2.next = slow.next;
            cur = dumHead2.next;
            slow.next = null;
            while (cur != null)
            {
                ListNode temp = cur.next;
                cur.next = pre;
                pre = cur;
                cur = temp;
            }
            dumHead1 = dumHead1.next;
            while (dumHead1 != null && pre != null)
            {
                if (dumHead1.val != pre.val)
                    return false;
                dumHead1 = dumHead1.next;
                pre = pre.next;
            }
            return true;
        }
    }
}
