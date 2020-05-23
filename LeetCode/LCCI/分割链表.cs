using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 02.04. 分割链表
/// https://leetcode-cn.com/problems/partition-list-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class 分割链表
    {
        public ListNode Partition(ListNode head, int x)
        {
            ListNode dumHead = new ListNode(0), head2 = new ListNode(0), pre = dumHead, cur = head, tail2 = null;
            dumHead.next = head;
            while (cur != null)
            {
                if (cur.val >= x)
                {
                    ListNode tmp1 = cur.next, tmp2 = cur;
                    pre.next = cur.next;
                    cur.next = null;
                    cur = tmp1;
                    if (head2.next == null)
                    {
                        head2.next = tmp2;
                        tail2 = tmp2;
                    }
                    else
                    {
                        tail2.next = tmp2;
                        tail2 = tail2.next;
                    }
                }
                else
                {
                    cur = cur.next;
                    pre = pre.next;
                }
            }
            pre.next = head2.next;
            return dumHead.next;
        }
    }
}
