using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 02.01. 移除重复节点
/// https://leetcode-cn.com/problems/remove-duplicate-node-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class 移除重复节点
    {
        public ListNode RemoveDuplicateNodes(ListNode head)
        {
            ListNode dumHead = new ListNode(0), cur = head, pre = dumHead;
            dumHead.next = head;
            HashSet<int> dic = new HashSet<int>();
            while (cur != null)
            {
                if (!dic.Contains(cur.val))
                    dic.Add(cur.val);
                cur = cur.next;
            }
            cur = head;
            while (cur != null)
            {
                if (dic.Contains(cur.val))
                {
                    dic.Remove(cur.val);
                    cur = cur.next;
                    pre = pre.next;
                }
                else
                {
                    pre.next = cur.next;
                    cur = cur.next;
                }
            }
            return dumHead.next;
        }
    }
}
