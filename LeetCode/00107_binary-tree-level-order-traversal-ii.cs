using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-level-order-traversal-ii/
    /// </summary>
    public class binary_tree_level_order_traversal_ii
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
                return result;

            int level = 0;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                result.Add(new List<int>());
                int qCount = q.Count;
                for (int i = 0; i < qCount; i++)
                {
                    TreeNode node = q.Dequeue();
                    result[level].Add(node.val);
                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                }
                level++;
            }
            return result.Reverse().ToList();
        }
    }
}
