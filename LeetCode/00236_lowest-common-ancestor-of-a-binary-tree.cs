using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 236. 二叉树的最近公共祖先
/// https://leetcode-cn.com/problems/lowest-common-ancestor-of-a-binary-tree/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00236_lowest_common_ancestor_of_a_binary_tree
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null) return null;
            if (root == q || root == p) return root;
            TreeNode left = LowestCommonAncestor(root.left, p, q);
            TreeNode right = LowestCommonAncestor(root.right, p, q);
            if (left != null && right != null)
                return root;
            return left != null ? left : right;
        }

    }
}
