using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 92. 反转链表 II
/// https://leetcode-cn.com/problems/reverse-linked-list-ii/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00092_reverse_linked_list_ii
    {
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if (head == null)
                return null;
            ListNode pre = null, cur = head, dumHead = new ListNode(0), newHead = dumHead, newTail = null;
            dumHead.next = head;
            int counter = 1;
            while (cur != null && counter <= n)
            {
                if (counter >= m)
                {
                    newTail = counter == m ? cur : newTail;
                    ListNode tmp = cur.next;
                    cur.next = pre;
                    pre = cur;
                    cur = tmp;
                }
                else
                {
                    cur = cur.next;
                    newHead = newHead.next;
                }
                counter++;
            }
            newHead.next = pre;
            newTail.next = cur;
            return dumHead.next;
        }
    }
}
