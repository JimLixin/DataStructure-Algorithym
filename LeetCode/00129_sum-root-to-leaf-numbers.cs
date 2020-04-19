using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/sum-root-to-leaf-numbers/
    /// </summary>
    public class sum_root_to_leaf_numbers
    {
        int sum, data;
        public int SumNumbers(TreeNode root)
        {
            sum = 0;
            data = 0;
            dfs(root);
            return sum;
        }

        public void dfs(TreeNode node)
        {
            if (node == null)
                return;
            data = data * 10 + node.val;

            if (node.left == null && node.right == null)
            {
                sum += data;
                data = (data - node.val) / 10;
                return;
            }

            if (node.left != null)
                dfs(node.left);
            if (node.right != null)
                dfs(node.right);
            data = (data - node.val) / 10;
        }
    }
}
