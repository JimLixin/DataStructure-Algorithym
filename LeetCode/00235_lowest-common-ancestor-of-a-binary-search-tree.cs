using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 235. 二叉搜索树的最近公共祖先
/// https://leetcode-cn.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00235_lowest_common_ancestor_of_a_binary_search_tree
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null) return null;
            if (root.val == p.val || root.val == q.val)
                return root;
            if (p.val > root.val && q.val > root.val)
                return LowestCommonAncestor(root.right, p, q);
            if (p.val < root.val && q.val < root.val)
                return LowestCommonAncestor(root.left, p, q);
            return root;
        }
    }
}
