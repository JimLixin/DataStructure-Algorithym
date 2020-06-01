using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 324. 摆动排序 II
/// https://leetcode-cn.com/problems/wiggle-sort-ii/
/// </summary>
namespace Algorithym.LeetCode.排序
{
    public class _00324_摆动排序_II
    {
        public void WiggleSort(int[] nums)
        {
            if (nums == null || nums.Length < 2)
                return;
            int len = nums.Length, mid = (len - 1) / 2, pos = 0, p1 = mid, p2 = len - 1;
            int[] data = new int[len];
            for (int n = 0; n < len; n++) data[n] = nums[n];
            Array.Sort(data);
            while (pos < len)
            {
                if (p1 >= 0)
                    nums[pos++] = data[p1--];
                if (p2 >= mid + 1)
                    nums[pos++] = data[p2--];
            }
        }
    }
}
