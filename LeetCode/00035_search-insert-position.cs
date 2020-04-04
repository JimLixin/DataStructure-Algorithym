using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    public static class search_insert_position
    {
        public static int Answer(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int start = 0, end = nums.Length - 1, pivot1, pivot2, result = 0, mid;
            while (start < end)
            {
                mid = (start + end) / 2;
                pivot1 = nums[mid];
                if ((end - start + 1) % 2 > 0)
                {
                    if (target > pivot1)
                        start = mid;
                    else
                        end = mid;
                }
                else
                {
                    pivot2 = nums[mid + 1];
                    if (target < pivot1)
                    {
                        end = mid;
                    }
                    else if (target == pivot1)
                    {
                        result = mid;
                        break;
                    }
                    else if (target > pivot2)
                    {
                        start = mid + 1;
                    }
                    else if (target == pivot2)
                    {
                        result = mid + 1;
                        break;
                    }
                    else
                    {
                        result = mid + 1;
                        break;
                    }
                }
            }
            if (start == end)
            {
                result = nums[start] == target ? start : (nums[start] > target ? start - 1 : start + 1);
            }
            return result < 0 ? 0 : result;
        }
    }
}
