using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1379. 找出克隆二叉树中的相同节点
/// https://leetcode-cn.com/problems/find-a-corresponding-node-of-a-binary-tree-in-a-clone-of-that-tree/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _01379_find_a_corresponding_node_of_a_binary_tree_in_a_clone_of_that_tree
    {
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            if (cloned == null)
                return null;
            if (cloned.val == target.val)
                return cloned;
            TreeNode left = GetTargetCopy(original, cloned.left, target);
            TreeNode right = GetTargetCopy(original, cloned.right, target);
            return left == null ? right : left;
        }
    }
}
