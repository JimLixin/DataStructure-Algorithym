using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题33. 二叉搜索树的后序遍历序列
    /// https://leetcode-cn.com/problems/er-cha-sou-suo-shu-de-hou-xu-bian-li-xu-lie-lcof/
    /// </summary>
    public class BinaryPostOrderValidation
    {
        public bool VerifyPostorder(int[] postorder)
        {
            if (postorder == null || postorder.Length == 0)
                return true;
            return verify(postorder, 0, postorder.Length - 1);
        }

        public bool verify(int[] nums, int start, int end)
        {
            if (start >= end)
                return true;
            int mid = end;
            while (mid > start && nums[mid] >= nums[end])
            {
                mid--;
            }
            for (int i = start; i < mid; i++)
            {
                if (nums[i] > nums[end])
                    return false;
            }
            return verify(nums, start, mid) && verify(nums, mid + 1, end - 1);
        }
    }
}
