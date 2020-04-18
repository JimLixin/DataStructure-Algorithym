using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
    /// </summary>
    public class convert_sorted_array_to_binary_search_tree
    {
        private int[] _nums;
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return null;
            _nums = nums;
            return buildTree(0, _nums.Length - 1);
        }

        public TreeNode buildTree(int start, int end)
        {
            int mid = (start + end) / 2 + (start + end) % 2;
            TreeNode node = new TreeNode(_nums[mid]);
            if (mid > start)
                node.left = buildTree(start, mid - 1);
            if (mid < end)
                node.right = buildTree(mid + 1, end);

            return node;
        }
    }
}
