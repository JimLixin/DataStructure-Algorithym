using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 222. 完全二叉树的节点个数
/// https://leetcode-cn.com/problems/count-complete-tree-nodes/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00222_count_complete_tree_nodes
    {
        public int CountNodes(TreeNode root)
        {
            int result = 0;
            if (root == null) return result;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                int cnt = q.Count;
                result += cnt;
                for (int i = 0; i < cnt; i++)
                {
                    TreeNode node = q.Dequeue();
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
