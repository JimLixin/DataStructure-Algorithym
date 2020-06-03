using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 75. 颜色分类
/// https://leetcode-cn.com/problems/sort-colors/
/// </summary>
namespace Algorithym.LeetCode.Double_pointers
{
    public class _00075_颜色分类
    {
        /// <summary>
        /// 计数排序 + 两趟扫描算法
        /// 时间：O(M*N)
        /// 空间: O(M)
        /// </summary>
        /// <param name="nums"></param>
        public void SortColors(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return;
            int pos = 0;
            int[] data = new int[3];
            for (int n = 0; n < nums.Length; n++) data[nums[n]]++;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < data[i]; j++)
                {
                    nums[pos++] = i;
                }
            }
        }

        /// <summary>
        /// 双指针， 三路快排
        /// 时间：O(N)
        /// 空间: O(1)
        /// </summary>
        /// <param name="nums"></param>
        public void SortColorsV2(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return;
            int p0 = 0, p2 = nums.Length - 1, cur = 0;
            while (cur <= p2)
            {
                if (nums[cur] == 0)
                    swap(nums, p0++, cur++);
                else if (nums[cur] == 2)
                    swap(nums, p2--, cur);
                else
                    cur++;
            }
        }

        public void swap(int[] nums, int i, int j)
        {
            int tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
        }
    }
}
