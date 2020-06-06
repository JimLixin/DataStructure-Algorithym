using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 147. 对链表进行插入排序
/// https://leetcode-cn.com/problems/insertion-sort-list/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00147_对链表进行插入排序
    {
        public ListNode InsertionSortList(ListNode head)
        {
            ListNode dumHead = new ListNode(0), cur = head, pre = dumHead;
            dumHead.next = head;
            while (cur != null)
            {
                ListNode next = cur.next;
                ListNode p1 = dumHead, p2 = dumHead.next;
                while (p2 != cur && p2.val <= cur.val)
                {
                    p1 = p1.next;
                    p2 = p2.next;
                }
                p1.next = cur;
                if (p2 == cur)
                    pre = pre.next;
                else
                {
                    pre.next = null;
                    cur.next = p2;
                    pre.next = next;
                }
                cur = next;
            }
            return dumHead.next;
        }
    }
}
