using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// 350. 两个数组的交集 II
    /// https://leetcode-cn.com/problems/intersection-of-two-arrays-ii/
    /// </summary>
    public class intersection_of_two_arrays_ii
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums1.Length == 0 || nums2 == null || nums2.Length == 0) return new int[0];
            return nums1.Length > nums2.Length ? getIntersect(nums1, nums2) : getIntersect(nums2, nums1);
        }

        public int[] getIntersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (dic.ContainsKey(nums1[i]))
                    dic[nums1[i]]++;
                else
                    dic.Add(nums1[i], 1);
            }
            List<int> data = new List<int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                if (dic.ContainsKey(nums2[i]) && dic[nums2[i]] > 0)
                {
                    data.Add(nums2[i]);
                    dic[nums2[i]]--;
                }
            }
            return data.ToArray();
        }
    }
}
