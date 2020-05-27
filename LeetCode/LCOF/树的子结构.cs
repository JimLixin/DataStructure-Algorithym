using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 面试题26. 树的子结构
/// https://leetcode-cn.com/problems/shu-de-zi-jie-gou-lcof/
/// </summary>
namespace Algorithym.LeetCode.LCOF
{
    public class 树的子结构
    {
        public bool IsSubStructure(TreeNode A, TreeNode B)
        {
            if (B == null) return false;
            if (A == null) return B == null;
            return A.val == B.val && helper(A, B) || IsSubStructure(A.left, B) || IsSubStructure(A.right, B);
        }

        public bool helper(TreeNode A, TreeNode B)
        {
            if (A == null) return B == null;
            if (B == null) return true;
            return A.val == B.val ? helper(A.left, B.left) && helper(A.right, B.right) : false;
        }
    }
}
