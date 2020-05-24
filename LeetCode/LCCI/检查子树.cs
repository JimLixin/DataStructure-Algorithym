using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 04.10. 检查子树
/// https://leetcode-cn.com/problems/check-subtree-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class 检查子树
    {
        public bool CheckSubTree(TreeNode t1, TreeNode t2)
        {
            if (t1 == null) return false;
            if (t1.val == t2.val)
                return isSameTree(t1.left, t2.left) && isSameTree(t1.right, t2.right);
            else
                return CheckSubTree(t1.left, t2) || CheckSubTree(t1.right, t2);
        }

        public bool isSameTree(TreeNode t1, TreeNode t2)
        {
            if (t1 == null) return t2 == null;
            if (t2 == null) return t2 == null;
            return t1.val == t2.val && isSameTree(t1.left, t2.left) && isSameTree(t1.right, t2.right);
        }
    }
}
