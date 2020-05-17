using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 513. 找树左下角的值
/// https://leetcode-cn.com/problems/find-bottom-left-tree-value/
/// </summary>
namespace Algorithym.LeetCode
{
    /// <summary>
    /// 深度优先版本
    /// </summary>
    public class _00513_find_bottom_left_tree_value
    {
        int result;
        int level;
        public int FindBottomLeftValue(TreeNode root)
        {
            if (root == null) return -1;
            dfs(root, 0);
            return result;
        }

        private void dfs(TreeNode node, int depth)
        {
            if (node == null) return;
            if (depth == level)
            {
                result = node.val;
                level++;
            }
            dfs(node.left, depth + 1);
            dfs(node.right, depth + 1);
        }
    }

    /// <summary>
    /// 广度优先版本
    /// </summary>
    public class _00513_find_bottom_left_tree_value2
    {
        public int FindBottomLeftValue(TreeNode root)
        {
            if (root == null) return -1;
            int level = 0, result = -1;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                int cnt = q.Count;
                for (int i = 0; i < cnt; i++)
                {
                    TreeNode node = q.Dequeue();
                    if (i == 0) result = node.val;
                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                }
            }
            return result;
        }
    }
}
