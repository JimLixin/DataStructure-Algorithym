using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-duplicate-number/
    /// </summary>
    public class find_the_duplicate_number
    {
        public int FindDuplicate(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if ((nums[i] ^ nums[i + 1]) == 0)
                    return nums[i];
            }
            return -1;
        }

        /// <summary>
        /// 二分法+抽屉原理
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindDuplicateV3(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return -1;
            int left = 1, right = nums.Length - 1;
            while (left < right)
            {
                int cnt = 0;
                int mid = left + (right - left) / 2;
                for (int i = 0; i <= nums.Length - 1; i++)
                {
                    if (nums[i] <= mid)
                        cnt++;
                }
                if (cnt > mid)
                    right = mid;
                else
                    left = mid + 1;
            }
            return left;
        }

        /// <summary>
        /// Fast solution !!! need to understanding.
        /// Note: So, here is an approach that is based on Floyd’s cycle finding algorithm. We use this to detect loop in a linked list.
        ///https://www.geeksforgeeks.org/find-duplicates-constant-array-elements-0-n-1-o1-space/
        /// https://www.geeksforgeeks.org/detect-loop-in-a-linked-list/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindDuplicateV2(int[] nums)
        {
            int fast = nums[0];
            int slow = nums[0];

            do
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            }
            while (slow != fast);

            fast = nums[0];
            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[fast];
            }

            return slow;
        }
    }
}
