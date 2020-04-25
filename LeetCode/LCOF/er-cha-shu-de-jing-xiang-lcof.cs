using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题27. 二叉树的镜像
    /// https://leetcode-cn.com/problems/er-cha-shu-de-jing-xiang-lcof/
    /// </summary>
    public class er_cha_shu_de_jing_xiang_lcof
    {
        public TreeNode MirrorTree(TreeNode root)
        {
            if (root == null)
                return null;
            TreeNode tmp = root.left;
            root.left = root.right;
            root.right = tmp;
            MirrorTree(root.left);
            MirrorTree(root.right);
            return root;
        }
    }
}
