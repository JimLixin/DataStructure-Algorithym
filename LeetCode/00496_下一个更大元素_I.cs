using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 496. 下一个更大元素 I
/// https://leetcode-cn.com/problems/next-greater-element-i/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00496_下一个更大元素_I
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int[] result = new int[nums1.Length];
            for (int i = 0; i < nums2.Length; i++)
            {
                for (int j = i + 1; j < nums2.Length; j++)
                {
                    if (nums2[j] > nums2[i])
                    {
                        dic.Add(nums2[i], nums2[j]);
                        break;
                    }
                }
            }
            for (int i = 0; i < nums1.Length; i++)
                result[i] = dic.ContainsKey(nums1[i]) ? dic[nums1[i]] : -1;
            return result;
        }
    }
}
