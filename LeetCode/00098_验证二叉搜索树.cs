using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 98. 验证二叉搜索树
/// https://leetcode-cn.com/problems/validate-binary-search-tree/
/// </summary>
/// 
namespace Algorithym.LeetCode
{

    public class _00098_validate_binary_search_tree
    {
        int? max;
        bool result;
        public bool IsValidBST(TreeNode root)
        {
            result = true;
            travel(root);
            return result;
        }

        public void travel(TreeNode node)
        {
            if (node == null) return;
            travel(node.left);
            if (max != null && node.val <= max)
            {
                result = false;
                return;
            }
            max = node.val;
            travel(node.right);
        }
    }
}
