using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 04.08. 首个共同祖先
/// https://leetcode-cn.com/problems/first-common-ancestor-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class 首个共同祖先
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null) return null;
            if (root.val == p.val || root.val == q.val) return root;
            TreeNode left = LowestCommonAncestor(root.left, p, q);
            TreeNode right = LowestCommonAncestor(root.right, p, q);
            if (left != null && right != null)
                return root;
            else if (left == null)
                return right;
            else
                return left;
        }
    }
}
