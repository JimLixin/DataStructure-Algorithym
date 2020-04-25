using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题55 - I. 二叉树的深度
    /// https://leetcode-cn.com/problems/er-cha-shu-de-shen-du-lcof/
    /// </summary>
    public class er_cha_shu_de_shen_du_lcof
    {
        public int MaxDepth(TreeNode root)
        {
            return root == null ? 0 : (1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right)));
        }
    }
}
