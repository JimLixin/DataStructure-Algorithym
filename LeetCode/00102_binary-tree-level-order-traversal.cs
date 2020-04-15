using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-level-order-traversal/
    /// </summary>
    public class binary_tree_level_order_traversal
    {
        private Dictionary<int, IList<int>> result;

        /// <summary>
        /// Original answer by using recursive
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            result = new Dictionary<int, IList<int>>();
            travel(root, 0);
            return result.Values.ToList();
        }

        /// <summary>
        /// Imrpoved answer by using Queue and iterative
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> LevelOrderV2(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
                return result;
            Queue<TreeNode> queue = new Queue<TreeNode>();

            int level = 0;
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                result.Add(new List<int>() { });
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    TreeNode node = queue.Dequeue();
                    result[level].Add(node.val);

                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
                level++;
            }
            return result;
        }

        public void travel(TreeNode node, int level)
        {
            if (node == null)
                return;
            if (!result.ContainsKey(level))
                result.Add(level, new List<int>(new int[] { node.val }));
            else
                result[level].Add(node.val);

            travel(node.left, level + 1);
            travel(node.right, level + 1);
        }
    }
}
