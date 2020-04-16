using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/balanced-binary-tree/
    /// </summary>
    public class balanced_binary_tree
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;
            return (Math.Abs(getHeight(root.left) - getHeight(root.right)) <= 1) && IsBalanced(root.left) && IsBalanced(root.right);
        }

        public int getHeight(TreeNode node)
        {
            if (node == null)
                return 0;
            return 1 + Math.Max(getHeight(node.left), getHeight(node.right));
        }
    }
}
