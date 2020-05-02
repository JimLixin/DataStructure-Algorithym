using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// 349. 两个数组的交集
    /// https://leetcode-cn.com/problems/intersection-of-two-arrays/
    /// </summary>
    public class intersection_of_two_arrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums1.Length == 0 || nums2 == null || nums2.Length == 0) return new int[0];
            HashSet<int> map1 = new HashSet<int>(nums1);
            HashSet<int> map2 = new HashSet<int>(nums2);
            return map1.Count > map2.Count ? getInterSection(map2, map1) : getInterSection(map1, map2);
        }

        public int[] getInterSection(HashSet<int> set1, HashSet<int> set2)
        {
            List<int> data = new List<int>();
            foreach (int n in set1)
            {
                if (set2.Contains(n))
                    data.Add(n);
            }
            return data.ToArray();
        }
    }
}
