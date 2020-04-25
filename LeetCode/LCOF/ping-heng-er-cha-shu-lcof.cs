using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题55 - II. 平衡二叉树
    /// https://leetcode-cn.com/problems/ping-heng-er-cha-shu-lcof/
    /// </summary>
    public class ping_heng_er_cha_shu_lcof
    {
        public bool IsBalanced(TreeNode root)
        {
            return root == null ? true : (Math.Abs(MaxDepth(root.left) - MaxDepth(root.right)) < 2 && IsBalanced(root.left) && IsBalanced(root.right));
        }

        public int MaxDepth(TreeNode root)
        {
            return root == null ? 0 : (1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right)));
        }
    }
}
