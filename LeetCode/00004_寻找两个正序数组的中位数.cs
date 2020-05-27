using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 4. 寻找两个正序数组的中位数
/// https://leetcode-cn.com/problems/median-of-two-sorted-arrays/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00004_median_of_two_sorted_arrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int len1 = nums1.Length, len2 = nums2.Length, p1 = len1 - 1, p2 = len2 - 1;
            int[] data = new int[len1 + len2];
            for (int i = data.Length - 1; i >= 0; i--)
            {
                if (p1 < 0)
                    data[i] = nums2[p2--];
                else if (p2 < 0)
                    data[i] = nums1[p1--];
                else
                    data[i] = nums1[p1] > nums2[p2] ? nums1[p1--] : nums2[p2--];
            }
            return (data.Length & 1) > 0 ? data[(data.Length - 1) >> 1] : (data[(data.Length - 1) >> 1] + data[((data.Length - 1) >> 1) + 1]) / 2.0;
        }
    }
}
