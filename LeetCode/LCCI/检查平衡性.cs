using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 04.04. 检查平衡性
/// https://leetcode-cn.com/problems/check-balance-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class 检查平衡性
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;
            return Math.Abs(getHeight(root.left) - getHeight(root.right)) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
        }

        public int getHeight(TreeNode node)
        {
            if (node == null) return 0;
            return 1 + Math.Max(getHeight(node.left), getHeight(node.right));
        }
    }
}
