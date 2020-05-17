using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 515. 在每个树行中找最大值
/// https://leetcode-cn.com/problems/find-largest-value-in-each-tree-row/
/// </summary>
namespace Algorithym.LeetCode
{
    /// <summary>
    /// 深度优先版本
    /// </summary>
    public class _00515_find_largest_value_in_each_tree_row
    {
        IList<int> result;
        public IList<int> LargestValues(TreeNode root)
        {
            result = new List<int>();
            dfs(root, 0);
            return result;
        }

        private void dfs(TreeNode node, int depth)
        {
            if (node == null) return;
            if (depth == result.Count) result.Add(node.val);
            if (result[depth] < node.val) result[depth] = node.val;
            dfs(node.left, depth + 1);
            dfs(node.right, depth + 1);
        }
    }

    /// <summary>
    /// 广度优先版本
    /// </summary>
    public class _00515_find_largest_value_in_each_tree_row2
    {
        public IList<int> LargestValues(TreeNode root)
        {
            IList<int> result = new List<int>();
            if (root == null) return result;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                int cnt = q.Count, max = int.MinValue;
                for (int i = 0; i < cnt; i++)
                {
                    TreeNode node = q.Dequeue();
                    if (max < node.val) max = node.val;
                    if (node.left != null) q.Enqueue(node.left);
                    if (node.right != null) q.Enqueue(node.right);
                }
                result.Add(max);
            }
            return result;
        }
    }
}
