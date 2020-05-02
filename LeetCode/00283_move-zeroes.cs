using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// 283. 移动零
    /// Note：双指针
    /// https://leetcode-cn.com/problems/move-zeroes/
    /// </summary>
    public class move_zeroes
    {
        public void MoveZeroes(int[] nums)
        {
            int left = 0, right = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (right++ >= nums.Length) break;
                if (nums[i] != 0) left++;
                if (i < nums.Length - 1 && nums[i] == 0 && nums[i + 1] != 0)
                {
                    nums[right] = nums[right] ^ nums[left];
                    nums[left] = nums[right] ^ nums[left];
                    nums[right] = nums[right] ^ nums[left];
                    left++;
                }
            }
        }
    }
}
