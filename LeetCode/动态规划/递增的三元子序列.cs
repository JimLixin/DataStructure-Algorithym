using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 334. 递增的三元子序列
/// https://leetcode-cn.com/problems/increasing-triplet-subsequence/
/// </summary>
namespace Algorithym.LeetCode.Dynamic_Progamming
{
    /// <summary>
    /// 双指针做法
    /// </summary>
    public class _00334_increasing_triplet_subsequence_V2
    {
        public bool IncreasingTriplet(int[] nums)
        {
            if (nums == null || nums.Length < 3)
                return false;
            int max1 = int.MaxValue, max2 = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (max1 >= nums[i])
                    max1 = nums[i];
                else if (max2 >= nums[i])
                    max2 = nums[i];
                else return true;
            }
            return false;
        }
    }
}
