using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 18. 四数之和
/// https://leetcode-cn.com/problems/4sum/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00018_4sum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums == null || nums.Length == 0)
                return result;
            Array.Sort(nums);
            int len = nums.Length;
            for (int i = 0; i < len - 3; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                for (int j = i + 1; j < len - 2; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1]) continue;
                    int l = j + 1, r = len - 1;
                    while (l < r)
                    {
                        int sum = nums[i] + nums[j] + nums[l] + nums[r];
                        if (sum == target)
                        {
                            result.Add(new int[] { nums[i], nums[j], nums[l], nums[r] });
                            while (l < r && nums[l + 1] == nums[l]) l++;
                            while (l < r && nums[r - 1] == nums[r]) r--;
                            r--;
                            l++;
                        }
                        else if (sum > target)
                            r--;
                        else
                            l++;
                    }
                }
            }

            return result;
        }
    }
}
