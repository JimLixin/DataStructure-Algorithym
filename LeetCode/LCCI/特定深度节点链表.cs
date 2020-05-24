using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 04.03. 特定深度节点链表
/// https://leetcode-cn.com/problems/list-of-depth-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class 特定深度节点链表
    {
        public ListNode[] ListOfDepth(TreeNode tree)
        {
            IList<ListNode> result = new List<ListNode>();
            if (tree == null) return result.ToArray();
            int level = 0;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(tree);
            while (q.Count > 0)
            {
                int cnt = q.Count;
                ListNode head = new ListNode(0), tail = null;
                for (int i = 0; i < cnt; i++)
                {
                    TreeNode node = q.Dequeue();
                    if (head.next == null)
                    {
                        head.next = new ListNode(node.val);
                        tail = head.next;
                    }
                    else
                    {
                        tail.next = new ListNode(node.val);
                        tail = tail.next;
                    }
                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                }
                result.Add(head.next);
            }
            return result.ToArray();
        }
    }
}
