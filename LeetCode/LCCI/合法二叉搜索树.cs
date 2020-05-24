using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 04.05. 合法二叉搜索树
/// https://leetcode-cn.com/problems/legal-binary-search-tree-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class 合法二叉搜索树
    {
        public bool IsValidBST(TreeNode root)
        {
            if (root == null) return true;
            int? max = null;
            Stack<TreeNode> s = new Stack<TreeNode>();
            TreeNode node = root;
            while (node != null || s.Count > 0)
            {
                while (node != null)
                {
                    s.Push(node);
                    node = node.left;
                }
                node = s.Pop();
                if (max != null && node.val <= max)
                    return false;
                else
                    max = node.val;
                node = node.right;
            }
            return true;
        }
    }
}
