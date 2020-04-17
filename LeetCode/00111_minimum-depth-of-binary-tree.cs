using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-depth-of-binary-tree/
    /// </summary>
    public class minimum_depth_of_binary_tree
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            if (root.left == null && root.right == null)
                return 1;
            if (root.left == null)
                return 1 + MinDepth(root.right);
            if (root.right == null)
                return 1 + MinDepth(root.left);
            return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
        }
    }
}
