using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 88. 合并两个有序数组
/// https://leetcode-cn.com/problems/merge-sorted-array/
/// </summary>
/// 
namespace Algorithym.LeetCode
{

    public class merge_sorted_array
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] result = nums1.Take(m).Concat(nums2).ToArray();
            Array.Sort(result);
            for (int i = 0; i < result.Length; i++)
            {
                nums1[i] = result[i];
            }
        }

        /// <summary>
        /// Why???
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        public void MergeV2(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;

            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k--] = nums1[i--];
                }
                else
                {
                    nums1[k--] = nums2[j--];
                }
            }
            while (i >= 0)
            {
                nums1[k--] = nums1[i--];
            }
            while (j >= 0)
            {
                nums1[k--] = nums2[j--];
            }
        }

        /// <summary>
        /// 自己想出来的新方法
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        public void MergeV3(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = m - 1, p2 = n - 1;
            for (int i = m + n - 1; i >= 0; i--)
            {
                if (p1 < 0)
                    nums1[i] = nums2[p2--];
                else if (p2 < 0)
                    nums1[i] = nums1[p1--];
                else
                    nums1[i] = nums1[p1] > nums2[p2] ? nums1[p1--] : nums2[p2--];
            }
        }
    }
}
