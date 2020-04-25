using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题28. 对称的二叉树
    /// https://leetcode-cn.com/problems/dui-cheng-de-er-cha-shu-lcof/
    /// </summary>
    public class dui_cheng_de_er_cha_shu_lcof
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;
            return isSymmetric(root.left, root.right);
        }

        public bool isSymmetric(TreeNode left, TreeNode right)
        {
            ///Another better way to check if both are null or not
            ///if (left == null) return right == null;
            ///if (right == null) return left == null;
            if (left == null && right == null)
                return true;
            if (left == null || right == null)
                return false;
            return (left.val == right.val) && isSymmetric(left.right, right.left) && isSymmetric(left.left, right.right);
        }
    }
}
