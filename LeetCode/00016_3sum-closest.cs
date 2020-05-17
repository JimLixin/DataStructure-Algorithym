using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 16. 最接近的三数之和
/// https://leetcode-cn.com/problems/3sum-closest/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00016_3sum_closest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0) return -1;
            Array.Sort(nums);
            int min = int.MaxValue, result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                int left = i + 1, right = nums.Length - 1;
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (min > Math.Abs(sum - target))
                    {
                        min = Math.Abs(sum - target);
                        result = sum;
                    }

                    if (sum < target)
                        left++;
                    else if (sum > target)
                        right--;
                    else
                        return sum;
                }
            }
            return result;
        }
    }
}
