using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 45. 跳跃游戏 II
/// https://leetcode-cn.com/problems/jump-game-ii/
/// </summary>
namespace Algorithym.LeetCode
{
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
            if (nums == null || nums.Length == 0)
                return 0;
            int max = -1, count = 0, target = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                max = Math.Max(max, (i + nums[i]));
                if (target == i)
                {
                    count++;
                    target = max;
                }


            }
            return count;
        }
    }
}
