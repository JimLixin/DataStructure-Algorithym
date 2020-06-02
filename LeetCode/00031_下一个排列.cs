using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 31. 下一个排列
/// https://leetcode-cn.com/problems/next-permutation/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00031_下一个排列
    {
        public void NextPermutation(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return;
            int len = nums.Length, index = -1;
            for (int i = len - 1; i > 0; i--)
            {
                if (nums[i] > nums[i - 1])
                {
                    index = i;
                    break;
                }
            }
            if (index > 0)
            {
                int pos = -1;
                for (int n = len - 1; n >= index; n--)
                {
                    if (nums[index - 1] < nums[n])
                    {
                        pos = n;
                        break;
                    }
                }
                Swap(nums, index - 1, pos);
                Reverse(nums, index, len - 1);
            }
            else
                Reverse(nums, 0, len - 1);
        }

        public void Swap(int[] nums, int a, int b)
        {
            int tmp = nums[a];
            nums[a] = nums[b];
            nums[b] = tmp;
        }

        public void Reverse(int[] nums, int start, int end)
        {
            int p1 = -1, p2 = -1, mid = start + (end - start) / 2;
            if (((end - start) & 1) == 0)
            {
                p1 = mid - 1;
                p2 = mid + 1;
            }
            else
            {
                p1 = mid;
                p2 = mid + 1;
            }
            while (p1 >= start && p2 <= end) Swap(nums, p1--, p2++);
        }
    }
}
