using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/jump-game/
    /// </summary>
    public class jump_game
    {
        public bool CanJump(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return false;
            return _canJump(nums, nums.Length - 1);
        }

        public bool _canJump(int[] nums, int index)
        {
            if (index == 0)
                return true;
            for (int i = index - 1; i >= 0; i--)
            {
                if (nums[i] >= (index - i))
                {
                    //Console.WriteLine($"Current is {nums[i]} at {(index - i)} steps to {nums[index]}.");
                    return _canJump(nums, i);
                }
            }
            return false;
        }
    }
}
