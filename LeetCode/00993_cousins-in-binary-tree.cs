using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 993. 二叉树的堂兄弟节点
/// https://leetcode-cn.com/problems/cousins-in-binary-tree/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00993_cousins_in_binary_tree
    {
        public bool IsCousins(TreeNode root, int x, int y)
        {
            if (root == null) return false;
            HashSet<int> map = new HashSet<int>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                map.Clear();
                int cnt = q.Count;
                for (int i = 0; i < cnt; i++)
                {
                    TreeNode node = q.Dequeue();
                    if (node.left != null && node.right != null && (node.left.val == x && node.right.val == y || node.left.val == y && node.right.val == x))
                        return false;
                    map.Add(node.val);
                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                }
                if (map.Contains(x) && map.Contains(y))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Need to understanding!!!
        /// </summary>
        /// <param name="root"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool IsCousinsV2(TreeNode root, int x, int y)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            Queue<TreeNode> parentqueue = new Queue<TreeNode>();

            queue.Enqueue(root);
            parentqueue.Enqueue(null);

            while (queue.Count > 0)
            {
                int count = queue.Count;

                TreeNode xparent = null;
                TreeNode yparent = null;

                for (int i = 0; i < count; i++)
                {
                    var n = queue.Dequeue();
                    var p = parentqueue.Dequeue();
                    if (n == null)
                        continue;
                    if (n.val == x)
                        xparent = p;
                    else if (n.val == y)
                        yparent = p;
                    queue.Enqueue(n.left);
                    queue.Enqueue(n.right);
                    parentqueue.Enqueue(n);
                    parentqueue.Enqueue(n);
                }

                if (xparent != null && yparent != null && xparent != yparent)
                    return true;
            }
            return false;
        }
    }
}
