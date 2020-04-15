using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/symmetric-tree/
    /// </summary>
    public class symmetric_tree
    {
        /// <summary>
        /// Need to improve!!!
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;
            return check(root.left, root.right);
        }

        public bool check(TreeNode p, TreeNode q)
        {
            if (q == null && p == null)
                return true;
            if (q == null && p != null || q != null && p == null || q.left == null && p.right != null || q.right == null && p.left != null || q.left != null && p.right == null || q.right != null && p.left == null)
                return false;
            return p.val == q.val && (q.left == null && p.right == null || q.left.val == p.right.val && check(q.left, p.right)) && (q.right == null && p.left == null || q.right.val == p.left.val && check(p.left, q.right));
        }
    }
}
