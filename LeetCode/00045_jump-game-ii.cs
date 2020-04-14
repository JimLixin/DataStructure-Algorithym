using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/jump-game-ii/
    /// </summary>
    public class jump_game_ii
    {
        public int Jump(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int start = 0, end = nums.Length - 1, count = 0;
            while (end > 0)
            {
                if (nums[start] >= (end - start))
                {
                    end = start;
                    start = 0;
                    count++;
                }
                else
                {
                    start++;
                }
            }
            return count;
        }

        public int JumpV2(int[] nums)
        {
            return 0;
        }
    }
}
