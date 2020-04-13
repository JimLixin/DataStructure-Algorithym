using Algorithym.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    public class path_sum
    {
        private int tmp = 0;
        private bool result;
        public bool HasPathSum(TreeNode root, int sum)
        {
            dfs(root, sum);
            return result;
        }

        public void dfs(TreeNode node, int sum)
        {
            if (result == true || node == null)
                return;
            tmp += node.val;
            //Console.WriteLine($"Current node is {node.Value}.tmp is {tmp}");
            if (node.left == null && node.right == null)
            {
                if (tmp == sum)
                    result = true;

                tmp -= node.val;
                return;
            }
            dfs(node.left, sum);
            dfs(node.right, sum);
            tmp -= node.val;
        }
    }
}
