using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.Topics
{
    public class Remove_Duplicates
    {
        /// <summary>
        /// 删除排序数组中的重复项
        /// 注： 此例题要求的是删除后使每个元素最多不超过两次重复
        /// 我们可以实现一个更通用的方法 RemoveDuplicates(int[] nums, int k)
        /// 例子：https://leetcode-cn.com/problems/remove-duplicates-from-sorted-array-ii/
        /// </summary>
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int fast = 0, slow = 0, count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    count++;
                else
                    count = 1;
                nums[slow] = nums[fast];
                fast++;
                if (count <= 2)
                    slow++;
            }
            return slow;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k">删除后使每个元素允许重复的最大次数</param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int fast = 0, slow = 0, count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    count++;
                else
                    count = 1;
                nums[slow] = nums[fast];
                fast++;
                if (count <= k)
                    slow++;
            }
            return slow;
        }

    }

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
