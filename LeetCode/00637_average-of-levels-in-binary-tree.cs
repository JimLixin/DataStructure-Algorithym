using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 637. 二叉树的层平均值
/// https://leetcode-cn.com/problems/average-of-levels-in-binary-tree/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00637_average_of_levels_in_binary_tree
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            IList<double> result = new List<double>();
            if (root == null)
                return result;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                long sum = 0;
                int cnt = q.Count;
                for (int i = 0; i < cnt; i++)
                {
                    TreeNode node = q.Dequeue();
                    sum += node.val;

                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                }
                result.Add((double)sum / cnt);
            }
            return result;
        }
    }
}
