using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 04.02. 最小高度树
/// https://leetcode-cn.com/problems/minimum-height-tree-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class 最小高度树
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return null;
            return helper(nums, 0, nums.Length - 1);
        }

        public TreeNode helper(int[] nums, int start, int end)
        {
            if (start > end) return null;
            int mid = start + (end - start) / 2;
            TreeNode node = new TreeNode(nums[mid]);
            node.left = helper(nums, start, mid - 1);
            node.right = helper(nums, mid + 1, end);
            return node;
        }
    }
}
