using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 226. 翻转二叉树
/// https://leetcode-cn.com/problems/invert-binary-tree/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00226_invert_binary_tree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;
            TreeNode tmp = root.left;
            root.left = root.right;
            root.right = tmp;
            InvertTree(root.left);
            InvertTree(root.right);
            return root;
        }
    }
}
