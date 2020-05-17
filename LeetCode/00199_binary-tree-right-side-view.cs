using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 199. 二叉树的右视图
/// https://leetcode-cn.com/problems/binary-tree-right-side-view/
/// </summary>
namespace Algorithym.LeetCode
{
    /// <summary>
    /// 广度优先版本
    /// </summary>
    public class _00199_binary_tree_right_side_view
    {
        public IList<int> RightSideView(TreeNode root)
        {
            IList<int> result = new List<int>();
            if (root == null) return result;
            int level = 0;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                int cnt = q.Count;
                for (int i = 0; i < cnt; i++)
                {
                    TreeNode node = q.Dequeue();
                    if (i == cnt - 1)
                        result.Add(node.val);
                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                }
            }
            return result;
        }
    }

    /// <summary>
    /// 深度优先版本
    /// </summary>
    public class _00199_binary_tree_right_side_view2
    {
        public IList<int> RightSideView(TreeNode root)
        {
            List<int> result = new List<int>();
            dfs(root, 0, result);
            return result;
        }

        public void dfs(TreeNode t, int depth, List<int> result)
        {
            if (t == null)
                return;
            if (depth == result.Count)
                result.Add(t.val);
            depth++;
            dfs(t.right, depth, result);
            dfs(t.left, depth, result);
        }
    }
}
