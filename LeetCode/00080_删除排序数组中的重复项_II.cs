using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 80. 删除排序数组中的重复项 II
/// https://leetcode-cn.com/problems/remove-duplicates-from-sorted-array-ii/
/// </summary>
/// 
namespace Algorithym.LeetCode
{

    public class _00080_remove_duplicates_from_sorted_array_ii
    {
        /// <summary>
        /// 双指针
        /// Note: 双指针解法通常需要一个隐含指针（此处为for循环中的i）,来作为辅助指针。
        /// 在此之前曾经尝试过用while循环，但是总是写不出正确的逻辑。
        /// 还有就是没有必要做swap!会导致逻辑上的漏洞,直接用fast指针的value去覆盖slow指针即可。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int count = 0, slow = 0, fast = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    count++;
                else
                    count = 0;
                if (count < 2)
                {
                    nums[slow] = nums[fast];
                    slow++;
                }
                fast++;
            }
            return slow;
        }
    }
}
