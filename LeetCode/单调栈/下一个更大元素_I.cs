using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.单调栈
{
    public class 下一个更大元素_I
    {
        /// <summary>
        /// 暴力解法
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 单调栈做法
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int[] NextGreaterElementV2(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dic = getMap(nums2);
            int[] result = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
                result[i] = dic[nums1[i]];
            return result;
        }

        public Dictionary<int, int> getMap(int[] nums)
        {
            Stack<int> s = new Stack<int>();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                while (s.Count > 0 && s.Peek() <= nums[i])
                {
                    s.Pop();
                }
                dic.Add(nums[i], s.Count == 0 ? -1 : s.Peek());
                s.Push(nums[i]);
            }
            return dic;
        }
    }
}
