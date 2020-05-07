using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 334. 递增的三元子序列
/// https://leetcode-cn.com/problems/increasing-triplet-subsequence/
/// </summary>
namespace Algorithym.LeetCode
{
    /// <summary>
    /// 自己想出来的原始版本
    /// </summary>
    public class _00334_increasing_triplet_subsequence
    {
        public bool IncreasingTriplet(int[] nums)
        {
            if (nums == null || nums.Length < 3)
                return false;
            List<int> data = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                bool find = false;
                for (int j = 0; j < data.Count; j++)
                {
                    if (data[j] >= nums[i])
                    {
                        find = true;
                        data[j] = nums[i];
                        break;
                    }
                }
                if (!find)
                    data.Add(nums[i]);
                if (data.Count == 3)
                    return true;
            }
            return false;
        }
    }

    /// <summary>
    /// 看题解优化过的版本
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
