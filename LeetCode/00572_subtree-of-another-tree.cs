using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 572. 另一个树的子树
/// https://leetcode-cn.com/problems/subtree-of-another-tree/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00572_subtree_of_another_tree
    {
        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            if (s == null && t == null) return true;
            if (s == null) return false;
            if (t == null) return false;
            return isSameTree(s, t) || IsSubtree(s.left, t) || IsSubtree(s.right, t);
        }

        public bool isSameTree(TreeNode s, TreeNode t)
        {
            if (t == null) return s == null;
            if (s == null) return t == null;
            return s.val == t.val && isSameTree(s.left, t.left) && isSameTree(s.right, t.right);
        }
    }
}
