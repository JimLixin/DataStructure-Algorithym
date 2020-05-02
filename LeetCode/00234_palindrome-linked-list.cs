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
    }
}
