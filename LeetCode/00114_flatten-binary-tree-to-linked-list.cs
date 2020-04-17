using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/flatten-binary-tree-to-linked-list/
    /// </summary>
    public class flatten_binary_tree_to_linked_list
    {
        TreeNode head = new TreeNode(0);
        public void Flatten(TreeNode root)
        {
            if (root == null)
                return;

            head.right = root;
            head.left = null;
            head = head.right;

            TreeNode leftNode = root.left;
            TreeNode rightNode = root.right;
            Flatten(leftNode);
            Flatten(rightNode);
        }
    }
}
