using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 239. 滑动窗口最大值
/// https://leetcode-cn.com/problems/sliding-window-maximum/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00239_sliding_window_maximum
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0)
                return new int[0];

            int len = nums.Length, max = 0;
            int[] left = new int[len];
            int[] right = new int[len];
            int[] result = new int[len - k + 1];
            for (int i = 0; i < len; i++)
            {
                if (i % k == 0)
                    max = int.MinValue;
                if (nums[i] > max)
                    max = nums[i];
                left[i] = max;
            }
            for (int i = len - 1; i >= 0; i--)
            {
                if (i % k == k - 1 || i == len - 1)
                    max = int.MinValue;
                if (nums[i] > max)
                    max = nums[i];
                right[i] = max;
            }
            //Console.WriteLine(string.Join(",", left));
            //Console.WriteLine(string.Join(",", right));
            for (int i = 0; i < len - k + 1; i++)
            {
                result[i] = Math.Max(left[i + k - 1], right[i]);
            }
            return result;
        }
    }
}
