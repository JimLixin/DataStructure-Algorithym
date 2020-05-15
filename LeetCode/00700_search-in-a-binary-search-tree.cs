using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 700. 二叉搜索树中的搜索
/// https://leetcode-cn.com/problems/search-in-a-binary-search-tree/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00700_search_in_a_binary_search_tree
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null) return null;
            if (root.val == val) return root;
            return root.val > val ? SearchBST(root.left, val) : SearchBST(root.right, val);
        }
    }
}
