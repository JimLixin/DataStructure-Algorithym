using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题06. 从尾到头打印链表
    /// https://leetcode-cn.com/submissions/detail/65163867/
    /// </summary>
    public class cong_wei_dao_tou_da_yin_lian_biao_lcof
    {
        public int[] ReversePrint(ListNode head)
        {
            Stack<int> s = new Stack<int>();
            int size = 0;
            while (head != null)
            {
                s.Push(head.val);
                head = head.next;
                size++;
            }
            int[] data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = s.Pop();
            }
            return data;
        }
    }

    /// <summary>
    /// A better solution!!!
    /// </summary>
    public class Solution
    {
        public ListNode Reverse(ListNode node)
        {
            if (node.next == null)
                return node;
            ListNode head = Reverse(node.next);
            node.next.next = node;
            node.next = null;
            return head;
        }

        public int[] ReversePrint(ListNode head)
        {
            if (head == null)
                return new int[0];

            head = Reverse(head);
            List<int> list = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }
            return list.ToArray();
        }
    }
}
