using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 27. 移除元素
/// https://leetcode-cn.com/problems/remove-element/
/// </summary>
namespace Algorithym.LeetCode
{

    public static class remove_element
    {
        public static int Answer(int[] nums, int val)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int len = nums.Length;
            int curDelete = 0, lastAvailable = len - 1, tmp;
            bool available = false;

            while (curDelete < lastAvailable)
            {
                if (nums[curDelete] == val)
                {
                    while (curDelete < lastAvailable - 1)
                    {
                        if (nums[lastAvailable] != val)
                            break;

                        lastAvailable--;
                    }
                    if (nums[lastAvailable] != val)
                    {
                        tmp = nums[lastAvailable];
                        nums[lastAvailable] = nums[curDelete];
                        nums[curDelete] = tmp;
                    }

                    lastAvailable--;
                }
                curDelete++;
            }
            return nums[lastAvailable] != val ? lastAvailable + 1 : lastAvailable;
        }

        public static int ImprovedAnswer(int[] nums, int val)
        {
            int start = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[start] = nums[i];
                    start++;
                }
            }
            return start;
        }
    }
}
