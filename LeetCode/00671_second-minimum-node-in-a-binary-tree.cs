using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 671. 二叉树中第二小的节点
/// https://leetcode-cn.com/problems/second-minimum-node-in-a-binary-tree/
/// </summary>
namespace Algorithym.LeetCode
{
    /// <summary>
    /// BFS
    /// </summary>
    public class _00671_second_minimum_node_in_a_binary_tree
    {
        public int FindSecondMinimumValue(TreeNode root)
        {
            if (root == null)
                return -1;
            int min = root.val, second = -1;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                int size = q.Count;
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = q.Dequeue();
                    if (node.val != min)
                        second = second < 0 ? node.val : Math.Min(second, node.val);
                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                }
            }
            return second;
        }
    }

    /// <summary>
    /// DFS - TBD
    /// </summary>
    public class _00671_second_minimum_node_in_a_binary_tree_V2
    {

    }
}
